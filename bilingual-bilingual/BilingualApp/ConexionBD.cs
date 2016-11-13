using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BilingualApp
{
    public partial class ConexionBD : Form
    {
        public ConexionBD()

        {

            InitializeComponent();

            MySqlConnectionStringBuilder Conectar = new MySqlConnectionStringBuilder();
            Conectar.Server = "localhost";
            Conectar.UserID = "root";
            Conectar.Password = "";
            Conectar.Database = "Bilingual";

        }

            

                 
      
            }
          
        }