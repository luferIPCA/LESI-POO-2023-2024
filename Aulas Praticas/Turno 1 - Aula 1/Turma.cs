/*
*	<copyright file="Aula_1_Turno1.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/12/2023 3:09:17 PM</date>
*	<description></description>
**/
using System;

namespace Aula_1_Turno1
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/12/2023 3:09:17 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Turma
    {
        #region Attributes
        const int MAXALUNOS=400;

        private int numAlunos;
        string nome;
        private Professor p;
        private Aluno[] alunos;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Turma()
        {
            alunos = new Aluno[MAXALUNOS];
            numAlunos = 0;
            p = new Professor();
            p.Nome = "";
            p.Gabinete = -1;
        }

        public Turma(int maxAlunos)
        {
            if(maxAlunos>MAXALUNOS)
                alunos = new Aluno[MAXALUNOS];
            else
                alunos = new Aluno[numAlunos];
            p = new Professor();
            p.Nome = "";
            p.Gabinete = -1;
            numAlunos = 0;
        }

        /// <summary>
        /// Cria uma Turma
        /// </summary>
        /// <param name="maxAlunos">Máximo de alunos por turma</param>
        /// <param name="nomeProf">Nome do Professor</param>
        /// <param name="gabProf">Número do Gabinete do Professor</param>
        public Turma(int maxAlunos, string nomeProf, int gabProf)
        {
            if (maxAlunos > MAXALUNOS)
                alunos = new Aluno[MAXALUNOS];
            else
                alunos = new Aluno[maxAlunos];
            //inicializa
            for(int i=0; i < maxAlunos; i++)
            {
                alunos[i] = new Aluno();
            }

            p = new Professor();
            p.Nome = nomeProf;
            p.Gabinete = gabProf;
            numAlunos = 0;
        }
    

        #endregion

        #region Properties

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeP">Nome do Professor</param>
        /// <param name="numG">Número do Gabinete....</param>
        /// <returns></returns>
        public bool AtribuiProfessorTurma(string nomeP, int numG)
        {
            //Validações
            p.Nome = nomeP;
            p.Gabinete = numG;
            return true;
        }

        #region ALUNOS

        /// <summary>
        /// Cria e Insere aluno numa turma
        /// </summary>
        /// <param name="nomeA"></param>
        /// <param name="numA"></param>
        /// <returns></returns>
        public bool InsereAlunoTurma(string nomeA, int numA)
        {
            //Validações
            //alunos[numAlunos] = new Aluno();
            //alunos[numAlunos].Nome = nomeA;
            //alunos[numAlunos].Numero = numA;
            //ou
            alunos[numAlunos] = new Aluno(nomeA,numA);

            numAlunos++;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool InsereAlunoTurma(Aluno a)
        {
            //Validações
            alunos[numAlunos].Nome = a.Nome;
            alunos[numAlunos].Numero = a.Numero;
            numAlunos++;
            return true;
        }

        #endregion

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Turma()
        {
        }
        #endregion

        #endregion
    }
}
