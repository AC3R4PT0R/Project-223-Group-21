using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//ND
using System.Data.SqlClient;

namespace Project_223_Group_21
{
    public partial class editUser_form : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqldat;
        DataSet ds;
        SqlDataReader DataReader;

        public string[] ArrEditUsers = new string[20];
        public int iCountIndex = 0;
        public int icountusers = 0;

        public editUser_form()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.ShowDialog();
            this.Close();
        }

        private void editUser_form_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            txt_manpass.Enabled = false;
            //txt_manuser.Enabled = false;

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

            string sqlDisplay = "SELECT * FROM tbl_login";

            sqlCom = new SqlCommand(sqlDisplay, sqlCon);
            sqldat.SelectCommand = sqlCom;
            sqldat.Fill(ds, "SourceTable");//ND

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            string sqllogin = "SELECT * FROM tbl_login";
            sqlCom = new SqlCommand(sqllogin, sqlCon);
            DataReader = sqlCom.ExecuteReader();

            while (DataReader.Read())
            {
                comboBox1.Items.Add(DataReader.GetValue(0).ToString());
            }

            sqlCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();//ND
            fs.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedItem.ToString() + "$$");
            string sCompare = comboBox1.SelectedItem.ToString();
            iCountIndex = 0;
            sqlCon.Open();

            string sqllogin = "SELECT * FROM tbl_login";
            sqlCom = new SqlCommand(sqllogin, sqlCon);
            DataReader = sqlCom.ExecuteReader();

            while (DataReader.Read())
            {
                ArrEditUsers[iCountIndex] = DataReader.GetValue(0).ToString();
                iCountIndex++;
            }

            /*for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(ArrEditUsers[iCountIndex]);//ND
            }*/

            /*for (int i = 0; i < iCountIndex; i++)
            {
                if (sCompare == ArrEditUsers[iCountIndex])
                {
                    MessageBox.Show("You have selected User " + comboBox1.SelectedItem.ToString() + " to be edited");
                    txt_manuser.Text = ArrEditUsers[i];
                    iCountIndex++;
                }
                else { iCountIndex++; }
            }*/
            //txt_manuser.Enabled = true;
            txt_manpass.Enabled = true;
            dataGridView1.Visible = false;
            sqlCon.Close();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sPassword = "";
            sPassword = txt_manpass.Text;

            sqlCon.Open();
            DialogResult dialogResult = MessageBox.Show("Update of User with Username : " + comboBox1.SelectedItem.ToString(), "Are you sure you want to Update this user", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlEditCom = "UPDATE tbl_login SET Password = @password WHERE Username = @user";
                sqlCom = new SqlCommand(sqlEditCom, sqlCon);
                sqlCom.Parameters.AddWithValue("@password", sPassword);
                sqlCom.Parameters.AddWithValue("@user", comboBox1.SelectedItem.ToString());
                sqlCom.ExecuteNonQuery();

                sqlCon.Close();
                MessageBox.Show("User " + comboBox1.SelectedItem.ToString() + "was successfully updated");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            sqlCon.Close();
        }
    }

}
