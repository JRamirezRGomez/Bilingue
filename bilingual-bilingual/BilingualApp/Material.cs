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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegAlumnos ralu = new RegAlumnos();
            ralu.Visible = true;
            Close();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Login bi = new Login();
            bi.Visible = true;
            Close();
        }

        private void VerboToBe_CheckedChanged(object sender, EventArgs e)
        {
            if(VerboToBe.Checked)
            {
                Nivel1vtb.Enabled = true;
                nivel2vtb.Enabled = true;
                Nivel3vtb.Enabled = true;
            }
            else
            {
                Nivel1vtb.Enabled = false;
                nivel2vtb.Enabled = false;
                Nivel3vtb.Enabled = false;
            }
        }

        private void DoWhile_CheckedChanged(object sender, EventArgs e)
        {
            if(DoWhile.Checked)
            {
                Nivel1dw.Enabled = true;
                Nivel2dw.Enabled = true;
                Nivel3dw.Enabled = true;
            }
            else
            {
                Nivel1dw.Enabled = false;
                Nivel2dw.Enabled = false;
                Nivel3dw.Enabled = false;
            }
        }

        private void Gramatica_CheckedChanged(object sender, EventArgs e)
        {
            if(Gramatica.Checked)
            {
                grama.Enabled = true;//fix
            }
            else
            {
                grama.Enabled = false;
            }
        }

        private void Material_Load(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home c = new Home();
            c.Visible = true;
            Close();

        }

        private void Nivel1vtb_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }

        private void nivel2vtb_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }

        private void Nivel3vtb_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }

        private void Nivel1dw_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }

        private void Nivel2dw_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }

        private void Nivel3dw_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }

        private void grama_Click(object sender, EventArgs e)
        {
            PreguntasVERBTOBENvl1 p = new PreguntasVERBTOBENvl1();
            p.Visible = true;
            Close();
        }
    }
}
