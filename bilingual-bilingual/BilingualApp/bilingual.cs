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
    public partial class Bilingual : Form
    {
        public Bilingual()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            RegAlumnos ralu = new RegAlumnos();
            ralu.Visible = true;
            Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Visible = true;
            Close();
        }

        private void BtnPreguntas_Click(object sender, EventArgs e)
        {
            Material mat = new Material();
            mat.Visible = true;
            Close();
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos alu = new Alumnos();
            alu.Visible = true;
            Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
