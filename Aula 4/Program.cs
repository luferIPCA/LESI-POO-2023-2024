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
            #region ARRAYUNIDIMENSIONAL

            int[] v = new int[10];
            v[0] = 12;
            v[0]++;

            //for (int i = 0 ; i < v.Length; i++)
            int j = 0;
            for (; ; )
            {
                if (j < v.Length)
                {
                    Console.WriteLine("v[{0}] = {1}", j, v[j]);
                    //Console.WriteLine($"V[i] = v[i]");
                    j++;
                }
                else
                    break;
            }

            #endregion

            #region ARRAYBIDIMENSIONAL

            //#define LINHAS 10
            const int LINHAS = 10;
            const int COLUNAS = 15;

            int[,] valores = new int[LINHAS, COLUNAS];

            valores[0, 0] = v[0];
            valores[0, 0] += 2;
            valores[0, 0]--;
            valores[7, 8] = 12;

            for (int k = 0; k < valores.GetLength(0); k++)
                for (int l = 0; l < valores.GetLength(1); l++)
                    Console.WriteLine("v[{0},{1}] = {2}", k, l, valores[k, l]);

            #endregion

            #region JAGGED ARRAY
            //TPC
            #endregion

            #region ARRAYSOBJETOS

            Pessoa[] turma = new Pessoa[MAXPESSOAS];

            //turma[0] = new Pessoa();
            //turma[0].Nome = "Ola";

            //inicializa o array!!!!
            for (int i = 0; i < MAXPESSOAS; i++)
            {
                turma[i] = new Pessoa();
            }

            turma[0].Nome = "Ola";

            //Procurar num array
            bool existe = false;
            for (int i = 0; i < MAXPESSOAS; i++)
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
            foreach (Pessoa p in turma)
            {
                //printf("Nome: %s\n!,p.Nome);
                if (p.Nome.Length > 0)
                    Console.WriteLine("Nome:" + p.Nome);
            }

            for (int i = 0; i < MAXPESSOAS; i++)
            {
                if (turma[i].Nome.Length > 0)
                    Console.WriteLine("Nome:" + turma[i].Nome);
            }

            //do
            //while 

            #endregion

            Console.ReadKey();
        }
    }
}
