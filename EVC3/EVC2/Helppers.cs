using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVC2
{
    public class Helppers
    {

        public static void Clean(Form fmr)
        {

            foreach (Control c in fmr.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        public static void keyPress(KeyPressEventArgs e, TextBox txt)
        {
            if (e.KeyChar == 13)
            {
                txt.Focus();
            }
        }
    }
}