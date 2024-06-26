using System;
using System.Security.Cryptography.X509Certificates;

namespace HtmlEditor
{       
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("+");
            for (int i=0; i <=30; i++)
                Console.Write("-");
            Console.Write("+");

            Console.Write("\n");

            for (int line=0; line<=10; line++)
            {
                Console.Write("|");
                for (int i=0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i=0; i<=30; i++)
                Console.Write("-");
            Console.Write("+");

            Console.Write("\n");
        }

    }
}
