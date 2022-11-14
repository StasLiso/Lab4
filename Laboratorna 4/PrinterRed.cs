using System;

namespace Laboratorna_4
{
    class PrinterRed : Printer
    {
        public void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }
}
