/*
 * 
 **/

using System;
using UmaPessoa;    //Biblioteca externa

namespace GerePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(12, "Maria"); //usa Classe externa
            Console.WriteLine(p.ToString());
        }
    }
}
