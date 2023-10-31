using System;

namespace Aula_9___POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Transporte t1 = new Transporte();          //ano==2023

            Transporte t2 = new Transporte(2011);     //ano =2011

            //Transporte t1 = new Carro();               //O que acontece?

            Carro c1 = new Carro();
            c1.Ano = 2022;

            Aviao a1 = new Aviao();
            a1.Ano = 2023;
            a1.TemAsas = ASAS.GRANDES;

            Console.WriteLine(a1.MostraTransporte());
            Console.WriteLine(c1.MostraTransporte());

            BTT b1 = new BTT();
            b1.Ano = 2023;
            b1.Eletrica = false;
            b1.MostraBTT();
            b1.MostraTransporte();

        }
    }
}
