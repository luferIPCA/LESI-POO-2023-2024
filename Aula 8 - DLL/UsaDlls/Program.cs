using System;
using Dll2;
using Dll1;

namespace UsaDlls
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.Ano = 2023;

            Pessoa p = new Pessoa();
            p.Idade = 18;
            p.C = c;

            Console.WriteLine("Hello World!");
        }
    }
}
