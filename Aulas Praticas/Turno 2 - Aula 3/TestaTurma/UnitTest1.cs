using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlunoDLL;

namespace TestaTurma
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Aluno a1 = new Aluno(1, "ola");
            Aluno a2 = new Aluno(1, "ola");

            bool aux = (a1 == a2);

            Assert.IsFalse(aux, "Falhou");
        }
    }
}
