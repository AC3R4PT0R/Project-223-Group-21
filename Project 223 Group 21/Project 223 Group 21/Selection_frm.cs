using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_223_Group_21
{
    public partial class Selection_frm : Form
    {
        public Selection_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_inu.Show();
            //btn_inu.Enabled = true;
            btn_deu.Show();
            //btn_deu.Enabled = true;
            btn_eui.Show();
            //btn_eui.Enabled = true;
            btn_om.Hide();
            btn_report.Hide();
            btn_sm.Hide();
            btn_um.Hide();
            btn_back.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Selection_frm_Load(object sender, EventArgs e)
        {
            btn_inu.Hide();
            btn_deu.Hide();
            btn_eui.Hide();
            btn_back.Hide();
            btn_adds.Hide();
            btn_edits.Hide();
            btn_removes.Hide();
            btn_checko.Hide();
            btn_updateo.Hide();
            btn_reportm.Hide();
            btn_reports.Hide();
            btn_stockv.Hide();


            int iAccesslevel = frm_login.fLevel;

            if (iAccesslevel == 1)
            {
                btn_removes.Enabled = false;
                btn_edits.Enabled = false;
                btn_inu.Enabled = false;
                btn_deu.Enabled = false;
                btn_eui.Enabled = false;
                btn_updateo.Enabled = false;
                btn_reportm.Enabled = false;
                btn_reports.Enabled = false;
            }
            else if (iAccesslevel == 2)
            {
                btn_removes.Enabled = false;
                btn_edits.Enabled = false;
                btn_inu.Enabled = false;
                btn_deu.Enabled = false;
                btn_eui.Enabled = false;
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            btn_inu.Hide();
            btn_deu.Hide();
            btn_eui.Hide();
            btn_adds.Hide();
            btn_removes.Hide();
            btn_edits.Hide();
            btn_stockv.Hide();
            btn_reportm.Hide();
            btn_reports.Hide();
            btn_checko.Hide();
            btn_updateo.Hide();
            btn_om.Show();
            btn_report.Show();
            btn_sm.Show();
            btn_um.Show();
            btn_back.Hide();
        }

        private void btn_sm_Click(object sender, EventArgs e)
        {
            btn_adds.Show();
            btn_removes.Show();
            btn_edits.Show();
            btn_stockv.Show();
            btn_um.Hide();
            btn_sm.Hide();
            btn_report.Hide();
            btn_om.Hide();
            btn_back.Show();
        }

        private void btn_om_Click(object sender, EventArgs e)
        {
            btn_um.Hide();
            btn_sm.Hide();
            btn_report.Hide();
            btn_om.Hide();
            btn_checko.Show();
            btn_updateo.Show();
            btn_back.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            btn_um.Hide();
            btn_sm.Hide();
            btn_report.Hide();
            btn_om.Hide();
            btn_reportm.Show();
            btn_reports.Show();
            btn_back.Show();
        }

        private void btn_inu_Click(object sender, EventArgs e)
        {
            addUser_form f2 = new addUser_form();
            f2.ShowDialog();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_deu_Click(object sender, EventArgs e)
        {
            deleteUser_form fd = new deleteUser_form();
            fd.ShowDialog();
            this.Close();
        }

        private void btn_eui_Click(object sender, EventArgs e)
        {
            editUser_form fe = new editUser_form();
            fe.ShowDialog();
            this.Close();
        }

        private void btn_adds_Click(object sender, EventArgs e)
        {
            stock_add_frm fst = new stock_add_frm();
            fst.ShowDialog();
            this.Close();
        }

        private void btn_removes_Click(object sender, EventArgs e)
        {
            stock_delete_frm fsd = new stock_delete_frm();
            fsd.ShowDialog();
            this.Close();
        }

        private void btn_edits_Click(object sender, EventArgs e)
        {
            stock_edit_frm fse = new stock_edit_frm();
            fse.ShowDialog();
            this.Close();
        }

        private void btn_stockv_Click(object sender, EventArgs e)
        {
            stock_viewall_frm fse = new stock_viewall_frm();
            fse.ShowDialog();
            this.Close();
        }

        private void btn_checko_Click(object sender, EventArgs e)
        {
            orders_check_frm fco = new orders_check_frm();
            fco.ShowDialog();
            this.Close();
        }

        private void btn_updateo_Click(object sender, EventArgs e)
        {
            orders_update_frm fco = new orders_update_frm();
            fco.ShowDialog();
            this.Close();
        }

        private void btn_reportm_Click(object sender, EventArgs e)
        {
            report_month_frm frm = new report_month_frm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
