﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana0801
{
    public partial class frmFactura : Form
    {
        private int cantidadProductos=0;
        private double[] subTotales = new double[5];
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(txtPrecio.Text); 
            double cantidad = Convert.ToDouble(txtCantidad.Text); 
            double subtotal = precio * cantidad;
            double baseImponible = 0; 
            double montoIgv = 0; 
            double montoTotal = 0;
            cantidadProductos++;
            if (cantidadProductos < 6)
            {
                lsbProducto.Items.Add(txtProducto.Text);
                lsbPrecio.Items.Add(txtPrecio.Text);
                lsbCantidad.Items.Add(txtCantidad.Text);
                lsbSubtotal.Items.Add(subtotal.ToString());
                subTotales[cantidadProductos - 1] = subtotal;

                for (int i = 0; i < cantidadProductos; i++)
                {
                    baseImponible = baseImponible + subTotales[i];
                }

                txtBaseImponible.Text = baseImponible.ToString();
                montoIgv = baseImponible * 18 / 100;
                txtIgv.Text = montoIgv.ToString();
                montoTotal = baseImponible + montoIgv;
                txtTotal.Text = montoTotal.ToString();


                txtProducto.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtProducto.Focus();
            }
            else 
            {
                MessageBox.Show("Son 10 productos como máximo.", "Lleno");

            }







        }
    }
}
