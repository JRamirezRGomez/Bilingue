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
using System.Text.RegularExpressions;

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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ConexionBD.Conexion();


            //boton registrar
            // validar correo

            string Correo = TxtCorreo.Text;
            Regex emailregex = new Regex("(?<user>[^@]+)@(?<host>.+)");
            Match m = emailregex.Match(Correo);
           
            if (textBox2.Text == textBox3.Text)
            {
                MessageBox.Show("Registro correcto");
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden");
            }
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Debes de llenar todos los campos");
            }
        }
    }
}
