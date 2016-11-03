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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salon vrb = new Salon();
            vrb.Visible = true;
            Close();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            bilingual bi = new bilingual();
            bi.Visible = true;
            Close();
        }

        private void VerboToBe_CheckedChanged(object sender, EventArgs e)
        {
            if(VerboToBe.Checked=false)
            {
                Nivel1vtb.Enabled = false;
                nivel2vtb.Enabled = false;
                Nivel3vtb.Enabled = false;

            }
        }

        private void DoWhile_CheckedChanged(object sender, EventArgs e)
        {
            if(DoWhile.Checked=false)
            {
                Nivel1dw.Enabled = false;
                Nivel2dw.Enabled = false;
                Nivel3dw.Enabled = false;
            }
        }

        private void Gramatica_CheckedChanged(object sender, EventArgs e)
        {
            if(Gramatica.Checked=false)
            {
                grama.Enabled = false;//fix
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
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }

        private void nivel2vtb_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }

        private void Nivel3vtb_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }

        private void Nivel1dw_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }

        private void Nivel2dw_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }

        private void Nivel3dw_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }

        private void grama_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.Visible = true;
            Close();
        }
    }
}
