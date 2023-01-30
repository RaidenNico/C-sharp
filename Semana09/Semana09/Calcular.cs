using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana09
{
    public class Calcular
    {
        private double _largo; 
        private double _ancho; 
        private double _area;

        public Calcular(double largo, double ancho, double area)
        {
            _largo = largo;
            _ancho = ancho;
            _area = area;
        }

        public double Largo { get => _largo; set => _largo = value; }
        public double Ancho { get => _ancho; set => _ancho = value; }

        
        /*
       public double Largo
        {
            get { return _largo; }
            set
                {
                    if (value <= 0)
                    _largo = 1;  
                    else
                    _largo = value;
                }
        }

        public double Ancho
        {
            get{return _ancho;}
            set
            {
                if (value <= 0)
                    _ancho = 1;
                else
                    _ancho = value;
            }
        }
        */
        public double Area
        {
            get
            {
                return _largo * _ancho;
            }
            set
            {
                if (value <= 0)
                    _area = 1;
                else
                    _area = value;
            }
        }

        public double Suma
        {
            get
            {
                return _largo + _ancho;
            }
        }


        public static void limpiar(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }



    }
}
