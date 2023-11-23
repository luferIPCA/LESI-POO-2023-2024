/*
*	<copyright file="GereZoo.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 3:33:29 PM</date>
*	<description></description>
**/
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereZoo
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
        public ArrayList animais;       //CUIDADO
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

        public bool GuardaDados(string f)
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

        public bool CarregaDados(string f)
        {
            try
            {
                Stream s = File.Open(f, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                animais = (ArrayList)b.Deserialize(s);
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
