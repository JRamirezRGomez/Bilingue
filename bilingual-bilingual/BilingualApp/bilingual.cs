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

namespace BilingualApp
{
    public partial class bilingual : Form
    {
        public string user, pass;

        public bilingual()
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
            registrar reg = new registrar();
            reg.Visible = true;
            Hide();

            /*try
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salon mat = new Salon();
            mat.Visible = true;
            Close();
            
            /* try
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

            //texto de prueba
        }
    }
}
