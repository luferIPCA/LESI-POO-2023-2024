/*
*	<copyright file="LojaOnLine.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 4:48:39 PM</date>
*	<description></description>
**/
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LojaOnLine
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/23/2023 4:48:39 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GereFIcheiroProdutos
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public GereFIcheiroProdutos()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static bool GravaProdutos(string fName, ArrayList prods)
        {
            Stream s = File.Open(fName, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, prods);
            s.Close();
            return true;
        }

        public static ArrayList LoadProdutos(string fName)
        {
            ArrayList aux;

            Stream s = File.Open(fName, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            aux = (ArrayList)b.Deserialize(s);
            s.Close();
            return aux;
        }

        public static void Mostra(ArrayList prods)
        {
            foreach(Produto po in prods)
            {
                Console.WriteLine($"Id: {po.id} - Nome:{po.nome} - Data: {po.criado} - Custo: {po.custo} ");
            }
        }


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~GereFIcheiroProdutos()
        {
        }
        #endregion

        #endregion
    }
}
