using System;
using System.Collections;

namespace Aula_10___Collections
{

    class Pessoa: IComparable
    {
        public int idade;   //ATENCAO
        public int CompareTo(Object o)
        {
            if (this.idade > ((Pessoa)o).idade) return 1;
            else
                if (this.idade < ((Pessoa)o).idade) return -1;
            return 0;
        }


        public int FH(string s)
        {
            const int N = 51;
            int soma = 0;
            for (int i = 0; i < s.Length; i++)
                soma += s[i];

            return (soma % N);
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            //a.Add(100);
            ////a.Add("Benfica");
            //a.Add(10);
            //a.Sort();

            //if (!a.Contains(10)) 
            //    a.Add(10);
            
            Pessoa p = new Pessoa();
            p.idade = 12;
            a.Add(p);

            Pessoa p2 = new Pessoa();
            p2.idade = 3;
            a.Add(p2);

            foreach(Pessoa pes in a)
            {
                Console.WriteLine("Idade:" + pes.idade);
            }

            a.Sort();

            

            foreach (Pessoa pes in a)
            {
                Console.WriteLine("Idade:" + pes.idade);
            }

            Hashtable h=new Hashtable();

            int k = p.FH("Luis");
            Console.WriteLine("Luis: " + p.FH("Luis").ToString());
            Console.WriteLine("Luisa: " + p.FH("Luisa").ToString());
           
            h.Add(k, p);

            k = p.FH("Luisa");
            h.Add(k, p2);

            Console.WriteLine("Hello World!");
        }
    }
}
