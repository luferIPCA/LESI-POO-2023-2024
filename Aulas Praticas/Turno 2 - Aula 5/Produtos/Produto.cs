
using System;
using InterfacesDLL;

namespace Produtos
{
    public class Produto : IProduto
    {
        int codProduto;
        DateTime valiade;

        public int CodProduto
        {
            get { return codProduto; }
            set { codProduto = value; }
        }
    }
}
