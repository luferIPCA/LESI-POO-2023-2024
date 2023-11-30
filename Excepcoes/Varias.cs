/*
*	<copyright file="Excepcoes.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/28/2023 5:05:09 PM</date>
*	<description></description>
**/
using System;

namespace Excepcoes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/28/2023 5:05:09 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Varias
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Varias()
        {
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods

        public static bool FazCoisas(string s)
        {
            try
            {
                if (s == "")
                    throw new ClubeErradoException("Problema na string");
                return true;
            }
            catch (ClubeErradoException e)
            {
                //return (false);           //EVITAR
                throw;
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Varias()
        {
        }
        #endregion

        #endregion
    }


    public class PessoasException : ApplicationException
    {
        public PessoasException() : base("PESSOAS MÁS") {
        }

        public PessoasException(string s): base(s) { }

        public PessoasException(string g, Exception e)
        {
            throw new PessoasException(g + "-" + e.Message);
        }

    }


    public class GerePessoas
    {

        public static bool FazCoisas(string s)
        {
            try
            {
                return (Varias.FazCoisas(s));
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
