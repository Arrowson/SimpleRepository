using System;

namespace messagePrinter
{
    public class messagePrintingService
    {
        public string message {get; set;} = "Default";
        public void printMessage(){
            Console.WriteLine(this.message);
        }
        public messagePrintingService(){}
        public messagePrintingService(string message){
            this.message = message;

        }

    }
}
