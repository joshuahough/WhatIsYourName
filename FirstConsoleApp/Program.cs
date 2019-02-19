using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}");
            Console.Write("Press any key to exit... ");
            Console.ReadKey(true);
        }
    }
}
