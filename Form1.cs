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
using System.Net;

namespace Project_223_Group_21
{
    public partial class Form1 : Form
    {
        public bool BRemeberUser = false;
        public string sRememberUser = "";
        public string sRememberPassword = "";
        public Form1()
        {
            InitializeComponent();
        }
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader DataReader;

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            txt_pass.Text = "";
            txt_pass.PasswordChar = '*';
            txt_pass.MaxLength = 9;
            pictureBox1.Image = Project_223_Group_21.Properties.Resources.help_icon;

            sqlCon = new SqlConnection(connectStrLogin);
            sqlCon.Open();
            sqlCon.Close();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_pass.Clear();
            cbx_rm.Checked = false;
        }

        private void cbx_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_show.Checked == true)
            {
                txt_pass.PasswordChar = '\0';
            }
            else {
                txt_pass.PasswordChar = '*';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int icountusers = 0;
            int icountindex = 0;
            string sUsername, sPassword = "";

            if (BRemeberUser == true)
            {
                txt_user.Text = sRememberUser;
                txt_pass.Text = sRememberPassword;
                BRemeberUser = false;
            }

            sUsername = txt_user.Text;
            sPassword = txt_pass.Text;

            sqlCon.Open();

            if (txt_user.Text == "")
            {
                MessageBox.Show("Error please enter username");
            }
            else if (txt_pass.Text == "")
            {
                MessageBox.Show("Error please enter Password");
            }
            else
            {
                string sqllogin = "SELECT * FROM tbl_login";
                sqlCom = new SqlCommand(sqllogin, sqlCon);
                DataReader = sqlCom.ExecuteReader();

                string[] Arrusers = new string[20];
                string[] Arrpassword = new string[20];
                string[] Arrlevel = new string[20];

                while (DataReader.Read())
                {
                    Arrusers[icountusers] = DataReader.GetValue(0).ToString();
                    Arrpassword[icountusers] = DataReader.GetValue(1).ToString();
                    Arrlevel[icountusers] = DataReader.GetValue(2).ToString();
                    icountusers++;
                }

                /*for (int i = 0; i < icountusers; i++)
                  {
                      listBox1.Items.Add(Arrusers[i]);
                      listBox1.Items.Add(Arrpassword[i]);
                      listBox1.Items.Add(Arrlevel[i]);
                  }*/

                if (cbx_rm.Checked == true)
                {
                    BRemeberUser = true;
                    sRememberUser = txt_user.Text;
                    sPassword = txt_pass.Text;
                }

                for (int j = 0; j < icountusers; j++)
                {
                    if (Arrusers[j] == sUsername)
                    {
                        icountindex = j;
                    }
                }
                if (Arrpassword[icountindex] == sPassword)
                {
                    MessageBox.Show("Username : " + sUsername + "Password : " + sPassword + "Confirmed");
                }
                else
                {
                    MessageBox.Show("Username and or Password is incorrect");
                }
            }


            sqlCon.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = true;
            label10.Text = "Double click on the help icon to display help,\nSingle click to remove";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            label4.Text = "Below is the area in which you should enter your designated Username\n                                                    |\n                                                    |\n                                                    |\n                                                    v";
            label5.Text = "                                ^\n                                |\nAbove is the area that you enter you Password connected to an existing Username";
            label9.Text = "<---- Click here to see your Password without the protection mask";
            label8.Text = "Click here to save your Username and Password when you return to the main screen ---->";
            label7.Text = "<---- After entering your Username and Password click here to login and go to the next form";
            label6.Text = "                   ^\n                   |\n                   |\n                   |\n Click here to clear all data for the textboxes";
        }
    }
}
