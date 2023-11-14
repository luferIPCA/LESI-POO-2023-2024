/*
*	<copyright file="Aula_10___Interfaces.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/7/2023 5:01:35 PM</date>
*	<description></description>
**/
using System;

namespace Aula_10___Interfaces
{


    public class Outra
    {
        public static string F(IPessoa x)
        {
            return (x.NomeMaiusculas());
        }
    }


    public interface IMorada
    {
        int Rua();
    }



    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/7/2023 5:01:35 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes

        public int idade;
        string nome;
        //Morada m;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
        }

        #endregion

        #region Properties

        //public int Idade 
        //{ get { return idade; }
        //    set { idade = value;
        //    }
        //}

        string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        //public string NomeMaiusculas()
        //{
        //    return nome.ToUpper();
        //}
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }


    public class OutraPessoa : Pessoa, IPessoa, IMorada, IComparable
    {
        DateTime nasc;
        string nomePessoa;

        public DateTime Nasc
        {
            get { return nasc; }
        }

        public int Idade
        {
            get { return base.idade; }
            set { base.idade = value; }

        }

        public int Rua()
        {
            return 1;
        }
    }


    public class Mulher : IPessoa
    {
        int idadeMulher;
        public int Idade
        {
            get { return 1; }
            set { idadeMulher = value; }
        }

        public string NomeMaiusculas()
        {
            return "ola";
        }
    }
}
