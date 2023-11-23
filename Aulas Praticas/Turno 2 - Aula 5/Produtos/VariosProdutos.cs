/*
*	<copyright file="Produtos.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/16/2023 4:54:33 PM</date>
*	<description></description>
**/
using System.Collections.Generic;

using InterfacesDLL;

namespace Produtos
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/16/2023 4:54:33 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class VariosProdutos : IVariosProdutos
    {
        #region Attributes
        //Produto[] prods;
        //ArrayList prods;
        List<IProduto> prods;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public VariosProdutos()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool InsereProduto(IProduto p)
        {
            //
            prods[0] = (Produto)p;
            return true;

        }

        public bool ExisteProduto(int cod)
        {
            //
            return true;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~VariosProdutos()
        {
        }
        #endregion

        #endregion
    }
}
