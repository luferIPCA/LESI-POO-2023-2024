using System;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArraySimples

            int[] v = new int[10];
            v[0] = 12;
            v[0]++;



            //for (int i = 0 ; i < v.Length; i++)
            int i = 0;
            for (; ; ) {
                if (i < v.Length)
                {
                    Console.WriteLine("v[{0}] = {1}", i, v[i]);
                    //Console.WriteLine($"V[i] = v[i]");
                    i++;
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

            for (int j = 0; j < valores.GetLength(0); j++)
                for (int l = 0; l < valores.GetLength(1); l++)
                    Console.WriteLine("v[{0},{1}] = {2}", j, l, valores[j, l]);



            #endregion

            #region OUTRA

            Clube[,] federacao = new Clube[5, 5];

            //Inicialização
            for (int j = 0; j < federacao.GetLength(0); j++)
                for (int l = 0; l < federacao.GetLength(1); l++)
                    federacao[j, l] = new Clube();

            //Manipulação
            Clube a = new Clube();
            a.nome = "Benfica";
            federacao[0, 0] = a;

            for (int j = 0; j < federacao.GetLength(0); j++)
                for (int l = 0; l < federacao.GetLength(1); l++)
                    Console.WriteLine("Federacao[{0},{1}] = {2}", j, l, federacao[j, l].nome);
            #endregion

            #region JAGGED ARRAY
            //TPC
            #endregion

            //Pessoas p = new Pessoas();

            Frontend.ShowPersons(Pessoas.Turma);
        }
    }
}
