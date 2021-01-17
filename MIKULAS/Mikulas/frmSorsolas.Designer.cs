
namespace Mikulas
{
    partial class frmSorsolas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.osztalyCB = new System.Windows.Forms.ComboBox();
            this.rndBT = new System.Windows.Forms.Button();
            this.rnd1 = new System.Windows.Forms.TextBox();
            this.rnd2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.doneBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mikulasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikulasDataSet = new Mikulas.mikulasDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikulasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikulasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "válaszd ki az osztályt:";
            // 
            // osztalyCB
            // 
            this.osztalyCB.FormattingEnabled = true;
            this.osztalyCB.Location = new System.Drawing.Point(16, 46);
            this.osztalyCB.Name = "osztalyCB";
            this.osztalyCB.Size = new System.Drawing.Size(121, 21);
            this.osztalyCB.TabIndex = 1;
            // 
            // rndBT
            // 
            this.rndBT.Location = new System.Drawing.Point(143, 46);
            this.rndBT.Name = "rndBT";
            this.rndBT.Size = new System.Drawing.Size(257, 23);
            this.rndBT.TabIndex = 2;
            this.rndBT.Text = "véletlenszerű összepárosítás";
            this.rndBT.UseVisualStyleBackColor = true;
            // 
            // rnd1
            // 
            this.rnd1.Location = new System.Drawing.Point(16, 293);
            this.rnd1.Name = "rnd1";
            this.rnd1.Size = new System.Drawing.Size(100, 20);
            this.rnd1.TabIndex = 3;
            // 
            // rnd2
            // 
            this.rnd2.Location = new System.Drawing.Point(204, 289);
            this.rnd2.Name = "rnd2";
            this.rnd2.Size = new System.Drawing.Size(100, 20);
            this.rnd2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "csere";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // doneBT
            // 
            this.doneBT.Location = new System.Drawing.Point(310, 289);
            this.doneBT.Name = "doneBT";
            this.doneBT.Size = new System.Drawing.Size(173, 23);
            this.doneBT.TabIndex = 6;
            this.doneBT.Text = "Véglegesítés!";
            this.doneBT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.mikulasDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // mikulasDataSetBindingSource
            // 
            this.mikulasDataSetBindingSource.DataSource = this.mikulasDataSet;
            this.mikulasDataSetBindingSource.Position = 0;
            // 
            // mikulasDataSet
            // 
            this.mikulasDataSet.DataSetName = "mikulasDataSet";
            this.mikulasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "a_ID1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "a_ID2";
            // 
            // frmSorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doneBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rnd2);
            this.Controls.Add(this.rnd1);
            this.Controls.Add(this.rndBT);
            this.Controls.Add(this.osztalyCB);
            this.Controls.Add(this.label1);
            this.Name = "frmSorsolas";
            this.Text = "frmSorsolas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikulasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikulasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox osztalyCB;
        private System.Windows.Forms.Button rndBT;
        private System.Windows.Forms.TextBox rnd1;
        private System.Windows.Forms.TextBox rnd2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button doneBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mikulasDataSetBindingSource;
        private mikulasDataSet mikulasDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}