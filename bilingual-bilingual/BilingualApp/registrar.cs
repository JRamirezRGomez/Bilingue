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
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace BilingualApp
{
    public partial class Registrar : Form
    {
        private MySqlConnection coneccion;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Registrar()
        {
            InitializeComponent();
            server = "localhost";
            database = "bilingual";
            uid = "root";
            password = "";
            string con;
            con = $"SERVER ={server};DATABASE={database};UID={uid};PASSWORD={password};";
            coneccion = new MySqlConnection(con);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login bi = new Login();
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
            //enviamos parametros a clase registrar 
            string nombre = TxtNombre.Text;
            string ap = TxtAP.Text;
            string am = TxtAM.Text;
            string pass = TxtContrasena.Text;
            string correo = TxtCorreo.Text;

            if(Registar(nombre, ap, am, pass, correo))
            {
                MessageBox.Show($"Usuario {nombre} ah sido creado");
                Login b = new Login();
                b.Visible = true;
                Close();
            }
            else
            {
                MessageBox.Show($"Usuario {nombre} no fue creado");
            }
        }
        
        public bool Registar(string nombre, string ap, string am, string pass, string correo )
        {
            string query = $"insert into bilingual.docentes (ID_Docentes, Nombre, Apellido_P, Apellido_M, Contrasena, Correo_Eletronico) values ('', '{nombre}', '{ap}', '{am}', '{pass}', '{correo}');";
            try
            {
                if(openconn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, coneccion);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return false;
                    }
                }
                else
                {
                    coneccion.Close();
                    return false;
                }
            }catch(Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool openconn()
        {
            try
            {
                coneccion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Coneccion a servidor fallo");
                        break;
                    case 1045:
                        MessageBox.Show("Correo Electronico o Contraseña incorrecta");
                        break;
                }
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void TxtCContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

