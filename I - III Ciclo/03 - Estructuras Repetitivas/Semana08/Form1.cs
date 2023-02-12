using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana08
{
    public partial class frmRepetitivas : Form
    {
        public frmRepetitivas()
        {
            InitializeComponent();
        }

        private void frmRepetitivas_Load(object sender, EventArgs e)
        {
            int w = 0;
            int acu = 0;
            for (w = 1;w <=5; w++)
            {
                lista.Items.Add(w);
                acu   =   acu   +    w;
            }
            txtTotal.Text = acu.ToString();

            for (int a = 1; a <= 12; a++)
            {
                lista2.Items.Add(a+" X 5 ="+a*5 );
            }

            int h = 0;
            h = 1;
            while (h <= 5)
            {

                lista3.Items.Add(h +" Sistemas");

                h++;
            }

            int m = 0;
            m = 1;
            do
            {
                lista4.Items.Add(m);
                m++;
            } while (m <= 5);


        }
    }
}
