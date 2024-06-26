using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main (string[] agrs)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Você deseja contar em:");
            Console.WriteLine("S - Segundos -> Ex.: 10s = 10 segundos");
            Console.WriteLine("M - Minutos -> Ex.: 10m = 10 minutos");
            Console.WriteLine("0 - Sair");

            string data = Console.ReadLine().ToLower(); //ToLower - converte para minusculo
            char type = char.Parse(data.Substring(data.Length -1, 1));
            //char - um unico caracter;
            //Substring - metodo de string(0,1) p/ pegar parte da cadeia de caracters sendo 0 e o posicao do caracter e 1 e a quantidade de caracteres;
            //P/ contar sempre subtrai 1 porque a lista (array) comeca em 0;
            //Length - retorna a quantidade de caracteres digitados.
            int time = int.Parse(data.Substring(0, data.Length -1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart (time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
            
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Thread.Sleep e usado para delay em milisegundos. E necessario importar o "using System.Threading".
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
