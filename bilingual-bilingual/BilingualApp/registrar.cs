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



            //Se establece la conexion con el metodo de ConexionBD

            string Conectar = ("server=localhost; database=bilingual; Uid=root; pwd=");
            /*Llamaremos una nueva variable
            para que despues va a ser nuestra conexion*/
            MySqlConnection ConexionRegistrar = new MySqlConnection(Conectar);

            try
            {
                //abrimos on
                MessageBox.Show("Connecting to MySQL...");
                ConexionRegistrar.Open();

                //Se insertan los valores dentro de la tabla docentes
                string Query = "insert into bilingual.docentes (Nombre,Appelido_P,Apellido_M,Contrasena,Correo_Electronico) values('" + this.TxtNombre.Text + "','" + this.TxtAP.Text + "','" + this.TxtAM.Text + "','" + this.TxtContrasena.Text + "','" + this.TxtCorreo.Text + "');";
                //Se conectan con la clase donde se hace la conexion,
                MySqlCommand Conexion = new MySqlCommand(Query, ConexionRegistrar);
                MySqlDataReader LeerDatos;
                LeerDatos = Conexion.ExecuteReader();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //ceramos coneccion 
            ConexionRegistrar.Close();

           }
        }
    }

