using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncargoBodega
{
    public partial class frmAgProducto : Form
    {
        public frmAgProducto()
        {
            InitializeComponent();
        }

        private void enviar(KeyPressEventArgs tecla, Control Foco)
        {
            if (tecla.KeyChar == 13)
            {
                Foco.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Desea salir?", "Mensaje de aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Cambio hecho por Cesar: Quité el bucle foreach para borrar el texto del combobox
            //Agregué el seleccionar el index -1 para que apareciera vacío el combobox
            foreach(Control a in this.Controls)
            {
                if(a is TextBox)
                {
                    a.Text = "";
                }
            }
            cbCategoria.SelectedIndex = -1;//No se encuentra seleccionado ningún ítem de la lista
            Imagen.ImageLocation = "";
            txtCodigo.Focus();
            numCantidad.ResetText(); //Recien agregado.
        }

        //Agregar producto y comprobar que todos los datos esten completos.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //Cambio hecho por César: Quité el segundo bucle foreach y lo uní en uno solo
            //Lo que ocurre en es que si encuentra un textbox o un combobox vacío, se suma uno al contador
            if (txtCodigo.Text != "" && txtDescripcion.Text != "" && numCantidad.Value != 0 && cbCategoria.SelectedIndex != -1 && txtProveedor.Text != "")
            {
                DialogResult men = MessageBox.Show("¿Agregar Producto?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (men == DialogResult.Yes)
                {
                    MessageBox.Show("Producto Agregado");
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                Imagen.ImageLocation = abririmagen.FileName;
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtDescripcion);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, numCantidad);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, cbCategoria);
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtProveedor);
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnGuardar);
        }

        private void frmAgProducto_Load(object sender, EventArgs e)
        {
            //Cambio hecho por César: Esto permite que el combobox no pueda ser alterado por el usuario, 
            //es decir, que solamente permita desplegar la lista, más no escribir en ella
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
