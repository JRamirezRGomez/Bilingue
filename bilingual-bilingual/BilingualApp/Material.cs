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
            //wisiwik
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            bilingual bi = new bilingual();
            bi.Visible = true;
            Close();
        }
    }
}
