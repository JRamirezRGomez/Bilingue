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
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCorreo.Location = new System.Drawing.Point(206, 44);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(181, 27);
            this.TxtCorreo.TabIndex = 0;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.TxtContrasena.Location = new System.Drawing.Point(206, 142);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(181, 27);
            this.TxtContrasena.TabIndex = 1;
            this.TxtContrasena.TextChanged += new System.EventHandler(this.TxtContrasena_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Correo Electronico";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAtras.Location = new System.Drawing.Point(21, 243);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(108, 34);
            this.BtnAtras.TabIndex = 9;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarse.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarse.Location = new System.Drawing.Point(178, 243);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(108, 34);
            this.BtnRegistrarse.TabIndex = 10;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = true;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIniciar.Location = new System.Drawing.Point(330, 243);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(108, 34);
            this.BtnIniciar.TabIndex = 11;
            this.BtnIniciar.Text = "Iniciar sesion";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Bilingual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 312);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtCorreo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bilingual";
            this.Text = "Bilingual";
            this.Load += new System.EventHandler(this.Bilingual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.Button BtnIniciar;
    }
}