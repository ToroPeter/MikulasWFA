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
    public partial class frmMain : Form
    {
        static string connectionString = @"Server = (localdb)\MSSQLLocalDB;" + @"AttachDbFileName=|DataDirectory|Resources\mikulas.mdf;";
        static SqlConnection conn = new SqlConnection(connectionString);

        public frmMain(){
            InitializeComponent();
        }
        private void exitBT_Click(object sender, EventArgs e){
            if (MessageBox.Show("Biztos be akarod zárni?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }

        private void osztalyBT_Click(object sender, EventArgs e){ 
            frmOsztaly frmOsztaly = new frmOsztaly(connectionString);
            frmOsztaly.ShowDialog();
        }

        private void sorsolasBT_Click(object sender, EventArgs e){
            frmSorsolas frmSorsolas = new frmSorsolas(connectionString);
            frmSorsolas.ShowDialog();
        }

        private void csomagepitoBT_Click(object sender, EventArgs e){
            csomagBuilder csomagBuilder = new csomagBuilder(connectionString);
            csomagBuilder.ShowDialog();
        }
    }
}
