using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDLLs
{
     public class Carro
    {
        string matricula;
        int ano;

        public string Matricula
        {
            set;get;
        }

        public int Ano
        {
            get;set;
        }
    }

    class Parque
    {
        Carro[] carros;
    }
}
