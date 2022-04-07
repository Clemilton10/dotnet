using System;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static string Input(string df)
        {
            string vl = Console.ReadLine() ?? df;
            vl = String.IsNullOrEmpty(vl) ? df : vl;
            return vl;
        }
        static void Cls()
        {
            Console.Clear();
        }
        static void Print(string tx)
        {
            Console.WriteLine(tx);
        }
        static void Menu()
        {
            Cls();
            Print("0-Sair");
            Print("1-Abrir");
            Print("2-Criar");
            short option = short.Parse( Input("0") );
            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar(); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {

        }
        static void Criar()
        {
            Cls();
            Print("Digite o texto (ESC para sair):");
            Print("-------------------------------");
            string text = "";
            do
            {
                text += Input("");
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            Salvar(text);
        }
        static void Salvar(string text)
        {
            Cls();
            Print("QQual caminho?");
            string path = Input("C:\\users\\clemas\\desktop\\dotnet\\");
            using( var file = new StreamWriter(path) )
            {
                file.Write(text);
            }
            Print($"Arquivo {path} salvo com sucesso!");
            Menu();
        }
    }
}