namespace BilingualApp
{
    partial class RegAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegAlumnos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.NumTotal = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtAP = new System.Windows.Forms.TextBox();
            this.TxtAM = new System.Windows.Forms.TextBox();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llene los campos de los alumnos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(105, 237);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 1;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // NumTotal
            // 
            this.NumTotal.AutoSize = true;
            this.NumTotal.Location = new System.Drawing.Point(338, 41);
            this.NumTotal.Name = "NumTotal";
            this.NumTotal.Size = new System.Drawing.Size(0, 13);
            this.NumTotal.TabIndex = 3;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(338, 41);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(13, 13);
            this.Num.TabIndex = 4;
            this.Num.Text = "0";
            this.Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num.Click += new System.EventHandler(this.Num_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(354, 237);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "No. Lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido Materno";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(269, 76);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(187, 20);
            this.TxtNumero.TabIndex = 10;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(269, 105);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(187, 20);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtAP
            // 
            this.TxtAP.Location = new System.Drawing.Point(269, 131);
            this.TxtAP.Name = "TxtAP";
            this.TxtAP.Size = new System.Drawing.Size(187, 20);
            this.TxtAP.TabIndex = 12;
            // 
            // TxtAM
            // 
            this.TxtAM.Location = new System.Drawing.Point(269, 161);
            this.TxtAM.Name = "TxtAM";
            this.TxtAM.Size = new System.Drawing.Size(187, 20);
            this.TxtAM.TabIndex = 13;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(12, 10);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(41, 55);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabIndex = 14;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // RegAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(554, 313);
            this.Controls.Add(this.TxtAM);
            this.Controls.Add(this.TxtAP);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.NumTotal);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHome);
            this.Name = "RegAlumnos";
            this.Text = "v";
            this.Load += new System.EventHandler(this.RegAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label NumTotal;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtAP;
        private System.Windows.Forms.TextBox TxtAM;
        private System.Windows.Forms.PictureBox BtnHome;
    }
}