using System;

namespace Turno_2___Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region A

            Aluno a1 = new Aluno(12, "Manuel");

            Console.WriteLine("Nome:" + a1.Nome.ToLower());
            Console.WriteLine("Numero:" + a1.Numero);
   
            Console.WriteLine(a1.FichaAluno());

            #endregion

            int x = 10;
            Console.WriteLine(x.ToString());

            Aluno a2 = new Aluno();
            Console.WriteLine(a2.ToString()); ;

            Turma t1 = new Turma();
            t1.InsereAlunoTurma(a1);
            t1.InsereAlunoTurma(a2);
            //t1.MostraTurma();

            IO.MostraTurmaConsola(t1);



            //Console.WriteLine("Hello World!");
        }
    }
}
