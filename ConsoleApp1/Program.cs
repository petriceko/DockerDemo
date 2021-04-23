using System;
using System.ServiceProcess;
using System.Linq;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var services = ServiceController.GetServices();
            var dellServices = services.Where(x => x.ServiceName.Contains("Dell")).ToList();

            var allProcesses = Process.GetProcesses();
        }
    }
}
