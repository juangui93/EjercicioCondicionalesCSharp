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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxEdad_Click(object sender, EventArgs e)
        {
            Edad edad = new Edad();
            edad.Show();
            this.Hide();
        }

        private void pbxNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
            this.Hide();
        }

        private void pbxDescuentos_Click(object sender, EventArgs e)
        {
            Descuentos descuentos = new Descuentos();
            descuentos.Show();
            this.Hide();
        }
    }
}
