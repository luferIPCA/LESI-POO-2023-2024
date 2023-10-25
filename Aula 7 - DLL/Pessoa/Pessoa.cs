/*
 * Classe para descrever uma Pessoa
 * lufer
 * lufer@ipca.pt
 * 02-10-2023
 * POO-ESI
 * **/

using System;

namespace UmaPessoa
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

        public DateTime DataNascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if ((p1.Nome == p2.Nome) && (p1.Idade == p2.Idade))
                return true;
            return false;
        }

        //><=
        //+
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            //if (!((p1.Nome == p2.Nome) && (p1.idade == p2.idade)))
            if (p1==p2)
                return false;
            return true;
            //ou
            //return (!(p1 == p2));
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return base.ToString();

            //return "Nome: " + nome + " Idade: " + idade;
            return String.Format("Nome: {0} - Idade: {1}", nome, idade.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}
