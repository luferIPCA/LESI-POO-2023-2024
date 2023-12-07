using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Incendios;

namespace TesteFire
{
    [TestClass]
    public class UnitFire
    {
        [TestMethod]
        public void TestIncendioRepetido()
        {
            //1ª
            Incendio i1 = new Incendio(1, 1, DateTime.Now);
            Incendio i2 = new Incendio(1, 1, DateTime.Now);
            FireReal x = new FireReal();
            bool f;

            //2
            f=x.AddIncendio(i1);
            f=x.AddIncendio(i2);

            //3
            Assert.IsTrue(f, "CUIDADO!!! Repetidos");
        }

        [TestMethod]
        public void TestForaLimite()
        {

        }


    }
}
