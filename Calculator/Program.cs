using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soma();
            // Subtracao();
            // Multiplicacao();
            // Divisao();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Digite o número correspondente ao tipo de cálculo que deseja realizar:");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");

            short menu = short.Parse(Console.ReadLine());

            switch (menu) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break; //System.Environment.Exit(0) e usado para sair. E necessario importar "using System".
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float soma = v1 + v2;

            Console.WriteLine("");
            
            // Console.WriteLine("O resultado da soma é " + soma);
            Console.WriteLine($"O resultado da soma é {soma}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");

            Console.ReadKey(); //Interrompe a execucao do programa ate que o usuario pressione uma tecla e o aplicativo termine ou exiba uma janela adicional de informacoes.
            
            Menu();
        }

        static void Subtracao ()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float subtracao = v1 - v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é {subtracao}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float multiplicacao = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicacao é {multiplicacao}");

            Console.ReadKey();
            Menu();
        }
        
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float divisao = v1 / v2;

            Console.WriteLine("");
            
            Console.WriteLine($"O resultado da divisão é {divisao}");

            Console.ReadKey();
            Menu();
        }

    }
}
