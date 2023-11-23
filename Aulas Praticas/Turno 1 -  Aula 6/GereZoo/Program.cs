using System;
using System.Collections;

namespace GereZoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal a = new Animal();
            a.nome = "Macaco";
            a.nasc = DateTime.Today;
            a.idade = a.CalculaIdade();

           #region V1

            ArrayList zoo = new ArrayList();

            zoo.Add(a);

            bool aux = GereFicheiro.GuardaDados("Zoo.dat", zoo);

            zoo.Clear();

            zoo = GereFicheiro.CarregaDados("Zoo.dat");
            Animal ani = ((Animal)(zoo[0]));

            foreach (Animal an in zoo) {
                an.idade = an.CalculaIdade();
                Console.WriteLine("Nome: {0} - Nasc: {1} - Idade: {2}", an.nome, an.nasc, an.idade);
            }
            Console.WriteLine("Done!");

            #endregion

            #region V2

            Zoo zoologico = new Zoo();
            zoologico.animais.Add(a);
            zoologico.GuardaDados("DadosZoologico.dat");

            zoologico.animais.Clear();

            zoologico.CarregaDados("DadosZoologico.dat");

            foreach (Animal an in zoologico.animais)
            {
                an.idade = an.CalculaIdade();
                Console.WriteLine("Nome: {0} - Nasc: {1} - Idade: {2}", an.nome, an.nasc, an.idade);
            }

            #endregion
        }
    }
}
