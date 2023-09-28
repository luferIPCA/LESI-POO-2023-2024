/*
 * lufer
 * hoje
 * 
 * */

using System;

namespace Aula_1
{
    /// <summary>
    /// Programa....
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calcula a soma de dois valores inteiros...
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns>int</returns>
        static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Metodo...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int x = Soma(2, 3);
            Console.WriteLine("Soma de {0} com {1} = {2}",2,3,x);
        }
    }
}
