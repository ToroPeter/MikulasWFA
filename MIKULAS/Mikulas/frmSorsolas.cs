using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikulas
{
    public partial class frmSorsolas : Form
    {
        string connectionString;
        SqlConnection conn;
        public frmSorsolas(string connectionString){
            this.connectionString = connectionString;
            conn = new SqlConnection(connectionString);
            InitializeComponent();
        }
        private void FrmSorsolas_Load(object sender, EventArgs e){
            conn.Open();
            SqlDataReader cmd = new SqlCommand("Select distinct osztaly from emberek;", conn).ExecuteReader();
            while (cmd.Read())
            {
                osztalyCB.Items.Add(cmd[0]);
            }
            conn.Close();
        }
    }
}


