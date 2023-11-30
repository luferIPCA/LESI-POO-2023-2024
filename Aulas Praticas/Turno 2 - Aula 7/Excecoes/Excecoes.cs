using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    public class ProdutosException : ApplicationException
    {
        public ProdutosException() : base("Erro em produtos")
        {

        }

        public ProdutosException(string s) : base(s) { }


        public ProdutosException(string s, Exception e)
        {
            throw new ProdutosException(s + "-" + e.Message);
        }
    }
}
