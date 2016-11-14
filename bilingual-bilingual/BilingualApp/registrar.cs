using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BilingualApp
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilingual bi = new Bilingual();
            bi.Visible = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ajsdka
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void registrar_Load(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home c = new Home();
            c.Visible = true;
            Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
