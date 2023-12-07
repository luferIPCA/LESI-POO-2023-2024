/*
*	<copyright file="IndicadoresHistory.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/15/2020 8:26:19 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MVC_II.Model
{

    public interface IIndicadoresHistory
    {
        bool AddIndicador(IIndicadoresModel i);
        bool SaveHistory(string fileName);
        bool LoadHistory(string fileName);

    }

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/15/2020 8:26:19 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    [Serializable]
    public class IndicadoresHistory : IIndicadoresHistory
    {
        List<IIndicadoresModel> hist;

        public IndicadoresHistory()
        {
            hist = new List<IIndicadoresModel>();
        }

        public bool AddIndicador(IIndicadoresModel i)
        {
            if (hist != null)
                if (!hist.Contains(i))
                {
                    hist.Add(i);
                    return true;
                }
            return false;
        }


        /// <summary>
        /// Preservar
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveHistory(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, hist);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }


        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool LoadHistory(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    hist = (List<IIndicadoresModel>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }
    }
}
