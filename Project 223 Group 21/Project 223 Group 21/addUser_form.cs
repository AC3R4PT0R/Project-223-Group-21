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
    public partial class addUser_form : Form
    {
        public string sAddPassword = "";
        public string sAddUsername = "";//ND

        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;

        public addUser_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_addpass.Text = "";
            txt_addpassc.Text = "";
            txt_adduser.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPasswordCheck = "";
            int ILengthUser = 0;
            sPasswordCheck = txt_addpassc.Text;
            sAddUsername = txt_adduser.Text;
            sAddPassword = txt_addpass.Text;

            ILengthUser = sAddPassword.Length;
            /*for (int i = 0; i < ILengthUser; i++)
            {
                sAddUsername = sAddUsername + " ";
            }*/
            if (sAddPassword.Length != 9)
            {
                MessageBox.Show("Password is not 9 digits please re-enter");
            }
            else if (sAddUsername.Length > 20)
            {
                MessageBox.Show("Username cannot be longer that 20 characters");
            }
            else if (sPasswordCheck != sAddPassword)
            {
                MessageBox.Show("Password does not match please make sure the password is the same");//ND
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Addition of User", "Are you sure you want to add this user", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        sqlCon = new SqlConnection(connectStrLogin);
                        sqlCon.Open();

                        SqlCommand SQLInsert = new SqlCommand($"INSERT INTO tbl_login(Username,Password) VALUES('{sAddUsername}','{sAddPassword}')", sqlCon);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                        sqlDataAdapter.InsertCommand = SQLInsert;
                        sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                        sqlCon.Close();

                        MessageBox.Show("You have successfully added this user");

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
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.ShowDialog();
            this.Close();
        }

        private void addUser_form_Load(object sender, EventArgs e)//ND
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }
    }
}
