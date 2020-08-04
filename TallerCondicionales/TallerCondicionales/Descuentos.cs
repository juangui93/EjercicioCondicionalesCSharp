using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerCondicionales
{
    public partial class Descuentos : Form
    {
        public Descuentos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbxMenu.Text = String.Empty;
            txtValor.Text = String.Empty;
            lblPago.Text = "0";


        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String temporada;
            double valor, descuento = 0, total = 0;

            temporada = cbxMenu.Text;

            valor = double.Parse(txtValor.Text);

            if (temporada == "Escolar")
            {
                if (valor < 100000)
                {
                    descuento = 0;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else if (valor >= 100001 || valor <= 300000)
                {
                    descuento = valor * 0.1;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else if (valor > 300000)
                {
                    descuento = valor * 0.15;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else
                {
                    MessageBox.Show("Valor no permitido",
                        "Mensaje del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (temporada == "Halloween")
            {
                if (valor >= 50 || valor == 30000)
                {
                    descuento = 0;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else if (valor >= 30001 || valor == 200000)
                {
                    descuento = valor * 0.02;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else if (valor > 200000)
                {
                    descuento = valor * 0.05;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else
                {
                    MessageBox.Show("Valor no permitido",
                     "Mensaje del Sistema",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            else if (temporada == "Diciembre")
            {
                if (valor >= 50 || valor == 30000)
                {
                    descuento = 0;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else if (valor >= 30001 || valor == 500000)
                {
                    descuento = valor * 0.05;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else if (valor > 500000)
                {
                    descuento = valor * 0.1;
                    total = valor - descuento;
                    lblPago.Text = Convert.ToString(total);
                }
                else
                {
                    MessageBox.Show("Valor no permitido",
                     "Mensaje del Sistema",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
        }     
    }
}
