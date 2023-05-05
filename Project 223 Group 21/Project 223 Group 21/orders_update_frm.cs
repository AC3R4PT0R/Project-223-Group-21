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
    public partial class orders_update_frm : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader DataReader;

        public orders_update_frm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.ShowDialog();
            this.Close();
        }

        private void orders_update_frm_Load(object sender, EventArgs e)
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

            string sqllogin = "SELECT * FROM tbl_orders";
            sqlCom = new SqlCommand(sqllogin, sqlCon);
            DataReader = sqlCom.ExecuteReader();

            while (DataReader.Read())
            {
                comboBox1.Items.Add(DataReader.GetValue(0).ToString());
            }

            sqlCon.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string oName, oStatus, oDateRec = "";

            oName = comboBox1.SelectedItem.ToString();
            oStatus = txt_ostatus.Text;
            oDateRec = txt_recieved.Text;

            sqlCon.Open();
            DialogResult dialogResult = MessageBox.Show("Update of Order Data : ", "Are you sure you want to Update this Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlOrder= "UPDATE tbl_orders SET OrderStatus = @oStatus WHERE OrderNumber = @Name";
                sqlCom = new SqlCommand(sqlOrder, sqlCon);
                sqlCom.Parameters.AddWithValue("@oStatus", oStatus);
                sqlCom.Parameters.AddWithValue("@Name", oName);
                sqlCom.ExecuteNonQuery();

                string sqlRecDate = "UPDATE tbl_orders SET Date Recieved = @oDateRec WHERE OrderNumber = @Name";
                sqlCom = new SqlCommand(sqlRecDate, sqlCon);
                sqlCom.Parameters.AddWithValue("@oDateRec", oDateRec);
                sqlCom.Parameters.AddWithValue("@Name", oName);
                sqlCom.ExecuteNonQuery();

                sqlCon.Close();
                MessageBox.Show("Order" + " was successfully updated");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            sqlCon.Close();
        }
    }
}
