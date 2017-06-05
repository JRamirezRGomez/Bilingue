using System;
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
    public partial class PreguntasVERBTOBENvl1 : Form
    {
        public PreguntasVERBTOBENvl1()
        {
            InitializeComponent();
        }
        //creamos el arreglo con las preguntas ya seleccionadas de prueba

        string[] preguntas = new string[5] { "The pencil is on the desk.",
        "The weather today is good.","I am a good student."
            ,"He and Mary are good students.","She is a good football player."};

        private void OpA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //creamos funcion random para elegir numero aletorio y seleccionar pregunta
            Random rdn = new Random();
            //se generara el rango deacuerdo al numero maximo de preguntas y 0
            int al = rdn.Next(0, preguntas.Length);
            richTextBox1.Text = preguntas[al];
        }

        private void PreguntasVERBTOBENvl1_Load(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Bilingual bi = new Bilingual();
            bi.Visible = true;
            Close();
        }
    }
}
