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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5, promedio = 0;

            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);
            nota4 = double.Parse(txtNota4.Text);
            nota5 = double.Parse(txtNota5.Text);

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            if (promedio >= 0 && promedio <= 1){

                label7.Visible = true;
                lblPromedio.Visible = true; 
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Reprueba materia sin lograr realizar " +
                    "proceso de recuperación", "Mensaje del Sistema",
                    MessageBoxButtons.OK ,
                    MessageBoxIcon.Information);
            }else if (promedio >= 1.1 && promedio <= 2.9)
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Reprueba materia y puede hacer la habilitación", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else if (promedio >= 3 && promedio <= 3.9)
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Aprueba la materia con Plan de mejora", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else if (promedio >= 4 && promedio <= 4.5) {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Buen rendimiento", "Mensaje del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }else if (promedio >= 4.6 && promedio <=4.9){
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Excelente", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Graduado con honores","Mensaje del Sistema",
                    MessageBoxButtons.OK ,
                    MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            txtNota4.Text = String.Empty;
            txtNota5.Text = String.Empty;
            label7.Visible = false;
            lblPromedio.Text = "0";
            lblPromedio.Visible = false;
            txtNota1.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
