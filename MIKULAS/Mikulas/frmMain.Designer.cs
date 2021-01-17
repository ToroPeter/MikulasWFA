
namespace Mikulas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.osztalyBT = new System.Windows.Forms.Button();
            this.sorsolasBT = new System.Windows.Forms.Button();
            this.csomagepitoBT = new System.Windows.Forms.Button();
            this.exitBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // osztalyBT
            // 
            this.osztalyBT.Location = new System.Drawing.Point(241, 12);
            this.osztalyBT.Name = "osztalyBT";
            this.osztalyBT.Size = new System.Drawing.Size(177, 70);
            this.osztalyBT.TabIndex = 1;
            this.osztalyBT.Text = "osztály betöltése";
            this.osztalyBT.UseVisualStyleBackColor = true;
            this.osztalyBT.Click += new System.EventHandler(this.osztalyBT_Click);
            // 
            // sorsolasBT
            // 
            this.sorsolasBT.Location = new System.Drawing.Point(241, 88);
            this.sorsolasBT.Name = "sorsolasBT";
            this.sorsolasBT.Size = new System.Drawing.Size(177, 70);
            this.sorsolasBT.TabIndex = 2;
            this.sorsolasBT.Text = "sorsolás";
            this.sorsolasBT.UseVisualStyleBackColor = true;
            this.sorsolasBT.Click += new System.EventHandler(this.sorsolasBT_Click);
            // 
            // csomagepitoBT
            // 
            this.csomagepitoBT.Location = new System.Drawing.Point(241, 164);
            this.csomagepitoBT.Name = "csomagepitoBT";
            this.csomagepitoBT.Size = new System.Drawing.Size(177, 70);
            this.csomagepitoBT.TabIndex = 3;
            this.csomagepitoBT.Text = "Csomagépítő";
            this.csomagepitoBT.UseVisualStyleBackColor = true;
            this.csomagepitoBT.Click += new System.EventHandler(this.csomagepitoBT_Click);
            // 
            // exitBT
            // 
            this.exitBT.ForeColor = System.Drawing.Color.Green;
            this.exitBT.Location = new System.Drawing.Point(241, 240);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(177, 70);
            this.exitBT.TabIndex = 4;
            this.exitBT.Text = "Kilépés";
            this.exitBT.UseVisualStyleBackColor = true;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBT);
            this.Controls.Add(this.csomagepitoBT);
            this.Controls.Add(this.sorsolasBT);
            this.Controls.Add(this.osztalyBT);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button osztalyBT;
        private System.Windows.Forms.Button sorsolasBT;
        private System.Windows.Forms.Button csomagepitoBT;
        private System.Windows.Forms.Button exitBT;
    }
}

