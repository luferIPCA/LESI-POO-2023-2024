/*
*	<copyright file="GereZoo.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/23/2023 3:03:12 PM</date>
*	<description>
*	Implementar operações sobre ficheiro binário
*	</description>
**/
using System;
using System.Collections;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereZoo
{
 

    #region OtherMethods

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/23/2023 3:03:12 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GereFicheiro
    {
        public static bool GuardaDados(string f, ArrayList dados)
        {
            try
            {
                Stream s = File.Open(f, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, dados);
                s.Close();
                return true;
            }
            catch
            {
                throw new Exception("Impossivel aceder a ficheiro..");
            }
        }


        public static ArrayList CarregaDados(string f)
        {
            ArrayList dados;
            try
            {
                Stream s = File.Open(f, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                dados = (ArrayList)b.Deserialize(s);
                s.Close();
                return dados;
            }
            catch (Exception e)
            { 
                throw new Exception("Erro...:"+e.Message);
            }
        }
        #endregion


 
    }
}
