using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proyecto_de_Bodega
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {   // Cargamos una carpeta con imagenes al picture box
            // Creamos un condicional y segun la opcion que se escoge, se cargara la imagen
            if(cbProducto.SelectedIndex == 0)
            {
                fotoProducto.Image = Properties.Resources.leche;  // Cargando de fotos 
                txtNombre.Text = "Leche Gloria";
                txtVenta.Text = "3.90";
                txtCodigo.Text = "59521001";
                
            }
            else if(cbProducto.SelectedIndex == 1)
            {
                fotoProducto.Image = Properties.Resources.queso;
                txtNombre.Text = "Queso Fresco";
                txtVenta.Text = "11.95";
                txtCodigo.Text = "718302";

            }
            else if (cbProducto.SelectedIndex == 2)
            {
                fotoProducto.Image = Properties.Resources.mantequilla;
                txtNombre.Text = "Mantequilla";
                txtVenta.Text = "6.20";
                txtCodigo.Text = "65884141";
            }
            else if (cbProducto.SelectedIndex == 3)
            {
                fotoProducto.Image = Properties.Resources.bombom;
                txtNombre.Text = "Caja de Bombones";
                txtVenta.Text = "35.90";
                txtCodigo.Text = "68522471";
            }
            else if (cbProducto.SelectedIndex == 4)
            {
                fotoProducto.Image = Properties.Resources.alfajores;
                txtNombre.Text = "Alfajores\t";
                txtVenta.Text = "4.50";
                txtCodigo.Text = "48725145";
            }
            else if (cbProducto.SelectedIndex == 5)
            {
                fotoProducto.Image = Properties.Resources.chicle_trident;
                txtNombre.Text = "Chicle Tridents";
                txtVenta.Text = "1.50";
                txtCodigo.Text = "95478232";
            }
            else if (cbProducto.SelectedIndex == 6)
            {
                fotoProducto.Image = Properties.Resources.Filete_atun;
                txtNombre.Text = "Lata de Atun";
                txtVenta.Text = "4.80";
                txtCodigo.Text = "84214451";
            }
            else if (cbProducto.SelectedIndex == 7)
            {
                fotoProducto.Image = Properties.Resources.durazno;
                txtNombre.Text = "Lata de Duraznos";
                txtVenta.Text = "9.50";
                txtCodigo.Text = "48752552";
            }
            else if (cbProducto.SelectedIndex == 8)
            {
                fotoProducto.Image = Properties.Resources.sopainstantanea;
                txtNombre.Text = "Sopa Instantanea";
                txtVenta.Text = "3.40";
                txtCodigo.Text = "65844741";
            }
            else if (cbProducto.SelectedIndex == 9)
            {
                fotoProducto.Image = Properties.Resources.tecanelayclave;
                txtNombre.Text = "Té, Canela y Clavo";
                txtVenta.Text = "3.50";
                txtCodigo.Text = "48722541";
            }
            else if (cbProducto.SelectedIndex == 10)
            {
                fotoProducto.Image = Properties.Resources.cebadainstantanea;
                txtNombre.Text = "Cebada Instantanea";
                txtVenta.Text = "13.90";
                txtCodigo.Text = "62541447";
            }
            else if (cbProducto.SelectedIndex == 11)
            {
                fotoProducto.Image = Properties.Resources.cafe;
                txtNombre.Text = "Lata de Cafe";
                txtVenta.Text = "49.90";
                txtCodigo.Text = "45682558";
            }
            else if (cbProducto.SelectedIndex == 12)
            {
                fotoProducto.Image = Properties.Resources.arroz;
                txtNombre.Text = "Bolsa de Arroz";
                txtVenta.Text = "4.20";
                txtCodigo.Text = "84114652";
            }
            else if (cbProducto.SelectedIndex == 13)
            {
                fotoProducto.Image = Properties.Resources.garbanzo;
                txtNombre.Text = "Bolsa de Garbanzo";
                txtVenta.Text = "4.50";
                txtCodigo.Text = "52114612";
            }
            else if (cbProducto.SelectedIndex == 14)
            {
                fotoProducto.Image = Properties.Resources.lentejas;
                txtNombre.Text = "Bolsa de Lentejas";
                txtVenta.Text = "5.20";
                txtCodigo.Text = "52487521";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtVenta_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(txtUnidades.Text);  
            double n2 = double.Parse(txtVenta.Text);  // Convertir String a double
            double result = n1 * n2;                   // Multiplicar valores unidades*precio
            txtTotal.Text = result.ToString();          // Almacenamos el resultado en un string y devolvemos los valores a la caja de texto

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            foreach(Control c in panel1.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtNombre.Text+"\t\tS/"+txtTotal.Text); // Agregamos los productos escogidos del menu a la list box
            
        }

        private void btnBorrarlista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void txtTotales_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculoTotal_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados de forma correcta","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
