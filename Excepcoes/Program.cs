using System;
using System.Collections;
using System.Collections.Generic;

namespace Excepcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime d = new DateTime(2023, 02, 29);
            }catch (Exception e)
            {
                Console.WriteLine("data inválida");
            }

            #region DEMO

            int x = 0;

            //DateTime c = new DateTime(2023, 2, 30);

            int[] vvv = new int[3];
            //vvv[3] = 2;


            //try
            //{
            //    x = int.Parse(Console.ReadLine());
            //}
            //catch (OutOfMemoryException e)
            //{
            //    Console.WriteLine("Atento!!!!" + e.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("String invalida: " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Falhou:" + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Fixe");
            //}


            Pessoa p2 = new Pessoa();
            p2.numero = 101;
            try
            {
                bool xx = Pessoas.InserePessoa(p2);
            }
            catch(PessoasException e)
            {
                Console.WriteLine("RECEBI: "+e.Message);
            }
            catch(Exception e) 
            {
                
                throw new PessoasException(" OLA ", e);
            }

            #endregion

            #region Generics

            Pessoa p1 = new Pessoa();
            p1.numero = 12;
            List<Pessoa> p = new List<Pessoa>();
            p.Add(new Pessoa());
            p.Add(p1);
            //p.Add(2);

            foreach(Pessoa i in p)
            {
                Console.WriteLine(i.numero);
            }

            if (p.Contains(p1)){ }

            //p.Sort();

            ArrayList pess = new ArrayList();
            pess.Add(new Pessoa());
            //pess.Add(2);

            foreach(object o in pess)
            {
                Console.WriteLine(((Pessoa)o).numero);
            }

            //pess.Sort();

            X a = new X();

            X<int> v = new X<int>();
            X<Pessoa> v2 = new X<Pessoa>();

            X<ArrayList, int> pk = new X<ArrayList, int>();
            X<Dictionary<int, List<Pessoa>>, int> pk2 = new X<Dictionary<int, List<Pessoa>>, int>();

            #endregion

            #region EXCEPTION_30-11

            try
            {
                throw new ClubeErradoException("Viva o Benfica");
            }
            catch(ClubeErradoException e)
            {
                Console.Write("MSG: "+e.Message);

                //throw new ClubeErradoException("Mais texto", e);
            }

            try
            {
                bool res = GerePessoas.FazCoisas("ola");
            }
            catch(Exception e)
            {
                Console.WriteLine("Houve qualquer erro.." + e.Message);
            }

            #endregion
        }
    }
    }
