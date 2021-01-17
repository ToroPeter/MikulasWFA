
namespace Mikulas
{
    partial class frmOsztaly
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
            this.tallozasBT = new System.Windows.Forms.Button();
            this.doneBT = new System.Windows.Forms.Button();
            this.osztalyTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.talloTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tallozasBT
            // 
            this.tallozasBT.Location = new System.Drawing.Point(427, 48);
            this.tallozasBT.Name = "tallozasBT";
            this.tallozasBT.Size = new System.Drawing.Size(209, 23);
            this.tallozasBT.TabIndex = 0;
            this.tallozasBT.Text = "Tallózás";
            this.tallozasBT.UseVisualStyleBackColor = true;
            this.tallozasBT.Click += new System.EventHandler(this.tallozasBT_Click);
            // 
            // doneBT
            // 
            this.doneBT.Location = new System.Drawing.Point(89, 105);
            this.doneBT.Name = "doneBT";
            this.doneBT.Size = new System.Drawing.Size(547, 23);
            this.doneBT.TabIndex = 1;
            this.doneBT.Text = "Hozzáadás adatbázishoz";
            this.doneBT.UseVisualStyleBackColor = true;
            this.doneBT.Click += new System.EventHandler(this.doneBT_Click);
            // 
            // osztalyTB
            // 
            this.osztalyTB.Location = new System.Drawing.Point(331, 79);
            this.osztalyTB.Name = "osztalyTB";
            this.osztalyTB.Size = new System.Drawing.Size(305, 20);
            this.osztalyTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "írja be az osztálykelzést:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Osztálynévsor tallózása:";
            // 
            // talloTB
            // 
            this.talloTB.Location = new System.Drawing.Point(89, 50);
            this.talloTB.Name = "talloTB";
            this.talloTB.Size = new System.Drawing.Size(332, 20);
            this.talloTB.TabIndex = 5;
            this.talloTB.TextChanged += new System.EventHandler(this.talloTB_TextChanged);
            // 
            // frmOsztaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.talloTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osztalyTB);
            this.Controls.Add(this.doneBT);
            this.Controls.Add(this.tallozasBT);
            this.Name = "frmOsztaly";
            this.Text = "frmOsztaly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tallozasBT;
        private System.Windows.Forms.Button doneBT;
        private System.Windows.Forms.TextBox osztalyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox talloTB;
    }
}