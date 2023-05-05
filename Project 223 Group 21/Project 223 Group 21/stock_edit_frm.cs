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
    public partial class stock_edit_frm : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader DataReader;

        public stock_edit_frm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }

        private void stock_edit_frm_Load(object sender, EventArgs e)
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
            string pName, pPrice, pQuantity, pSize = "";
            //int iLengthUser, iDelLengthDiff = 0;


            pName = comboBox1.SelectedItem.ToString();
            pPrice = txt_pprice.Text;
            pQuantity = txt_pquantity.Text;
            pSize = txt_psize.Text;

            sqlCon.Open();
            DialogResult dialogResult = MessageBox.Show("Update of Stock Data : " , "Are you sure you want to Update this data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlEditQuan = "UPDATE tbl_stock SET Quantity = @Quantity WHERE ProductName = @Name";
                sqlCom = new SqlCommand(sqlEditQuan, sqlCon);
                sqlCom.Parameters.AddWithValue("@Quantity", pQuantity);
                sqlCom.Parameters.AddWithValue("@Name", pName);
                sqlCom.ExecuteNonQuery();


                string sqlEditprice = "UPDATE tbl_stock SET ProductPrice = @Price WHERE ProductName = @Name";
                sqlCom = new SqlCommand(sqlEditprice, sqlCon);
                sqlCom.Parameters.AddWithValue("@Price", pPrice);
                sqlCom.Parameters.AddWithValue("@Name", pName);
                sqlCom.ExecuteNonQuery();

                string sqlEditsize = "UPDATE tbl_stock SET Size = @Size WHERE ProductName = @Name";
                sqlCom = new SqlCommand(sqlEditsize, sqlCon);
                sqlCom.Parameters.AddWithValue("@Size", pSize);
                sqlCom.Parameters.AddWithValue("@Name", pName);
                sqlCom.ExecuteNonQuery();

                sqlCon.Close();
                MessageBox.Show("Stock"+ " was successfully updated");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            sqlCon.Close();
        }
    }
}
