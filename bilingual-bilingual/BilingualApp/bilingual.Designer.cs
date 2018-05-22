namespace BilingualApp
{
    partial class Bilingual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilingual));
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnPreguntas = new System.Windows.Forms.Button();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.BtnAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHome
            // 
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(578, 12);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(63, 77);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabIndex = 16;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.Location = new System.Drawing.Point(369, 259);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 27);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPreguntas
            // 
            this.BtnPreguntas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPreguntas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPreguntas.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPreguntas.Location = new System.Drawing.Point(369, 129);
            this.BtnPreguntas.Name = "BtnPreguntas";
            this.BtnPreguntas.Size = new System.Drawing.Size(86, 27);
            this.BtnPreguntas.TabIndex = 18;
            this.BtnPreguntas.Text = "Preguntas";
            this.BtnPreguntas.UseVisualStyleBackColor = true;
            this.BtnPreguntas.Click += new System.EventHandler(this.BtnPreguntas_Click);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistro.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistro.Location = new System.Drawing.Point(369, 196);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(86, 27);
            this.BtnRegistro.TabIndex = 19;
            this.BtnRegistro.Text = "Registro";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlumnos.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAlumnos.Location = new System.Drawing.Point(369, 70);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(86, 27);
            this.BtnAlumnos.TabIndex = 20;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.UseVisualStyleBackColor = true;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // Bilingual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 356);
            this.Controls.Add(this.BtnAlumnos);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.BtnPreguntas);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnHome);
            this.Name = "Bilingual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilingual";
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnPreguntas;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Button BtnAlumnos;
    }
}