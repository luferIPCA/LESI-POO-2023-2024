/*
*	<copyright file="Aula_1___Turno_2.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/12/2023 5:05:57 PM</date>
*	<description></description>
**/
using System;

namespace Aula_1___Turno_2
{
    /// <summary>
    /// Purpose: Descreve uma turma de alunos
    /// Created by: lufer
    /// Created on: 10/12/2023 5:05:57 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Turma
    {
        #region Attributes
        const int MAXTAMTURMA= 50;

        int numAlunos;      //alunos desta turma
        string turno;
        static int totAlunosNasTurmas; //todos os alunos em todas as turmas!!!
        Aluno[] alunos;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Turma()
        {
            alunos = new Aluno[MAXTAMTURMA];
            InitializeArray(alunos);
            numAlunos = 0;            
        }

        public Turma(int maxAlunos)
        {
            if (maxAlunos <= MAXTAMTURMA)
            {
                alunos = new Aluno[maxAlunos];
                InitializeArray(alunos);
            }
            else
            {
                alunos = new Aluno[MAXTAMTURMA];
                InitializeArray(alunos);
            }
            
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool InsereAlunoTurma(string nome, int num)
        {
            //Validações => return false;
            alunos[numAlunos] = new Aluno(nome, num);
            numAlunos++;
            totAlunosNasTurmas++;
            return true;
        }

        public bool InsereAlunoTurma(Aluno a)
        {
            //Validações => return false;
            alunos[numAlunos] = a;
            numAlunos++;
            totAlunosNasTurmas++;
            return true;
        }

        #region AUXILIAR
        void InitializeArray(Aluno[] v)
        {
            for(int i=0; i < v.Length; i++)
            {
                v[i] = new Aluno();
            }
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
