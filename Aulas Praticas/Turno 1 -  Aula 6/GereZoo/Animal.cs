/*
*	<copyright file="GereZoo.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 2:59:25 PM</date>
*	<description></description>
**/
using System;

namespace GereZoo
{
    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/23/2023 2:59:25 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Animal
    {
        #region Attributes
        public string nome;
        public DateTime nasc;
        [NonSerialized]
        public int idade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Animal()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public int CalculaIdade()
        {
            //rever a formula de calculo de idade
            return (DateTime.Today.Year - nasc.Year+2);
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Animal()
        {
        }
        #endregion

        #endregion
    }
}
