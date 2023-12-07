/*
*	<copyright file="Incendios.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2023 2:42:44 PM</date>
*	<description></description>
**/
using System;

namespace Incendios
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2023 2:42:44 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class Fire
    {
        #region Attributes

        public Incendio[] incendios;            //ATENÇÃO
        public const int N = 20;
        public int totIncendios;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Fire()
        {
            incendios = new Incendio[N];
            for(int i=0; i<N; i++)
            {
                incendios[i] = new Incendio(0, 0, DateTime.Now);
            }
            totIncendios = 0;
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
        /// Método que indica quantos incêndios ocorreram numa determinada data, numa determinada região
        /// </summary>
        public abstract int HowManyFires(DateTime d, string regiao);

        /// <summary>
        /// Método que calcula a área ardida num determinado incêndio.
        /// A conversão tem de ser, contudo, controlada. Se a conversão ocorre com sucesso devolve "true" e o valor da área calculada. Se a conversão não pode ser feita, deverá gerar a exceção “InvalidAreaParametersException”.
        /// </summary>
        public bool BurnedArea(double width, double height, out double area)
        {
            area = 0;
            if (width < 0 || height < 0) 
                return false;
            area = width * height;
            return true;
        }
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
