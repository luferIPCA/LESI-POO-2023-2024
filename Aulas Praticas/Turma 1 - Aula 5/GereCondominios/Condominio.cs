/*
*	<copyright file="GereCondominios.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/16/2023 2:39:33 PM</date>
*	<description></description>
**/
using System;
using Interfaces;
using InterfaceDLL;

namespace GereCondominios
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/16/2023 2:39:33 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Condominio : ICondominio, IComparable
    {
        #region Attributes
        string contacto;
        int ano;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Condominio()
        {
        }

        #endregion

        #region Properties
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Contacto
        {
            get { return contacto.ToLower(); }
            set { contacto = value; }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 0
        /// 1
        /// -1
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object? obj)
        {
            if (obj == null)
                throw new Exception("Valor Nulo");
            if (obj.GetType() != typeof(Condominio))
                throw new Exception("Tipos inválido");
            Condominio aux = (Condominio)obj;

            if (this.Ano < aux.Ano) return -1;
            if (this.Ano == aux.Ano) return 0;
            return 1;

        }


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Condominio()
        {
        }
        #endregion

        #endregion
    }
}
