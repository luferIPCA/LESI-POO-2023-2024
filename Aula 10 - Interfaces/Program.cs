using System;

namespace Aula_10___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Pessoa p1 = new Pessoa();

            OutraPessoa o1 = new OutraPessoa();

            Mulher m1 = new Mulher();

            Outra.F(o1);
            Outra.F(m1);

        }
    }
}
