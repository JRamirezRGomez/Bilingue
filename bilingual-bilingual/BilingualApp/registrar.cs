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


            try

            {
                //Se establece la conexion con el metodo de ConexionBD

                string Conectar = ("server=localhost; database=Bilingual; Uid=root; pwd=");

                //Se insertan los valores dentro de la tabla docentes
                string Query = "INSERT INTO docentes (Nombre,Appelido_P,Apellido_M,Contrasena,Correo_Electronico) values('" + this.TxtNombre.Text + "','" + this.TxtAP.Text + "','" + this.TxtAM.Text + "','" + this.TxtContrasena.Text + "','" + this.TxtCorreo.Text + "');";

                /*Llamaremos una nueva variable
                   para que despues va a ser nuestra conexion
                   */

                MySqlConnection ConexionRegistrar = new MySqlConnection(Conectar);

                //Se conectan con la clase donde se hace la conexion,
                MySqlCommand Conexion = new MySqlCommand(Query, ConexionRegistrar);


                MySqlDataReader LeerDatos;


                ConexionRegistrar.Open();


                LeerDatos = Conexion.ExecuteReader();


                //boton registrar
                // validar correo

                //Botones para validar si el correo introducido es el correcto o no


                /*
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
                */
            }
            catch
            {


            }

           }
        }
    }

