using System;
using messagePrinter;


namespace SimpleDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new messagePrintingService("TEST MESSAGE");
            
            service.printMessage();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
