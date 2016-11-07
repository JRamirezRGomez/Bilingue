namespace BilingualApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.traductor = new System.Windows.Forms.Button();
            this.bilingual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // traductor
            // 
            this.traductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.traductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.traductor.Location = new System.Drawing.Point(155, 117);
            this.traductor.Name = "traductor";
            this.traductor.Size = new System.Drawing.Size(75, 23);
            this.traductor.TabIndex = 0;
            this.traductor.Text = "Traductor";
            this.traductor.UseVisualStyleBackColor = true;
            this.traductor.Click += new System.EventHandler(this.traductor_Click);
            // 
            // bilingual
            // 
            this.bilingual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bilingual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilingual.Location = new System.Drawing.Point(313, 117);
            this.bilingual.Name = "bilingual";
            this.bilingual.Size = new System.Drawing.Size(75, 23);
            this.bilingual.TabIndex = 1;
            this.bilingual.Text = "Bilingual";
            this.bilingual.UseVisualStyleBackColor = true;
            this.bilingual.Click += new System.EventHandler(this.bilingual_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(537, 261);
            this.Controls.Add(this.bilingual);
            this.Controls.Add(this.traductor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button traductor;
        private System.Windows.Forms.Button bilingual;
    }
}

