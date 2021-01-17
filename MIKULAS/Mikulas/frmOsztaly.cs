using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikulas
{
    public partial class frmOsztaly : Form
    {
        string connectionString;
        SqlConnection conn;
        public frmOsztaly( string connectionString){
            this.connectionString = connectionString;
            conn = new SqlConnection(connectionString);
            InitializeComponent();
        }
        private void tallozasBT_Click(object sender, EventArgs e){
            var ofd = new OpenFileDialog();
            talloTB.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }
        private void talloTB_TextChanged(object sender, EventArgs e){
            if (File.Exists(talloTB.Text)){
                osztalyTB.ReadOnly = false;
                doneBT.Enabled = true;
            }
            else{
                doneBT.Enabled = false;
            }
        }
        private void doneBT_Click(object sender, EventArgs e){
            using (var sr = new StreamReader(talloTB.Text)){
                conn.Open();
                while (!sr.EndOfStream) { int cmd = new SqlCommand($"Insert into emberek values('{sr.ReadLine()}', '{osztalyTB.Text}');", conn).ExecuteNonQuery(); }
                conn.Close();
            }
        }
    }
}
