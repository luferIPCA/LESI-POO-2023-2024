/*
*	<copyright file="Fires.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2023 4:47:36 PM</date>
*	<description></description>
**/
using System;

namespace Fires
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2023 4:47:36 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class Fire
    {
        #region Attributes

        public Incendio[] incendios;        //ATENÇÃO

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Fire()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Método que devolve o maior incêndio que ocorreu em todo o país
        /// </summary>
        public abstract Incendio HighestFire(Incendio[] arr);


        /// <summary>
        /// Método que calcula a área ardida num determinado incêndio.
        /// A conversão tem de ser, contudo, controlada. Se a conversão ocorre com sucesso devolve "true" e o valor da área calculada. Se a conversão não pode ser feita, deverá gerar a exceção “InvalidAreaParametersException”.
        /// </summary>
        public bool BurnedArea(double width, double height, out double area)
        {
            area = 0;
            if (width < 0 || height < 0) return false;
            double aux = width * height;
            area = aux;
            return true;
        }

        /// <summary>
        /// Método que indica quantos incêndios ocorreram numa determinada data, numa determinada região
        /// </summary>
        public abstract int HowManyFires(DateTime d, string regiao);

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Fire()
        {
        }
        #endregion

        #endregion
    }
}
