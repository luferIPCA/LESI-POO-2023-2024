/*
*	<copyright file="Aula_1___Turno_2.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/12/2023 4:41:02 PM</date>
*	<description></description>
**/
using System;

namespace Turno_2___Aula_2
{
    /// <summary>
    /// Purpose: Descreve um aluno
    /// Created by: lufer
    /// Created on: 10/12/2023 4:41:02 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Aluno
    {
        #region Attributes

        private string nome;
        private int numero;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
            nome = "";
            numero = -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeExterno"></param>
        /// <param name="numExterno"></param>
        public Aluno(string nomeExterno, int numExterno)
        {
            nome = nomeExterno;
            numero = numExterno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numExterno"></param>
        /// <param name="nomeExterno"></param>
        public Aluno(int numExterno, string nomeExterno)
        {
            nome = nomeExterno;
            numero = numExterno;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para manipular o Nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        #endregion

        #region Overrides


        public override bool Equals(object obj)
        {
            Aluno a = new Aluno();
            if (obj is Aluno)
                a = obj as Aluno;
                //ou
                //a = (Aluno)obj;

            //return base.Equals(obj);
            if ((a.Nome ==this.Nome) && (a.Numero == this.numero)){
                return true;
            }
            return false;

        }


        public static bool operator ==(Aluno a1, Aluno a2)
        {
            return (a1.Equals(a2));
        }

        public static bool operator !=(Aluno a1, Aluno a2)
        {
            return (!(a1==a2));
        }

        //public override string ToString()
        //{
        //    return string.Format("FICHA: Nome: {0} - Numero: {1}", nome, numero);
        //}
        #endregion

        #region OtherMethods
        public string FichaAluno()
        {
            string texto = "***** Nome: " + nome + "Numero: " + numero;
            return (texto);
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Aluno()
        {
            //última ação antes de libertar a memória
        }
        #endregion

        #endregion
    }
}
