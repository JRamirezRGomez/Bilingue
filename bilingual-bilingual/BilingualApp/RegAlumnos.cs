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
    public partial class RegAlumnos : Form
    {
        private MySqlConnection coneccion;
        private string server;
        private string database;
        private string uid;
        private string password;

        public RegAlumnos()
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
            Login b = new Login();
            b.Visible = true;
            Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //enviamos parametros a clase registrar
            string numlista = TxtNumero.Text; 
            string nombre = TxtNombre.Text;
            string ap = TxtAP.Text;
            string am = TxtAM.Text;

            if (Registaralu(numlista, nombre, ap, am))
            {
                MessageBox.Show($"Alumno {nombre} ah sido creado");
                RegAlumnos ralu = new RegAlumnos();
                ralu.Visible = true;
                Close();
            }
            else
            {
                MessageBox.Show($"Alumno {nombre} no fue creado");
            }
        }

        public bool Registaralu(string numlista, string nombre, string ap, string am)
        {
            string query = $"insert into alumnos (ID_Alumno, Nombre, Apellido_P, Apellido_M) values ('{numlista}', '{nombre}', '{ap}', '{am}');";
            try
            {
                if (openconn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, coneccion);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
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
            }
            catch (Exception ex)
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home c = new Home();
            c.Visible = true;
            Close();

            //Este boton regresa al Home.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Aceptar.Enabled = true;
            }
            else
            {
                Aceptar.Enabled = false;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Material mat = new Material();
            mat.Visible = true;
            Close();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
