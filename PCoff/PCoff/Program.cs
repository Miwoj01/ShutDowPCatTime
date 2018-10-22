using System;
using System.Diagnostics;
using System.Threading;

namespace PCoff
{
    internal class Program
    {
        private static int Menu()
        {
            Console.WriteLine("Welcome in PCoff program, choose your option :)");
            Console.WriteLine("1. Shutdown the pc.");
            Console.WriteLine("2. Reebot.");
            Console.WriteLine("3. Close system at time.");
            Console.WriteLine("4. Exit.");
            Console.Write("Choose your option: ");
            int choose = int.Parse(Console.ReadLine());
            Console.Clear();
            return choose;
        }

        private static void Shutdown_pc()
        {
            var process = new ProcessStartInfo("shutdown", "/s /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Console.WriteLine("Closing...[Press ENTER to confirm]");
            Console.ReadLine();
            Console.ReadKey();
            Process.Start(process);
        }

        private static void Reebot()
        {
            var process = new ProcessStartInfo("shutdown", "/r /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Console.WriteLine("Reeboting...");
            Console.ReadKey();
            Process.Start(process);
        }

        private static void At_time()
        {
            Console.Write("Enter the time you want to shutdown your computer in 24 - hour format[xx: xx]: ");
            string time = Console.ReadLine();
            Console.WriteLine("Waiting...");

            while (time != Time_pc())
            {
                Thread.Sleep(59999);
            }
            Shutdown_pc();
        }

        private static string Time_pc()
        {
            string time_now = DateTime.Now.ToString("HH:mm");
            return time_now;
        }

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                switch (Menu())
                {
                    case 1: Shutdown_pc(); break;
                    case 2: Reebot(); break;
                    case 3: At_time(); break;
                    case 4: Environment.Exit(0); break;
                    default: { Console.WriteLine("There is not that option yet."); Thread.Sleep(250); } break;
                }
            }
        }
    }
}