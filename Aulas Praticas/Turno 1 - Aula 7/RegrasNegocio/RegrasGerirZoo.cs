using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjetosNegocio;
using Dados;

namespace RegrasNegocio
{
    public class RegrasGerirZoo
    {

        public static bool InserirAnimal(Animal a, Pessoa p)
        {
            if (Zoo.ExisteAnimal(a.nome)) return false;
            //if (a.nome == "") return false;
            return Zoo.InsereAnimalZoo(a);

        }
    }
}
