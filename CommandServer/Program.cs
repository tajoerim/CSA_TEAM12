using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using RobotCtrl;

namespace CommandServer
{
    class Program
    {
        private static readonly Robot robot = new Robot();

        private static float Speed = 0.5f;
        private static float Acceleration = 0.3f;

        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            Console.WriteLine("Listening on Port 8080");

            while (true)
            {
                // Commands
                Console.WriteLine("Waiting for connection ...");
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Connected to " + client.Client.RemoteEndPoint);
                HandleConnection(client);
                Console.WriteLine("Connection closed.");
            }
        }

        private static void SendHttpResponse(StreamWriter writer, String body)
        {
            writer.WriteLine("HTTP/1.1 200 OK");
            writer.WriteLine("Content-Type: text/plain");
            writer.WriteLine("Content-Length: " + Encoding.ASCII.GetByteCount(body));
            writer.WriteLine();
            writer.WriteLine(body);
            writer.Flush();
        }

        private static void HandleConnection(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter responseStream = new StreamWriter(client.GetStream());

            string httpHeader = string.Empty;
            do
            {
                httpHeader = sr.ReadLine();
            } while (!httpHeader.Equals("ready", StringComparison.InvariantCultureIgnoreCase));

            // Alle Commands empfangen
            List<string> commands = new List<string>();
            string command = string.Empty;
            do
            {
                command = sr.ReadLine();
                Console.WriteLine("Command: " + command);
                commands.Add(command);
            } while (!command.Equals("start", StringComparison.InvariantCultureIgnoreCase));

            // Response to client
            SendHttpResponse(responseStream, "THANK YOU!");

            // Commandos in Log schreiben
            logCommands(commands);

            // Alle Commands ausführen
            robot.Drive.Power = true;
            foreach (string cmd in commands)
            {
                if (cmd == null || cmd.Equals("Start", StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }
                string[] split = cmd.Trim().Split(':');

                if (split.Length == 2)
                {
                    string comm = split[0];
                    string arg = split[1];
                    if (comm == "TrackLine")
                    {
                        TrackLine(arg);
                    }
                    else if (comm == "TrackTurnLeft")
                    {
                        TrackTurnLeft(arg);
                    }
                    else if (comm == "TrackTurnRight")
                    {
                        TrackTurnRight(arg);
                    }
                    else if (comm == "TrackArcLeft")
                    {
                        TrackTurnArcLeft(arg);
                    }
                    else if (comm == "TrackArcRight")
                    {
                        TrackTurnArcRight(arg);
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid command {cmd}");
                }
            }

            client.Close();
        }

        private static void TrackLine(string args)
        {

            float meter = float.Parse(args);
            Console.WriteLine("Run Command: 'TrackLine' with parameter " + meter);
            robot.Drive.RunLine(meter, Speed, Acceleration);
            IsRobotReady();
        }

        private static void TrackTurnLeft(string args)
        {
            float grad = float.Parse(args);
            Console.WriteLine("Run Command: 'TrackTurnLeft' with parameter " + grad);
            robot.Drive.RunTurn(grad, Speed, Acceleration);
            IsRobotReady();
        }

        private static void TrackTurnRight(string args)
        {
            float grad = float.Parse(args);
            Console.WriteLine("Run Command: 'TrackTurnRight' with parameter " + grad);
            robot.Drive.RunTurn((-1) * grad, Speed, Acceleration);
            IsRobotReady();
        }

        private static void TrackTurnArcLeft(string args)
        {
            string[] split = args.Split(',');
            float angle = float.Parse(split[0]);
            float radius = float.Parse(split[1]);
            Console.WriteLine("Run Command: 'TrackArcLeft' with parameter " + radius + " " + angle);
            robot.Drive.RunArcLeft(radius, angle, Speed, Acceleration);
            IsRobotReady();
        }

        private static void TrackTurnArcRight(string args)
        {
            string[] split = args.Split(',');
            float angle = float.Parse(split[0]);
            float radius = float.Parse(split[1]);
            Console.WriteLine("Run Command: 'TrackArcRight' with parameter " + radius + " " + angle);
            robot.Drive.RunArcRight(radius, angle, Speed, Acceleration);
            IsRobotReady();
        }

        private static void logCommands(List<string> commands)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("log.txt", true);
            foreach (String cmd in commands)
            {
                string DateTime = System.DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"); // This might be wrong on the robot
                file.WriteLine(DateTime + " " + cmd);
            }
            file.Close();
        }

        static void IsRobotReady()
        {
            while (!robot.Drive.Done)
            {
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
