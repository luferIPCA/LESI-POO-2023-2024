/*
*	<copyright file="Excepcoes.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/28/2023 4:38:06 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Collections;

namespace Excepcoes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/28/2023 4:38:06 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoas
    {
        #region Attributes

        static List<Pessoa> pessoas;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static  Pessoas()
        {
            pessoas = new List<Pessoa>();
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool InserePessoa(Pessoa p)
        {
            if ((p.numero < 0 || p.numero > 100))       //REVER
                throw new PessoasException("CUIDADO");
            if (pessoas.Contains(p)) return false;
            pessoas.Add(p);
            return true;
        }
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


    public class Pessoa //: IComparable<Pessoa>, IComparer
    {

        public int numero;          //CUIDADO

        //public int CompareTo(Object p)
        //{
        //    if(p is Pessoa)
        //    {
        //        Pessoa aux = p as Pessoa;
        //        if (this.numero == aux.numero) return 0;
        //    }

        //}

        //public int CompareTo(Pessoa p)
        //{
           
        //        if (this.numero == p.numero) return 0;
            

        //}

    }
class X
{
    int[] valores;
}

    class X<K>
    {
        K[] valores;
    }

    class X<K,T>
    {
        T x;
        K valores;
    }

}

