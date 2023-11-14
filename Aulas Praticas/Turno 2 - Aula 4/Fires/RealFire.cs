/*
*	<copyright file="Fires.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2023 4:51:29 PM</date>
*	<description></description>
**/
using System;

namespace Fires
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2023 4:51:29 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RealFire : Fire
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public RealFire()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public Incendio HighestFireII(Incendio[] arr)
        {
            Incendio maior = arr[0];
            double maiorAreaQueimada = maior.largura * maior.cumprimento;

            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i].largura * arr[i].cumprimento > maiorAreaQueimada)
                    maior = arr[i];
            }
            return maior;
        }

        public override Incendio HighestFire(Incendio[] arr)
        {
            Incendio maior = arr[0];
            double maiorAreaQueimada;
            bool aux = BurnedArea(maior.largura, maior.cumprimento, out maiorAreaQueimada);

            for (int i = 1; i < arr.Length; i++)
            {
                double novaAreaQueimada;
                aux = BurnedArea(arr[i].largura, arr[i].cumprimento, out novaAreaQueimada);
                if (aux == true)
                {
                    if (novaAreaQueimada > maiorAreaQueimada)
                    {
                        maiorAreaQueimada = novaAreaQueimada;
                        maior = arr[i];
                    }
                }
            }
            return maior;
        }

        public override int HowManyFires(DateTime d, string regiao)
        {
            int cont = 0;
            for(int i=0; i<incendios.Length; i++)
            {
                if (incendios[i].Dia == d && incendios[i].regiao == regiao) cont++;
            }
            return cont;
        }

        

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~RealFire()
        {
        }
        #endregion


        int MaiorValoArray(int[] v)
        {
            int maior = v[0];
            for(int i=1; i<v.Length; i++)
            {
                if (v[i] > maior) maior = v[i];
            }
            return maior;
        }

        #endregion
    }


    public class Nova : RealFire
    {
        public int ComparaIncendios(Incendio i1, Incendio i2)
        {


            //if (1.CompareTo(2))

            //if (String.Compare("ola","ole"))
        }

        //Compare
    }
}
