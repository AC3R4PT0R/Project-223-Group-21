using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//ND
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_223_Group_21
{
    public partial class stock_add_frm : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;

        public stock_add_frm()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pname.Text = "";
            txt_pprice.Text = "";
            txt_pquantity.Text = "";
            txt_psize.Text = "";

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            string pName, pPrice, pQuantity, pSize = "";

            pName = txt_pname.Text;
            pPrice = txt_pprice.Text;
            pQuantity = txt_pquantity.Text;
            pSize = txt_psize.Text;
            DialogResult dialogResult = MessageBox.Show("Addition of Stock", "Are you sure you infomation on stock is correct", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    sqlCon = new SqlConnection(connectStrLogin);
                    sqlCon.Open();

                    SqlCommand SQLInsert = new SqlCommand($"INSERT INTO tbl_stock(ProductName,Quantity,ProductPrice,Size) VALUES('{pName}','{pPrice}','{pQuantity}','{pSize}')", sqlCon);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                    sqlDataAdapter.InsertCommand = SQLInsert;
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                    sqlCon.Close();

                    MessageBox.Show("You have successfully added stock");

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
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

        private void stock_add_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
