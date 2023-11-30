

using System;
using ObjetosNegocio;
using RegrasNegocio;

namespace GereZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.nome = "Javali";

            bool aux = RegrasGerirZoo.InserirAnimal(a);
        }
    }
}
