/*
*	<copyright file="Aula_1_Turno1.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/12/2023 2:43:41 PM</date>
*	<description></description>
**/
using System;

namespace Turno_1___Aula_2
{
    /// <summary>
    /// Purpose: Classe Aluno integra conjunto de Alunos: CUIDADO
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

        //Abordagem em que Alunos consta na classe Aluno: EVITAR
        //Variáveis de classe
        public static int totAlunos;
        static Aluno[] turma;

        #endregion

        #region Methods

        #region Constructors

        static Aluno(){
            totAlunos = 0;
            turma = new Aluno[50];
        }

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
            numero = -1;
            nome = String.Empty;    //""
            //totAlunos++;
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
            //totAlunos++;
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
            //totAlunos++;
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

        public static Aluno[] AlunosTurma
        {
            //get { return turma; } //EVITAR
            get { return (Aluno[])turma.Clone(); }
            //set
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("=> Nome: {0} - Numero: {1}", nome, numero);
        }
        #endregion

        #region OtherMethods
        /// <summary>
        /// Insere o próprio registo
        /// </summary>
        /// <returns></returns>
        public bool InsereAluno()
        {
            //Validações
            //return false;
            turma[totAlunos] = this;
            totAlunos++;
            return true;
        }

        public void MostraAluno()
        {
            Console.WriteLine(this.ToString());
        }
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

        #region METODOS_CLASSE

        public static bool InsereAluno(Aluno a1)
        {
            //Validações retur false;
            turma[totAlunos] = a1;
            totAlunos++;
            return true;
        }

        #endregion
    }
}
