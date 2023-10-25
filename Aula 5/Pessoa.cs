/*
 * Classe para descrever uma Pessoa
 * lufer
 * lufer@ipca.pt
 * 02-10-2023
 * POO-ESI
 * **/

using System;

namespace Aula_5
{
    /// <summary>
    /// Classe Pessoa....
    /// </summary>
    public class Pessoa
    {
        #region ESTADO 

        private string nome;
        private int idade;
        private DateTime nascimento;    //TPC

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Pessoa()
        {
            idade = 0;
            nome = "";
        
        }

        public Pessoa(int idade, string nome)
        {
            this.idade=idade;
            this.nome = nome;
        }

        //public Pessoa(int id, string no)
        //{
        //    idade = id;
        //    nome = no;
        //}
        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// 
        /// </summary>
        public int Idade
        {
            set
            {
                //if (value<0)
                idade = value;
            }
            get
            {
                //if(pode_saber_a_minha_idade)
                    return idade;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }

        #endregion

        #endregion
    }
}
