/*
*	<copyright file="Aula_13_Exceptions.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>2023</date>
*	<description></description>
**/

using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int x = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                
            }
            catch (Exception e)
            {

            }
        }
    }
}
