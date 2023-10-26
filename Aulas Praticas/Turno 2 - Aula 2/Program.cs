using System;

namespace Turno_2___Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region A
            Aluno a1 = new Aluno(12, "Manuel");
            Aluno a2 = new Aluno(12, "Manuel");

            if (a1 == a2)
            //if(a1.Equals(a2))
            {

            }

            Console.WriteLine("Nome:" + a1.Nome.ToLower());
            Console.WriteLine("Numero:" + a1.Numero);
   
            Console.WriteLine(a1.FichaAluno());

            #endregion

            
            Turma t1 = new Turma();
            t1.InsereAlunoTurma(a1);
            t1.InsereAlunoTurma(a2);
            //t1.MostraTurma();

            IO.MostraTurmaConsola(t1);



            //Console.WriteLine("Hello World!");
        }
    }
}
