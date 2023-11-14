/*
*	<copyright file="Incendios.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2023 2:44:05 PM</date>
*	<description></description>
**/
using System;

namespace Incendios
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2023 2:44:05 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Incendio
    {
        #region Attributes

        int cumprimento;
        int largura;
        DateTime data;
        public string regiao;           //ATENÇÃO

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Incendio()
        {
            data = DateTime.Today;
            largura = 10;
            cumprimento = 10;
        }

        public Incendio(int larg, int cump, DateTime dia)
        {
            largura = larg;
            cumprimento = cump;
            data = dia;
        }

        #endregion

        #region Properties

        public int Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public int Cumprimento
        {
            get { return cumprimento; }
            set { cumprimento = value; }
        }

        public DateTime Data
        {
            get;
            set;
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Incendio()
        {
        }
        #endregion

        #endregion
    }
}
