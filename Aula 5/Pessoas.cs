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
    /// Purpose: Classe que gere um conjunto de Pessoas
    /// Created by: lufer
    /// Created on: 10/17/2023 4:53:05 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoas
    {
        #region Attributes
        const int MAXPESSOAS = 10;
         string nomeTurma;  
         static int totPessoa;
         static Pessoa[] turma;   //atributo de classe

        #endregion

        #region Methods

        #region Constructors


        /// <summary>
        /// Construtor de classe
        /// </summary>
        static Pessoas()
        {
            totPessoa = 0;
            turma = new Pessoa[MAXPESSOAS];
            //inicializar array turma!!!

        }

        #endregion

        #region Properties


        /// <summary>
        /// Devolve o conjunto de pessoas existentes
        /// </summary>
        public static Pessoa[] Turma
        {
            get { return (Pessoa[])turma.Clone(); }
            set { } // EVITAR!
        }

        public static int TotalPessoas
        {
            get { return totPessoa; }
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Mostra todas as pessoas existentes!!!
        /// Este método ou não deve estar nesta classe!
        /// Tou deve ser privado!!!
        /// </summary>
        private void ShowPessoas()
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
        public static bool ExistePessoa(string nome)
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
        public static int QuantasPessoas(string nome)
        {
            int cont = 0;
            foreach (Pessoa p in turma)
            {
                if (p.Nome == nome) cont++;
            }
            return cont;
        }

        /// <summary>
        /// Insere uma pessoa no conjunto
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserePessoa(Pessoa p)
        {
            //Validações: //return false;
            turma[totPessoa] = p;
            totPessoa++;
            return true;
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
