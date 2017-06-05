using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace BilingualApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void traductor_Click(object sender, EventArgs e)
        {
            //inicializa el traductor de google ya instalado en el escritorio

            Process p = Process.Start("C:\\Users\\JAIME\\Desktop\\traductor.exe");
            Thread.Sleep(500);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, Handle);
            //traductor tra = new traductor();
            //tra.Visible = true;
            //Hide();
        }

        private void bilingual_Click(object sender, EventArgs e)
        {
            Home bi = new Home();
            bi.Visible = true;
            Hide();

            //Texto de prueba
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
