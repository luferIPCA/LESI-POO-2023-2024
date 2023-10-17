/*
*	<copyright file="Aula_5.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/17/2023 4:53:05 PM</date>
*	<description></description>
**/
using System;

namespace Aula_5
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/17/2023 4:53:05 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoas
    {
        #region Attributes

        public string nomeTurma;  
        public static Pessoa[] turma;   //atributo de classe

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoas()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Devolve o conjunto de pessoas existentes
        /// </summary>
        public static Pessoa[] Turma
        {
            get { return (Pessoa[])turma.Clone(); }
            //set       EVITAR!
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Mostra todas as pessoas existentes!!!
        /// </summary>
        private void ShowPersons()
        {
            for(int i=0; i < turma.Length; i++)
            {
                Console.WriteLine("Pessoa: {0}", turma[i].Nome);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool ExistePessoa(string nome)
        {
            foreach(Pessoa p in turma)
            {
                if (p.Nome == nome) return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica quantas pessoas existem na turma
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <returns></returns>
        public int QuantasPessoas(string nome)
        {
            int cont = 0;
            foreach (Pessoa p in turma)
            {
                if (p.Nome == nome) cont++;
            }
            return cont;
        }

        //Quantas Pessoas com o nome "X" existem? FEITO
        
        //--- TPC ---

        //Qual a pessoa mais velha?
        //Quantas "Marias" existem?
        //Mostrar a turma ordenada pelos nomes?
        //Onde está a pessoa?

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoas()
        {
        }
        #endregion

        #endregion
    }
}
