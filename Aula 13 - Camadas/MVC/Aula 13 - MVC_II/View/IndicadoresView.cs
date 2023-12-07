/*
*	<copyright file="IndicadoresView.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/15/2020 12:26:13 PM</date>
*	<description></description>
**/



using MVC_II.Controller;
using MVC_II.Model;
using System;

namespace MVC_II.View
{

    public interface IIndicadoresView
    {
        void QuantasMortes();
        void QuantosRecuperados();
        void QuantosInfetados();

        void ShowAll();

        void ShowHistory();
    }
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/15/2020 12:26:13 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class IndicadoresView : IIndicadoresView
    {
        private IIndicadoresControl indControl;

        public IndicadoresView(IIndicadoresControl iC)
        {

            indControl = iC;
            indControl.SetView(this);
        }

        public void QuantasMortes()
        {
            Console.WriteLine("Mortes:");
            indControl.MoreDeads( int.Parse(Console.ReadLine())); //Parsing????
        }

        public int QuantasMortesII()
        {
            Console.WriteLine("Mortes:");
            //indControl.MoreDeads(int.Parse(Console.ReadLine())); //Parsing????
            return int.Parse(Console.ReadLine());
        }
        public void QuantosRecuperados()
        {
            Console.WriteLine("Recuperados:");
            indControl.MoreRecovered(int.Parse(Console.ReadLine()));
        }
        public void QuantosInfetados()
        {
            Console.WriteLine("Infetados:");
            indControl.MoreInfected(int.Parse(Console.ReadLine()));
        }

        public void ShowAll()
        {
            Console.WriteLine("Infetados:" + indControl.Infetados());
            Console.WriteLine("Recuperados:"+ indControl.Recuperados());
            Console.WriteLine("Mortes:" + indControl.Mortes());
        }

        public void ShowHistory()
        {


        }
    }
}
