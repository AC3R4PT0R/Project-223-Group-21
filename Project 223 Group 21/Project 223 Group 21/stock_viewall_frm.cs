using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_223_Group_21
{
    public partial class stock_viewall_frm : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqldat;
        DataSet ds;
        SqlDataReader DataReader;

        public stock_viewall_frm()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(connectStrLogin);
                sqlCon.Open();
                sqlCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            sqlCon.Open();
            sqldat = new SqlDataAdapter();
            ds = new DataSet();

            string sqlDisplay = "SELECT * FROM tbl_stock";

            sqlCom = new SqlCommand(sqlDisplay, sqlCon);
            sqldat.SelectCommand = sqlCom;
            sqldat.Fill(ds, "SourceTable");//ND

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            sqlCon.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }
    }
}
