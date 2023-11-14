using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___Interfaces
{
    public interface IPessoa
    {
        int Idade { set; get; }
        string NomeMaiusculas();

    }
}
