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
            this.BtnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // traductor
            // 
            this.traductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.traductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.traductor.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.traductor.Location = new System.Drawing.Point(308, 133);
            this.traductor.Name = "traductor";
            this.traductor.Size = new System.Drawing.Size(86, 27);
            this.traductor.TabIndex = 0;
            this.traductor.Text = "Traductor";
            this.traductor.UseVisualStyleBackColor = true;
            this.traductor.Click += new System.EventHandler(this.traductor_Click);
            // 
            // bilingual
            // 
            this.bilingual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bilingual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilingual.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.bilingual.Location = new System.Drawing.Point(133, 133);
            this.bilingual.Name = "bilingual";
            this.bilingual.Size = new System.Drawing.Size(86, 27);
            this.bilingual.TabIndex = 1;
            this.bilingual.Text = "Bilingual";
            this.bilingual.UseVisualStyleBackColor = true;
            this.bilingual.Click += new System.EventHandler(this.bilingual_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BackgroundImage = global::BilingualApp.Properties.Resources.Home;
            this.BtnHome.Image = global::BilingualApp.Properties.Resources.EnglishLogoOfficial;
            this.BtnHome.Location = new System.Drawing.Point(37, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(450, 184);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabIndex = 18;
            this.BtnHome.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 261);
            this.Controls.Add(this.bilingual);
            this.Controls.Add(this.traductor);
            this.Controls.Add(this.BtnHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button traductor;
        private System.Windows.Forms.Button bilingual;
        private System.Windows.Forms.PictureBox BtnHome;
    }
}

