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
using System.Text.RegularExpressions;


namespace BilingualApp
{
    public partial class Login : Form
    {
        private MySqlConnection coneccion;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()

        {
            InitializeComponent();
            server = "localhost";
            database = "bilingual";
            uid = "root";
            password="";
            string con;
            con = $"SERVER ={server};DATABASE={database};UID={uid};PASSWORD={password};";
            coneccion = new MySqlConnection(con); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            string correo = TxtCorreo.Text;
            string pass = TxtContrasena.Text;

            if(login (correo,pass))
            {
                Bilingual ralu = new Bilingual();
                ralu.Visible = true;
                Close();
            }
            else
            {
                MessageBox.Show("Usuario no existe!!");
            }
        }

        private bool openconn()
        {
            try
            {
                coneccion.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch(ex.Number)
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

        private bool login(string TxtCorreo, string TxtContrasena)
        {
            //hacemos comparacion 
            string Query = $"select * from docentes where Correo_Eletronico= '{this.TxtCorreo.Text}' and Contrasena= '{this.TxtContrasena.Text}';";
            try
            {
                if(openconn())
                {
                    MySqlCommand Conexion = new MySqlCommand(Query, coneccion);
                    MySqlDataReader LeerDatos;
                    LeerDatos = Conexion.ExecuteReader();
                    if (LeerDatos.Read())
                    {
                        LeerDatos.Close();
                        coneccion.Close();
                        return true;
                    }
                    else
                    {
                        LeerDatos.Close();
                        coneccion.Close();
                        return false;
                    }
                }
                else
                {
                    coneccion.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
