namespace BilingualApp
{
    partial class PreguntasVERBTOBENvl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntasVERBTOBENvl1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpcionA = new System.Windows.Forms.LinkLabel();
            this.OpcionB = new System.Windows.Forms.LinkLabel();
            this.OpcionC = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(1, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(468, 256);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(465, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OpcionA
            // 
            this.OpcionA.AutoSize = true;
            this.OpcionA.BackColor = System.Drawing.Color.Transparent;
            this.OpcionA.LinkColor = System.Drawing.Color.Red;
            this.OpcionA.Location = new System.Drawing.Point(11, 311);
            this.OpcionA.Name = "OpcionA";
            this.OpcionA.Size = new System.Drawing.Size(51, 13);
            this.OpcionA.TabIndex = 2;
            this.OpcionA.TabStop = true;
            this.OpcionA.Text = "Opcion A";
            // 
            // OpcionB
            // 
            this.OpcionB.AutoSize = true;
            this.OpcionB.BackColor = System.Drawing.Color.Transparent;
            this.OpcionB.LinkColor = System.Drawing.Color.Red;
            this.OpcionB.Location = new System.Drawing.Point(11, 366);
            this.OpcionB.Name = "OpcionB";
            this.OpcionB.Size = new System.Drawing.Size(51, 13);
            this.OpcionB.TabIndex = 3;
            this.OpcionB.TabStop = true;
            this.OpcionB.Text = "Opcion B";
            // 
            // OpcionC
            // 
            this.OpcionC.AutoSize = true;
            this.OpcionC.BackColor = System.Drawing.Color.Transparent;
            this.OpcionC.LinkColor = System.Drawing.Color.Red;
            this.OpcionC.Location = new System.Drawing.Point(12, 418);
            this.OpcionC.Name = "OpcionC";
            this.OpcionC.Size = new System.Drawing.Size(51, 13);
            this.OpcionC.TabIndex = 4;
            this.OpcionC.TabStop = true;
            this.OpcionC.Text = "Opcion C";
            // 
            // PreguntasVERBTOBENvl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 492);
            this.Controls.Add(this.OpcionC);
            this.Controls.Add(this.OpcionB);
            this.Controls.Add(this.OpcionA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreguntasVERBTOBENvl1";
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.PreguntasVERBTOBENvl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel OpcionA;
        private System.Windows.Forms.LinkLabel OpcionB;
        private System.Windows.Forms.LinkLabel OpcionC;
    }
}