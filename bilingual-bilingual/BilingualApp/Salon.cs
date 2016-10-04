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
            x = 0;//restablece el valor a cero
            alu = numalu.Text;
            x = Convert.ToInt32(alu);
                
            /*maestro indica numero de alumnos
            alu contiene ese numero
             hay que ver como se lo pasamos a el creador de bottones
             esta abajo...

            esto es una preuba
            */

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generamos el array de botones uno para cada
            //estudiante con su numero de lista
            int top = 100;
            int left = 100;
            for (int i = 1; i < x+1; i++)
            {
                //se le pone el numero al boton usando el
                //contador de FOR para asi ir aumentando el numero
                Button button = new Button();
                button.Text = i.ToString();
                button.Left = left;
                button.Top = top;
                this.Controls.Add(button);
                top += button.Height + 2;
            }
            
        }

        private void Salon_Load(object sender, EventArgs e)
        {

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            bilingual b= new bilingual();
            b.Visible = true;
            Close();
        }
    }
}
