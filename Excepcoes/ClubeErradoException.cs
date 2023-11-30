/*
*	<copyright file="Excepcoes.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/30/2023 2:39:53 PM</date>
*	<description></description>
**/
using System;

namespace Excepcoes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/30/2023 2:39:53 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ClubeErradoException : ApplicationException
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ClubeErradoException() : base("Clube Errado")
        {
        }

        public ClubeErradoException(string s) : base(s) { }

        public ClubeErradoException( string s, Exception e)
        {
            string aux = e.Message + "-" + s;
            throw new ClubeErradoException(aux);
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ClubeErradoException()
        {
        }
        #endregion

        #endregion
    }
}
