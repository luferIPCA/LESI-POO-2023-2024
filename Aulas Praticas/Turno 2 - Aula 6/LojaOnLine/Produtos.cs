/*
*	<copyright file="LojaOnLine.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 4:58:47 PM</date>
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
    /// Created on: 11/23/2023 4:58:47 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Produtos
    {
        #region Attributes
        public string nomeLoja;
        public ArrayList produtos;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Produtos()
        {
            produtos = new ArrayList();
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool GravaProdutos(string fName)
        {
            Stream s = File.Open(fName, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, produtos);
            s.Close();
            return true;
        }

        public bool LoadProdutos(string fName)
        {
            Stream s = File.Open(fName, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            produtos = (ArrayList)b.Deserialize(s);
            s.Close();
            return true;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Produtos()
        {
        }
        #endregion

        #endregion
    }
}
