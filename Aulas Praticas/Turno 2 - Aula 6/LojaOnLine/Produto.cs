/*
*	<copyright file="LojaOnLine.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 4:28:32 PM</date>
*	<description></description>
**/
using System;

namespace LojaOnLine
{
    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/23/2023 4:28:32 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Produto
    {
        #region Attributes
        public int id;
        public string nome;
        public DateTime criado;
        [NonSerialized]
        public double custo;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Produto()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public double CalculaCusto()
        {
            return (criado.Year + 2);   //Inventar menos!!!
            
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Produto()
        {
        }
        #endregion

        #endregion
    }
}
