using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilingualApp
{
    public partial class RegAlumnos : Form
    {
        public RegAlumnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void Num_Click(object sender, EventArgs e)
        {

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Salon b = new Salon();
            b.Visible = true;
            Close();

            //Regresa a Salon
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home c = new Home();
            c.Visible = true;
            Close();

            //Este boton regresa al Home
        }
    }
}
