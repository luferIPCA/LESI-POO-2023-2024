/*
*	<copyright file="Gorjeta.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/15/2020 11:26:32 AM</date>
*	<description>Model</description>
**/

using System.Collections.Generic;

namespace MVCSample
{
    /// <summary>
    /// Model
    /// </summary>
    class Gorjeta
    { 
        /// This class does a very simple tip 
        /// calculation. It has two fields amount and
        /// tip percent. We are ignoring tax and whether
        /// we tip before or after tax. The point is the
        /// MVC model. This is the model part of MVC.
        /// It does the calculations and handles the data
        /// it is totally unaware of the Display class
        /// or the controller
        /// 
        //private fields
        private double amount;
        private double tipPercent;

        /// <summary>
        /// default constructor
        /// </summary>
        public Gorjeta()
        {
            Amount = 0;
            TipPercent = 0;
        }

        //overloaded constructor
        public Gorjeta(double amt, double percent)
        {
            Amount = amt;
            TipPercent = percent;
        }

        //public properties
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double TipPercent
        {
            get { return tipPercent; }
            set
            {
                //here we check to see if 
                //they entered the percent
                //as a decimal or a whole number
                //if it is a whole number
                //larger than 1 we divide it by
                //100, so the highest possible tip
                //is 100%
                if (value > 1)
                {
                    value /= 100;
                }
                tipPercent = value;
            }
        }

        public double CalculateTip()
        {
            //very simplistic tip calculation
            return Amount * TipPercent;
        }

        public double CalculateTotal()
        {
            //simple total calculation
            return CalculateTip() + Amount;
        }

    }

    class Gorjetas
    {
        List<Gorjeta> cofre;

    }
}
