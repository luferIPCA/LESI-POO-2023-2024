using System;
using Fires;

namespace FiresManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Incendio i1 = new Incendio(DateTime.Now, "Barcelos", 300, 240);
            RealFire rf = new RealFire();
        }
    }
}
