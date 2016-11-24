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


            try
            {
                string Conectar = ("server=localhost; database=Bilingual; Uid=root; pwd=");

                string Query ="INSERT INTO alumnos(ID_Alumno,Nombre,Apellido_P,Apellido_M) values('"+this.TxtNumero.Text+"','"+this.TxtNombre.Text+"','"+this.TxtAP.Text+"','"+this.TxtAM.Text+"');";

                MySqlConnection ConexionAlumnos = new MySqlConnection(Conectar);

                MySqlCommand Conexion = new MySqlCommand(Query, ConexionAlumnos);

                MySqlDataReader LeerDatos;

                ConexionAlumnos.Open();

                LeerDatos = ConexionAlumnos.ExecuteReader();
            }

            catch
            {


            }


        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home c = new Home();
            c.Visible = true;
            Close();

            //Este boton regresa al Home
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

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
    }
}
