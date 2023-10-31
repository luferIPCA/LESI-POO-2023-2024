/*
*	<copyright file="Aula_9___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 4:54:09 PM</date>
*	<description></description>
**/


using System;

enum ASAS { GRANDES, PEQUENAS}

namespace Aula_9___POO
{
    /// <summary>
    /// 
    /// </summary>
    class Aviao : Transporte
    {
        ASAS temAsas;
        //string marca;

        public ASAS TemAsas
        {
            get;
            set;
        }

        //public new string MostraTransporte()
        //{
        //    return (String.Format("Ano do Avião:{0}", base.Ano));

        //}

        public override string MostraTransporte()
        {
            return (String.Format("Ano do Avião:{0} - Asas: {1}", base.Ano, temAsas.ToString()));
        }
    }
}
