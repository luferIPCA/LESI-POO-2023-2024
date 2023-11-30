/*
*	<copyright file="LojaOnLine.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 4:58:47 PM</date>
*	<description></description>
**/
using System;
using System.Collections. Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Externa
using ObjetosNegocio;
using Excecoes;

namespace Dados
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
        string nomeLoja;
        static List<Produto> produtos;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Produtos()
        {
            produtos = new List<Produto>();
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods


        public static bool InsereProdutoBD(Produto p)
        {
            if (produtos.Contains(p))
                throw new ProdutosException();

                //return false;

            produtos.Add(p);
                return true;
        }
        public static bool GravaProdutos(string fName)
        {
            Stream s = File.Open(fName, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, produtos);
            s.Close();
            return true;
        }

        public static bool LoadProdutos(string fName)
        {
            Stream s = File.Open(fName, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            produtos = (List<Produto>)b.Deserialize(s);
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
