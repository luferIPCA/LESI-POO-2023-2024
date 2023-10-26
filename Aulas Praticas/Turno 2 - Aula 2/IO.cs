/*
*	<copyright file="Turno_2___Aula_2.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/19/2023 5:31:47 PM</date>
*	<description></description>
**/
using System;

namespace Turno_2___Aula_2
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/19/2023 5:31:47 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class IO
    {
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        public static void MostraTurmaConsola(Turma t1)
        {
            foreach(Aluno a in t1.TurmaInteira)
            {
                if (a.Nome==string.Empty) continue; 
                //if (String.IsNullOrEmpty(a.Nome)) continue;
                //if (a.Nome == "") continue;
                Console.WriteLine(a.ToString());
            }
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
