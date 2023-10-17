/*
*	<copyright file="Aula_5.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/17/2023 5:02:01 PM</date>
*	<description></description>
**/
using System;

namespace Aula_5
{
    /// <summary>
    /// Purpose: Apresenta dados na consola!!!
    /// Created by: lufer
    /// Created on: 10/17/2023 5:02:01 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Frontend
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Frontend()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Mostra todas as pessoas existentes!!!
        /// </summary>
        public static void ShowPersons(Pessoa[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("Pessoa: {0}", t[i].Nome);
            }
        }

        //Verificar se uma pessoa existe na turma????



        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Frontend()
        {
        }
        #endregion

        #endregion
    }
}
