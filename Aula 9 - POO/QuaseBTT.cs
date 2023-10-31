/*
*	<copyright file="Aula_9___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 4:54:09 PM</date>
*	<description></description>
**/

namespace Aula_9___POO
{
    #region CLASSES_ABSTRATAS
    public abstract class QuaseBTT : Transporte
    {
        bool eletrica;

        public bool Eletrica
        {
            get;
            set;
        }

        public abstract string MostraBTT();
    }

    #endregion

    #region CLASSES_CONCRETAS
    /// <summary>
    /// 
    /// </summary>
    public class BTT : QuaseBTT
    {

        public override string MostraBTT()
        {
            return "BTT";
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class Trotinete : QuaseBTT
    {
        public override string MostraBTT()
        {
            return "Trotinete";
        }
    }

    #endregion
}
