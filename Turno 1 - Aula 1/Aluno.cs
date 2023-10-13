/*
*	<copyright file="Aula_1_Turno1.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/12/2023 2:43:41 PM</date>
*	<description></description>
**/
using System;

namespace Aula_1_Turno1
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/12/2023 2:43:41 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Aluno
    {
        #region Attributes

        private int numero;
        private string nome;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
            numero = -1;
            nome = String.Empty;    //""
        }

        /// <summary>
        /// Constroi um objeto aluno
        /// </summary>
        /// <param name="num">Número do Aluno</param>
        /// <param name="no">Nome do Aluno</param>
        public Aluno(int num, string no)
        {
            numero = num;
            nome = no;
        }

        /// <summary>
        /// Constroi um objeto aluno
        /// </summary>
        /// <param name="num">Número do Aluno</param>
        /// <param name="no">Nome do Aluno</param>
        public Aluno(string no,int num )
        {
            numero = num;
            nome = no;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade...
        /// </summary>
        public int Numero
        {
            set { 
                numero = value; 
            }
            get { 
                return numero; 
            }
        }

        /// <summary>
        /// Propriedade...
        /// </summary>
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
        ~Aluno()
        {
        }
        #endregion

        #endregion
    }
}
