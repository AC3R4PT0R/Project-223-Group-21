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
    public partial class stock_delete_frm : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqldat;
        DataSet ds;
        SqlDataReader DataReader;
        public stock_delete_frm()
        {
            InitializeComponent();
        }

        private void stock_delete_frm_Load(object sender, EventArgs e)
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

            string sqllogin = "SELECT * FROM tbl_stock";
            sqlCom = new SqlCommand(sqllogin, sqlCon);
            DataReader = sqlCom.ExecuteReader();

            while (DataReader.Read())
            {
                comboBox1.Items.Add(DataReader.GetValue(1).ToString());
            }

            sqlCon.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int icountusers = 0;
            int iLengthUser = 0;
            string sStockItem = "";
            int iDelLengthDiff = 0;

            sStockItem = comboBox1.SelectedItem.ToString();
            iLengthUser = comboBox1.SelectedItem.ToString().Length;
            iDelLengthDiff = 50 - iLengthUser;
            for (int i = 0; i < iDelLengthDiff; i++)
            {
                sStockItem = sStockItem + " ";
            }
            sqlCon.Open();
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            DialogResult dialogResult = MessageBox.Show("Removal of entirety of stock : " , "Are you sure you want to Delete stock", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string SqlDelete = "DELETE FROM tbl_stock WHERE ProductName = @Stock";//ND
                sqlCom = new SqlCommand(SqlDelete, sqlCon);
                sqlCom.Parameters.AddWithValue("@Stock", sStockItem);//ND
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Product " + sStockItem + " was successfully deleted");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
