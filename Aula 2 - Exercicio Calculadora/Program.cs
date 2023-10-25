/*
 * Calculadora
 * lufer
 * lufer@ipca.t
 * 29-09-2023
 * ESI-POO
 * */

using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrador da calculadora

            int a = Operacoes.Soma(2, 4);
            Console.WriteLine("A soma de {0} com {1} = {2}", 2, 4, a);

            Console.WriteLine("A potência de {0} levantado {1} = {2}", 2, 4, Operacoes.Potencia(2,4));


        }
    }
}
