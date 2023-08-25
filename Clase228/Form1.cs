using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase228
{
    public partial class Form1 : Form
    {
        private int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void btLongitud_Click(object sender, EventArgs e)
        {
            int CantCaracteres = 0;
            CantCaracteres = txtFrase.Text.Length;

            lblResultado.Text = CantCaracteres.ToString();
        }

        private void btPrueba_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "La Cantidad de Caracteres de Pepe es ".Length.ToString();
        }

        private void BtMayuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtFrase.Text.ToUpper();
        }

        private void btMinuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtFrase.Text.ToLower();

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscado.Text.Contains(txtBuscado.Text))
            {
                lblResultado.Text = "SI";
            }
            else
            {
                lblResultado.Text = "NO";
            }
                }

        private void txtDeletrear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txtFrase.Text.Length; i++) ;
            {
                lblResultado.Text += txtFrase.Text.Substring(i,1) + "\r\n";
            }
        }

        private void btExtraer_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtFrase.Text.Replace(txtBuscado.Text, " ");

        }
    }
    }

