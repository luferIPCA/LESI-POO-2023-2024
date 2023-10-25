using System;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa(12,"Maria");
            bool aux = Pessoas.InserePessoa(p1);
            if (aux)
                Console.WriteLine("Inserido! Total de Pessoas: {0})",Pessoas.TotalPessoas);

            Pessoa p2 = new Pessoa(23,"Manuel");
            aux = Pessoas.InserePessoa(p2);
            if (aux)
                Console.WriteLine("Inserido! Total de Pessoas: {0})", Pessoas.TotalPessoas);

            Frontend.ShowPessoas(Pessoas.Turma);
        }
    }
}
