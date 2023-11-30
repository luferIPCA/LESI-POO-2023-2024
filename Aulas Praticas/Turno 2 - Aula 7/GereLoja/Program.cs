using System;
//Externo
using ObjetosNegocio;
using RegrasNegocio;
using Excecoes;

namespace GereLoja
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "Ok";

            try
            {
                bool aux = RegrasLojas.InsereProduto(p);
            }
            catch(ProdutosException e)
            {
                Console.WriteLine("Não foi possivel!!! porque: " + e.Message);
            }
        }
    }
}
