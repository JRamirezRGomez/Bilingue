﻿using System;
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
    public partial class Salon : Form
        /*
        aqui el maestro indicara el numero de estudiantes 
        que tiene en esta clase y asi se generara los botones 
        para cada alumno con un numero que indique su posicion en la lista
        */
    {
        String alu;
        int x = 0;     
        public Salon()
        {
            InitializeComponent();
            
        }

        private void numalu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Salon_Load(object sender, EventArgs e)
        {

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            bilingual b= new bilingual();
            b.Visible = true;
            Close();
            //Ajustes de prueba
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
