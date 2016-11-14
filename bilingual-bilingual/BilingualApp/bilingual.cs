using System;
using System.IO;
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
    public partial class Bilingual : Form
    {
  

        public Bilingual()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Registrar reg = new Registrar();
            reg.Visible = true;
            Hide();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Close();
        }

        private void Bilingual_Load(object sender, EventArgs e)
        {

        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConexionBD.Conexion();
            MessageBox.Show("conectado a la base de datos");
        }

        private void button2_Click(object sender, EventArgs e)
        {


           
          
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Close();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {

            Registrar reg = new Registrar();
            reg.Visible = true;
            Close();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            ConexionBD.Conexion();

        }
    }
}

 /* --ENVIAR REGISTRO--
            Salon mat = new Salon();
            mat.Visible = true;
            Close();
            */


 /*  --REGISTRARSE---
  try
            {
                var sw = new StreamWriter("C:\\ " + textnom.Text + "\\regist.ID");
                sw.Write(textnom.Text + "\n\n" + textpass.Text);
                sw.Close();
                 
            }
            catch (DirectoryNotFoundException ex)
            {
                Directory.CreateDirectory("C:\\ " + textnom.Text);
                var sw = new StreamWriter("C:\\ " + textnom.Text + "\\regist.ID");
                sw.Write(textnom.Text + "\n\n" + textpass.Text);
                sw.Close();
            }*/



  /* --INICIAR SESION---
   * 
    try
            {
                var sr = new StreamReader("C:\\ " + textnom.Text + "\\regist.ID");
                user = sr.ReadLine();
                pass = sr.ReadLine();
                sr.Close();

                if (user == textnom.Text && pass == textpass.Text)
                    MessageBox.Show("haz iniciado sesion", "Iniciado");
                else
                    MessageBox.Show("Nombre o Contraseña es incorrecta", "ERROR");
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show("El usuario no existe", "ERROR");
            }
            */