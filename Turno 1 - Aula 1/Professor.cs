/*
*	<copyright file="Aula_1_Turno1.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/12/2023 3:05:20 PM</date>
*	<description></description>
**/
using System;

namespace Aula_1_Turno1
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/12/2023 3:05:20 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Professor
    {
        #region Attributes
        string nome;
        int gabinete;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Professor()
        {
            nome = "";
            gabinete = 0;
        }

        public Professor(string no, int gab)
        {
            nome = no;
            gabinete = gab;
        }

        #endregion

        #region Properties

        public int Gabinete
        {
            set { gabinete = value; }
            get { return gabinete; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
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
        ~Professor()
        {
        }
        #endregion

        #endregion
    }
}
