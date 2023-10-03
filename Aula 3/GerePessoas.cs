/*
 * Manipulação de Classes e Objetos em C#
 * lufer
 * lufer@ipca.pt
 * 02-10-2023
 * POO-ESI
 * **/

using System;

namespace Aula_3
{
    /// <summary>
    /// Classe Principal...
    /// </summary>
    class GerePessoas
    {
        /// <summary>
        /// Método principal...
        /// </summary>
        /// <param name="args">Valor do exterior</param>
        static void Main(string[] args)
        {
            int x=2;

            Pessoa p1; //declara p1 como um objeto do tipo Pessoa
            p1 = new Pessoa();  //criei um objeto
            
            //o mesmo que:
            Pessoa p2 = new Pessoa();

            p2.Idade = 30;      //set
            p2.Nome = "Eu";
            Console.WriteLine("Nome: {0}, Idade: {1}", p2.Nome, p2.Idade);  //get


            Pessoa p3 = new Pessoa(12, "Paulo");
            Console.WriteLine("Nome: {0}, Idade: {1}", p3.Nome, p3.Idade);

            Aluno a;
            

            Console.ReadKey();
        }
    }
}
