/*
*	<copyright file="Fires.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2023 4:49:15 PM</date>
*	<description></description>
**/
using System;

namespace Fires
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2023 4:49:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Incendio
    {
        #region Attributes

        public int largura;     //ATENÇÃO
        public int cumprimento;
        DateTime dia;
        public string regiao;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Incendio()
        {
            regiao = "";
            dia = DateTime.Today;
            largura = 0;
            cumprimento = 0;
        }


        public Incendio(DateTime d, string r, int l, int c)
        {
            dia = d;
            regiao = r;
            largura = l;
            cumprimento = c;
        }

        #endregion

        #region Properties

        public DateTime Dia
        {
            get { return dia; }
            set { dia = value; }
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
