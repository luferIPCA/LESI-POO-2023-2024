/**
 * lufer
 * email
 * data
 * */
using System;
using Produtos;
using InterfacesDLL;
using IO;

namespace GereComercioEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.CodProduto = 12;
            InOut.MostraFichaProdutoEcra(p);


            VariosProdutos varios = new VariosProdutos();

            varios.InsereProduto(p);
            if (varios.ExisteProduto(p.CodProduto) == true)
            {

            }




        }
    }
}
