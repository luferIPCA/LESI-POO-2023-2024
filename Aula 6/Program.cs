/*
 * lufer
 * lufer@ipca.pt
 * 24-10-2023
 * Operadores e Overrides
 */

using System;

namespace Aula_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            
            int x = 7;
            int y = 7;

            if (x == y)
            {
                Console.WriteLine("Int Iguais");
            }

            Pessoa p1 = new Pessoa(12, "Ola");
            Pessoa p2 = new Pessoa(12, "Ola");

            if (p1==p2) 
                Console.WriteLine("Pessoas Iguais");
            else
                Console.WriteLine("Pessoas Diff");


            Console.WriteLine("Valor de X: " + x);

            Console.WriteLine("Pessoa: " + p1.ToString());

            if(p1.Nome.Equals(p2.Nome))
            //if (p1.Nome == p2.Nome)
            {

            }

            if (p1.Equals(p2))
            {
                Console.WriteLine("Pessoas Iguais");
            }
        }
    }
}
