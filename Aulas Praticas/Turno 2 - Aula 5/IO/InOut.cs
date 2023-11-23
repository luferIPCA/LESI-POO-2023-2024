/**
 * 
 * */

using InterfacesDLL;
using System;

namespace IO
{
    public class InOut
    {
        public static void MostraFichaProdutoEcra(IProduto p)
        {
            Console.WriteLine("Cod: " + p.CodProduto);
        }

        public static void MostraTodosProdutos(IProduto[] varios)
        {
            foreach(IProduto p in varios)
            {
                Console.WriteLine("Cod: " + p.CodProduto);
            }
        }
    }
}
