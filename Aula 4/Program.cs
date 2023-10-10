/*
 * lufer
 * Manipulação de Arrays em C#
 * */

using System;

namespace Aula_4
{
    class Program
    {
        const int MAXPESSOAS = 100;     //"equivale" ao #define
        static void Main(string[] args)
        {
            Pessoa[] turma= new Pessoa[MAXPESSOAS];

            //turma[0] = new Pessoa();
            //turma[0].Nome = "Ola";

            //inicializa o array!!!!
            for(int i=0; i<MAXPESSOAS; i++)
            {
                turma[i] = new Pessoa();
            }

            turma[0].Nome = "Ola";

            //Procurar num array
            bool existe = false;
            for(int i=0; i<MAXPESSOAS; i++)
            {
                //strcmp
                if (String.Compare("Ola", turma[i].Nome) == 0)
                {
                    existe = true;
                    break;
                }
            }

            Console.WriteLine(existe ? "Existe" : "Não existe");

            //Mostrar array
            foreach(Pessoa p in turma)
            {
                //printf("Nome: %s\n!,p.Nome);
                if(p.Nome.Length>0)
                    Console.WriteLine("Nome:" + p.Nome);
            }

            for(int i=0; i<MAXPESSOAS; i++)
            {
                if (turma[i].Nome.Length > 0)
                    Console.WriteLine("Nome:" + turma[i].Nome);
            }

            //do
            //while 
            Console.ReadKey();
        }
    }
}
