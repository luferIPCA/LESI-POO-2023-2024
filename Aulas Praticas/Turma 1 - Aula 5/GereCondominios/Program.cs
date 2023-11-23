using System;
using Interfaces;

using InterfaceDLL;     //aluno: 23002

namespace GereCondominios
{
    class Program
    {
        static void Main(string[] args)
        {
            Condominio c1 = new Condominio();
            c1.Ano = DateTime.Now.Year;

            Condominio c2 = new Condominio();
            c2.Ano = DateTime.Now.Year + 1;

            MostraDados(c1);

            if (c1.CompareTo(c2) > 0)
            {

            }
                        
        }

        public static void MostraDados(ICondominio i)
        {
            Console.WriteLine(i.Contacto);
        }

        public static void MostraBilhete(IBilhete b)
        {
     
            Console.WriteLine("Desconto:" + b.Desconto.ToString());
        }
    }
}
