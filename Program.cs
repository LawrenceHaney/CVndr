using System;
using CVndr.Controller;

namespace CVndr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
           new CVndrController().Run();
        }
    }
}
