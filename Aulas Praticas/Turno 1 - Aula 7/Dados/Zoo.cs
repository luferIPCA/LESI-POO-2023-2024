/*
*	<copyright file="GereZoo.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 3:33:29 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using ObjetosNegocio;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/23/2023 3:33:29 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Zoo
    {
        #region Attributes
        string nome;
        static List<Animal> animais;       //CUIDADO
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Zoo()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static bool InsereAnimalZoo(Animal a)
        {
            if (animais.Contains(a)) return false;
            animais.Add(a);
            return true;
        }

        public static bool ExisteAnimal(string n)
        {
            return true;
        }

        public static bool GuardaDados(string f)
        {
            try
            {
                Stream s = File.Open(f, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, animais);
                s.Close();
                return true;
            }
            catch
            {
                throw new Exception("Impossivel aceder a ficheiro..");
            }
        }

        public static bool CarregaDados(string f)
        {
            try
            {
                Stream s = File.Open(f, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                animais = (List<Animal>)b.Deserialize(s);
                s.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro...:" + e.Message);
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Zoo()
        {
        }
        #endregion

        #endregion
    }
}
