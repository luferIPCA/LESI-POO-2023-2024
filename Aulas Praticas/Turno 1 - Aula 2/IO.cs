/*
*	<copyright file="Turno_1___Aula_2.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/19/2023 3:51:29 PM</date>
*	<description></description>
**/
using System;

namespace Turno_1___Aula_2
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/19/2023 3:51:29 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class IO
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public IO()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static void MostraAluno(Aluno a1)
        {
            string msg = "------------ FICHA -------------- ";
            msg += " Nome =" + a1.Nome.ToUpper();
            msg +=  "Numero:" + a1.Numero;
            Console.WriteLine(msg);
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~IO()
        {
        }
        #endregion

        #endregion
    }
}
