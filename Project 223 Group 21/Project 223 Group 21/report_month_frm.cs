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
    public partial class report_month_frm : Form
    {
        string connectStrLogin = @"Data Source=.;Initial Catalog='Kitted Galore Staff';Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqldat;
        DataSet ds;
        SqlDataReader DataReader;

        public report_month_frm()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            /*if (hScrollBar1.Value == 1)
            {
                lbl_month.Text = "JANUARY";
            }
            else if (hScrollBar1.Value == 2)
            {
                lbl_month.Text = "FEBUARY";
            }
            else if (hScrollBar1.Value == 3)
            {
                lbl_month.Text = "MARCH";
            }
            else if (hScrollBar1.Value == 4)
            {
                lbl_month.Text = "APRIL";
            }
            else if (hScrollBar1.Value == 5)
            {
                lbl_month.Text = "MAY";
            }
            else if (hScrollBar1.Value == 6)
            {
                lbl_month.Text = "JUNE";
            }
            else if (hScrollBar1.Value == 7)
            {
                lbl_month.Text = "JULY";
            }
            else if (hScrollBar1.Value == 8)
            {
                lbl_month.Text = "AUGUST";
            }
            else if (hScrollBar1.Value == 9)
            {
                lbl_month.Text = "SEPTEMBER";
            }
            else if (hScrollBar1.Value == 10)
            {
                lbl_month.Text = "OCTOBER";
            }
            else if (hScrollBar1.Value == 11)
            {
                lbl_month.Text = "NOVEMBER";
            }
            else if (hScrollBar1.Value == 12)
            {
                lbl_month.Text = "DECEMBER";
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int icountusers = 0;

            try
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                string sql = @"SELECT * FROM tbl_orders WHERE DateDispatched BETWEEN '" + dateTimePicker1.Value.ToString() + "' and'" + dateTimePicker2.Value.ToString();
                
                SqlCommand command = new SqlCommand(sql, sqlCon);

                adapter.SelectCommand = command;
                adapter.Fill(ds, "Sales");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Sales";

                sqlCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

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

            string sqlDisplay = "SELECT * FROM tbl_orders";

            sqlCom = new SqlCommand(sqlDisplay, sqlCon);
            sqldat.SelectCommand = sqlCom;
            sqldat.Fill(ds, "SourceTable");//ND

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            string sqllogin = "SELECT * FROM tbl_orders";
            sqlCom = new SqlCommand(sqllogin, sqlCon);
            DataReader = sqlCom.ExecuteReader();

            string[] ArrSales = new string[20];

            while (DataReader.Read())
            {
                ArrSales[icountusers] = DataReader.GetValue(4).ToString();
                icountusers++;
            }
            double dTotalSalesThusFar = 0.0;
            for (int i = 0; i < icountusers; i++) 
            {
                dTotalSalesThusFar = dTotalSalesThusFar + double.Parse(ArrSales[i].ToString());
            }
            
            MessageBox.Show("R " + dTotalSalesThusFar.ToString() +"of sale were made between " + dateTimePicker1.Value.ToString() + " and " + dateTimePicker1.Value.ToString());
            sqlCon.Close();
        }

        private void report_month_frm_Load(object sender, EventArgs e)
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
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Selection_frm fs = new Selection_frm();
            fs.ShowDialog();
            this.Close();
        }
    }
}
