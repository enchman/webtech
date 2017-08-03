using System;
using System.IO;
using System.Reflection;

namespace ServiceConsole
{
    class Program
    {
        public static string serviceFolder = "services";
        static void Main(string[] args)
        {
            string workFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string command = null;
            do
            {
                // Await for command
                command = Console.ReadLine();
                var info = CommandInfo.Create(command);

                Console.Clear();
                Console.WriteLine(info.IsError ? "Failed" : "Success");
                if (!info.IsError)
                {
                    Console.WriteLine("Command: {0}", info.Command);
                    Console.WriteLine("Value: {0}", info.Value);
                }
            }
            while (command != "exit");
        }

        static void Execute()
        {

        }
    }
}