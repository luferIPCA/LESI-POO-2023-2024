/*
*	<copyright file="Aula_9___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 5:01:10 PM</date>
*	<description></description>
**/
using System;

namespace Aula_9___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2023 5:01:10 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro : Transporte
    {
        #region Attributes

        string matricula;
        //string marca;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
        }

        #endregion

        #region Properties

        public string Matricula
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
        ~Carro()
        {
        }
        #endregion

        #endregion
    }
}
