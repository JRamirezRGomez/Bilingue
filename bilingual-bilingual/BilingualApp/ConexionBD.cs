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
    public partial class ConexionBD : Form
    {
        public ConexionBD()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "mydb01";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO mitabla (valor1,valor2) value (1,2)";
            conn.Open();
            cmd.ExecuteNonQuery();



    }
}
