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
            //wisiwikllvbvbvjvvhjjhbjj
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            bilingual bi = new bilingual();
            bi.Visible = true;//jhjbfjb
            Close();
        }

        private void VerboToBe_CheckedChanged(object sender, EventArgs e)
        {
            if(VerboToBe.Checked=false)
            {
                Nivel1vtb.Enabled = false;
                nivel2vtb.Enabled = false;
                Nivel3vtb.Enabled = false;

                //ajsifhdiasksjadjkasaaaaaaaaaaaaabbbbbbbbbbbbbbbbbb
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
                grama.Enabled = false;
            }
        }

        private void Nivel1vtb_Click(object sender, EventArgs e)
        {
            //ibibi
        }

        private void Material_Load(object sender, EventArgs e)
        {

        }
    } //kjajsajkdjask
}
