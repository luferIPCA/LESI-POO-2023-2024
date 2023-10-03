/*
*	<copyright file="Aluno.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/3/2023 5:34:31 PM</date>
*	<description></description>
**/
using System;

namespace Aula_3
{
    /// <summary>
    /// Purpose: Aluno é Sub-classe de Pessoa
    /// Created by: lufer
    /// Created on: 10/3/2023 5:34:31 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Aluno: Pessoa
    {
        #region Attributes

        int numAluno;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
            numAluno = 0;
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
        ~Aluno()
        {
        }
        #endregion

        #endregion
    }
}
