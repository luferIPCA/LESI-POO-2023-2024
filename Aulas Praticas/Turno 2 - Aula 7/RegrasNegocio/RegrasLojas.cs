using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjetosNegocio;
using Dados;
using Excecoes;

namespace RegrasNegocio
{
    public class RegrasLojas
    {
        public static bool InsereProduto(Produto p)
        {
            if (p.custo > 1000) return false;
            try
            {
                Produtos.InsereProdutoBD(p);
                return true;
            }
            catch (ProdutosException e)
            {
                throw new ProdutosException("Falha de Regras de Negocio " + "-" + e.Message);
                //throw new Exception(e.Message +  " - Falha de Regras de Negocio");
            }
        }

    }
}
