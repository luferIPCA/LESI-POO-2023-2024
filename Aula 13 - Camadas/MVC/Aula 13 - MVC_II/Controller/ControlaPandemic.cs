/*
*	<copyright file="ControlaPandemic.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/15/2020 12:19:25 PM</date>
*	<description></description>
**/
using MVC_II.Model;
using MVC_II.View;

namespace MVC_II.Controller
{

    public interface IIndicadoresControl
    {
        
        //controlar Model
        void SetModel(IIndicadoresModel m);
        void MoreDeads(int v);
        void MoreInfected(int v);
        void MoreRecovered(int v);
        //void tLessInfected(int v);

        int Mortes();
        int Recuperados();
        int Infetados();

        //controlar View
        void SetView(IIndicadoresView v);
        void RequestMoreDeads(int v);
        void RequestMoreInfected(int v);
        //void RequestMoreRecovered(int v);
        //void RequestLessInfected(int v);

    }
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/15/2020 12:19:25 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ControlaPandemic : IIndicadoresControl
    {
        private IIndicadoresModel ind;      //Model
        private IIndicadoresView indView;   //View
        

        //construtor
        #region Construtors
        public ControlaPandemic(IIndicadoresModel m, IIndicadoresView v)
        {
            ind = m;
            indView = v;
        }

        public ControlaPandemic()
        {
            ind = new Indicadores();    //Model
            indView = new IndicadoresView(this); //liga C <=> V

            indView.QuantasMortes();
  
            indView.QuantosInfetados();
            indView.QuantosRecuperados();

            //int tot = indView.QuantasMortesII();
            //ind.Mortes += tot;
            indView.ShowAll();
            
        }

        #endregion

        #region Control_Model

        #region Indicadores
        public void SetModel(IIndicadoresModel m)
        {
            this.ind = m;
        }
        public void MoreDeads(int v)
        {
            if (ind != null)
            {
                ind.Mortes += v;
            }
        }

        public void MoreInfected(int v)
        {
            if (ind != null)
            {
                ind.Infetados += v;
            }
        }
        public void MoreRecovered(int v)
        {
            if (ind != null)
            {
                ind.Recuperados += v;
            }
        }

        public int Mortes()
        {
            return ind.Mortes;
        }

        public int Infetados()
        {
            return ind.Infetados;
        }

        public int Recuperados()
        {
            return ind.Recuperados;
        }
        #endregion

        #endregion

        #region Control_View

        public void SetView(IIndicadoresView v)
        {
            this.indView = v;
        }
        public void RequestMoreDeads(int v)
        {
            if (indView != null)
            {
                indView.QuantasMortes();
            }
        }

        public void RequestMoreInfected(int v)
        {
            if (indView != null)
            {
                indView.QuantosInfetados();
            }
        }

        public void RequestMoreRecovered(int v)
        {
            if (indView != null)
            {
                indView.QuantosRecuperados();
            }
        }
        #endregion

    }
}
