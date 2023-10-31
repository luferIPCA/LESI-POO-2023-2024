/*
*	<copyright file="Aula_9___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 4:54:09 PM</date>
*	<description></description>
**/
using System;

namespace Aula_9___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2023 4:54:09 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Transporte
    {
        #region Attributes

        int ano;
        string marca;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Transporte()
        {
            ano = 2023;
        }

        public Transporte(int a)
        {
            ano = a;
            ano = IncAno();
        }

        #endregion

        #region Properties
        public int Ano
        {
            get { return ano; }
            set { if (value > 0) ano = value; else ano = -1; }
        }

        public virtual string MostraTransporte()
        {
            return (String.Format("Ano:{0}", ano));

        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        private int IncAno()
        {
            ano++;
            return ano;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Transporte()
        {
        }
        #endregion

        #endregion
    }
}
