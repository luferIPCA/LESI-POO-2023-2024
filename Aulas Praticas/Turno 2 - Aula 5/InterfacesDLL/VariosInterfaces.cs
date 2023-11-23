using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDLL
{

    public interface IProduto
    {
        int CodProduto { get; set; }
    }

    public interface IVariosProdutos
    {
        bool InsereProduto(IProduto p);
        bool ExisteProduto(int codProduto);
    }
}
