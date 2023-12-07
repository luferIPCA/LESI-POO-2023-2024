/*
*	<copyright file="Incendios.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2023 3:21:23 PM</date>
*	<description></description>
**/
using System;

namespace Incendios
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2023 3:21:23 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public  class FireReal : Fire
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public FireReal()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public override Incendio HighestFire(Incendio[] arr)
        {
            double areaMaior;
            Incendio maior = arr[0];
            BurnedArea(maior.Largura, maior.Cumprimento, out areaMaior);

            for (int i = 1; i<arr.Length; i++)
            {
                double areaNova;
                bool aux = BurnedArea(arr[i].Largura, arr[i].Cumprimento, out areaNova);
                if (aux == true)
                {
                    if (areaNova > areaMaior)
                    {
                        maior = arr[i];
                    }
                }
            }
            return maior;
        }

        /// <summary>
        /// Método que indica quantos incêndios ocorreram numa determinada data, 
        /// numa determinada região
        /// </summary>
        public override int HowManyFires(DateTime d, string regiao)
        {
            int cont = 0;
            for(int i=0; i<incendios.Length; i++)
            {
                if (incendios[i].Data == d && incendios[i].regiao == regiao) cont++;
            }
            return cont;         
        }
        #endregion


        public bool AddIncendio(Incendio i)
        {
            foreach (Incendio ic in incendios)
            {
                if (ic.Data == i.Data) return false;
            }
            if (totIncendios < N)
            {
                incendios[totIncendios++] = i;
                return true;
            }
            return false;
        }

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~FireReal()
        {
        }
        #endregion


        public int MaiorArray(int[] valores)
        {
            int maior = valores[0];

            for(int i=1; i<valores.Length; i++)
            {
                if (valores[i] > maior) maior = valores[i];

            }
            return maior;
        }

        #endregion
    }
}
