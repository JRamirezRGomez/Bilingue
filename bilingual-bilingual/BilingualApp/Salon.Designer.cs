namespace BilingualApp
{
    partial class Salon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Crear = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.numalu = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indique el numero de Estudiantes de esta clase";
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(261, 51);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 2;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(109, 51);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // numalu
            // 
            this.numalu.Location = new System.Drawing.Point(203, 25);
            this.numalu.MaxLength = 2;
            this.numalu.Name = "numalu";
            this.numalu.Size = new System.Drawing.Size(40, 20);
            this.numalu.TabIndex = 0;
            this.numalu.TextChanged += new System.EventHandler(this.numalu_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(185, 252);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Salon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(435, 496);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numalu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Salon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.Salon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.TextBox numalu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Agregar;
    }
}