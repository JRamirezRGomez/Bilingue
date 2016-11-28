using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BilingualApp
{
    public class ConexionBD
    {
        public static MySqlConnection Conexion()
        {

            MySqlConnection Conectar = new MySqlConnection(
                "server=localhost;  database=Bilingual; Uid=root; pwd=");


            Conectar.Open();
            return Conectar;
    }
}


        }

