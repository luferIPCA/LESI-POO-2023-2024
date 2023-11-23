/*
*	<copyright file="GereCondominios.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/16/2023 3:14:40 PM</date>
*	<description></description>
**/
using System.Collections;
using System.Collections.Generic;
using Interfaces;

namespace GereCondominios
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/16/2023 3:14:40 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Condominios : ICondominios
    {
        #region Attributes
        const int TOTALCOND = 100;
        //Condominio[] cond;
        //ArrayList cond;
        List<ICondominio> cond;
        int totCondominios;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Condominios()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public bool InsereCondominio(ICondominio c)
        {
            if ((totCondominios < TOTALCOND) && !ExisteCondominio(c.Contacto)) // && ainda não existe
            {
                //if(!cond.Contains(c))
                //    cond.Add(c);
                cond[totCondominios++] = (Condominio)c;
                return true;
            }
            return false;
        }

        public bool ExisteCondominio(string contacto)
        {
            //LINQ

            foreach(Condominio c in cond)
            {
                if (c.Contacto == contacto) return true;
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Condominios()
        {
        }
        #endregion

        #endregion
    }
}
