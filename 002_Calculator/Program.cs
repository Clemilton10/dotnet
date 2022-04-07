using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Que operação deseja fazer?");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Sutração");
            Console.WriteLine("3-Divisão");
            Console.WriteLine("4-Multiplicação");
            Console.WriteLine("5-Sair");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Selecione:");
            Console.WriteLine("");
            string vl = Console.ReadLine() ?? "5";
            short r = short.Parse(vl);
            switch(r)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            string sv1 = Console.ReadLine() ?? "0";
            float v1 = float.Parse(sv1);

            Console.Clear();
            Console.WriteLine(v1);
            Console.WriteLine("Segundo valor:");
            string sv2 = Console.ReadLine() ?? "0";
            float v2 = float.Parse(sv2);

            //float sm = v1 + v2;
            Console.Clear();
            //Console.WriteLine("O Resultado é " + sm);
            //Console.WriteLine("O Resultado é " + (v1 + v2) );
            //Console.WriteLine($"O Resultado é {sm}");
            Console.WriteLine($"O Resultado é {v1 + v2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            string sv1 = Console.ReadLine() ?? "0";
            float v1 = float.Parse(sv1);

            Console.Clear();
            Console.WriteLine(v1);
            Console.WriteLine("Segundo valor:");
            string sv2 = Console.ReadLine() ?? "0";
            float v2 = float.Parse(sv2);

            //float sm = v1 - v2;
            Console.Clear();
            //Console.WriteLine("O Resultado é " + sm);
            //Console.WriteLine("O Resultado é " + (v1 - v2) );
            //Console.WriteLine($"O Resultado é {sm}");
            Console.WriteLine($"O Resultado é {v1 - v2}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            string sv1 = Console.ReadLine() ?? "0";
            float v1 = float.Parse(sv1);

            Console.Clear();
            Console.WriteLine(v1);
            Console.WriteLine("Segundo valor:");
            string sv2 = Console.ReadLine() ?? "0";
            float v2 = float.Parse(sv2);

            //float sm = v1 / v2;
            Console.Clear();
            //Console.WriteLine("O Resultado é " + sm);
            //Console.WriteLine("O Resultado é " + (v1 / v2) );
            //Console.WriteLine($"O Resultado é {sm}");
            Console.WriteLine($"O Resultado é {v1 / v2}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            string sv1 = Console.ReadLine() ?? "0";
            float v1 = float.Parse(sv1);

            Console.Clear();
            Console.WriteLine(v1);
            Console.WriteLine("Segundo valor:");
            string sv2 = Console.ReadLine() ?? "0";
            float v2 = float.Parse(sv2);

            //float sm = v1 * v2;
            Console.Clear();
            //Console.WriteLine("O Resultado é " + sm);
            //Console.WriteLine("O Resultado é " + (v1 * v2) );
            //Console.WriteLine($"O Resultado é {sm}");
            Console.WriteLine($"O Resultado é {v1 * v2}");
            Console.ReadKey();
            Menu();
        }
    }
}