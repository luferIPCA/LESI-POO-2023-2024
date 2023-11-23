using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICondominios
    {
        bool InsereCondominio(ICondominio a);
        bool ExisteCondominio(string contacto);

        string ContactoCondominio(int numCondom);
    }
}
