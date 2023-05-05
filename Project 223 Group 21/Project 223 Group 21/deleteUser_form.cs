using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ND

namespace Project_223_Group_21
{
    public partial class deleteUser_form : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader DataReader;
        public string sUsername = "";
        public deleteUser_form()
        {
            InitializeComponent();
        }

        private void deleteUser_form_Load(object sender, EventArgs e)
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
            btn_delete.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int icountusers = 0;
            int iLengthUser = 0;
            int iDelLengthDiff = 0;
            //int iDelIndex = 0;
            bool UserExists = false;
            if (txt_deleteUser.Text == "")
            {
                MessageBox.Show("No name was entered");//ND
            }
            else
            {
                sUsername = txt_deleteUser.Text;

                iLengthUser = sUsername.Length;
                iDelLengthDiff = 20 - iLengthUser;
                for (int i = 0; i < iDelLengthDiff; i++)
                {
                    sUsername = sUsername + " ";
                }

                sqlCon.Open();
                string sqllogin = "SELECT * FROM tbl_login";
                sqlCom = new SqlCommand(sqllogin, sqlCon);
                DataReader = sqlCom.ExecuteReader();

                string[] Arrusers = new string[20];

                while (DataReader.Read())
                {
                    Arrusers[icountusers] = DataReader.GetValue(0).ToString();//ND
                    icountusers++;
                }

                /*MessageBox.Show(sUsername);
                for (int k = 0; k < 10; k++) 
                {
                    MessageBox.Show(Arrusers[k]);//ND
                }*/

                for (int i = 0; i < icountusers; i++)
                    if (Arrusers[i] == sUsername)
                    {
                        MessageBox.Show("Username Exists");
                        UserExists = true;
                        //iDelIndex = i;
                    }
                if (UserExists == false)
                {
                    MessageBox.Show("Username that you entered does not exist in database");
                    btn_delete.Enabled = false;
                }

                sqlCon.Close();

                if (UserExists == true)
                {
                    btn_delete.Enabled = true;
                }
                //MessageBox.Show(iDelIndex.ToString());
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            sqlCon.Open();

            DialogResult dialogResult = MessageBox.Show("Removal of User with Username : " + sUsername, "Are you sure you want to Delete this user", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string SqlDelete = "DELETE FROM tbl_login WHERE Username = @User";//ND
                sqlCom = new SqlCommand(SqlDelete, sqlCon);
                sqlCom.Parameters.AddWithValue("@User", sUsername);//ND
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.ShowDialog();
            this.Close();
        }
    }
}
