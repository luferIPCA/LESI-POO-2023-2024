

using System;

namespace Calculadora
{
    public class Operacoes
    {
        #region Funcoes

        /// <summary>
        /// Calcula a soma de dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Calcula a.....
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Sub(int x, int y)
        {
            return (x - y);
        }

        /// <summary>
        /// Calcula a Potência de um valor
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static double Potencia(int b, int e)
        {
            return Math.Pow(b, e);
        }

        #endregion
    }
}
