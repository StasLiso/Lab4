using System;

namespace Laboratorna_4
{
    class PrinterBlue : Printer
    {
        public void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }
}
