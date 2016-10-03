namespace BilingualApp
{
    partial class Material
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
            this.VerbToBe = new System.Windows.Forms.Button();
            this.DoWhile = new System.Windows.Forms.Button();
            this.Gramatica = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerbToBe
            // 
            this.VerbToBe.Location = new System.Drawing.Point(23, 168);
            this.VerbToBe.Name = "VerbToBe";
            this.VerbToBe.Size = new System.Drawing.Size(75, 23);
            this.VerbToBe.TabIndex = 0;
            this.VerbToBe.Text = "Verbo To-Be";
            this.VerbToBe.UseVisualStyleBackColor = true;
            this.VerbToBe.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoWhile
            // 
            this.DoWhile.Location = new System.Drawing.Point(23, 103);
            this.DoWhile.Name = "DoWhile";
            this.DoWhile.Size = new System.Drawing.Size(75, 23);
            this.DoWhile.TabIndex = 1;
            this.DoWhile.Text = "Do-While";
            this.DoWhile.UseVisualStyleBackColor = true;
            // 
            // Gramatica
            // 
            this.Gramatica.Location = new System.Drawing.Point(23, 34);
            this.Gramatica.Name = "Gramatica";
            this.Gramatica.Size = new System.Drawing.Size(75, 23);
            this.Gramatica.TabIndex = 2;
            this.Gramatica.Text = "Gramatica";
            this.Gramatica.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(23, 303);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 23);
            this.Atras.TabIndex = 3;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 355);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Gramatica);
            this.Controls.Add(this.DoWhile);
            this.Controls.Add(this.VerbToBe);
            this.Name = "Material";
            this.Text = "Material";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerbToBe;
        private System.Windows.Forms.Button DoWhile;
        private System.Windows.Forms.Button Gramatica;
        private System.Windows.Forms.Button Atras;
    }
}