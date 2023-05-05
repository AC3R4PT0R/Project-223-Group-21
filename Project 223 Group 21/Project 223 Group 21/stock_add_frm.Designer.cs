
namespace Project_223_Group_21
{
    partial class stock_add_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pprice = new System.Windows.Forms.TextBox();
            this.txt_pquantity = new System.Windows.Forms.TextBox();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_psize = new System.Windows.Forms.TextBox();
            this.kitted_Galore_StaffDataSet = new Project_223_Group_21.Kitted_Galore_StaffDataSet();
            this.kittedGaloreStaffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitted_Galore_StaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kittedGaloreStaffDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(985, 524);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(155, 40);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "If at anytime stock is incorrectly entered please \r\ncontact a superviser with Lev" +
    "el 3 clearance";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(958, 436);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(977, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 44);
            this.label4.TabIndex = 20;
            this.label4.Text = "Add Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(894, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Product Price";
            // 
            // txt_pprice
            // 
            this.txt_pprice.Location = new System.Drawing.Point(1138, 281);
            this.txt_pprice.Name = "txt_pprice";
            this.txt_pprice.Size = new System.Drawing.Size(100, 20);
            this.txt_pprice.TabIndex = 18;
            // 
            // txt_pquantity
            // 
            this.txt_pquantity.Location = new System.Drawing.Point(1138, 231);
            this.txt_pquantity.Name = "txt_pquantity";
            this.txt_pquantity.Size = new System.Drawing.Size(100, 20);
            this.txt_pquantity.TabIndex = 17;
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(1138, 182);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(100, 20);
            this.txt_pname.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(894, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(894, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Name";
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(1087, 436);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(75, 23);
            this.btn_adduser.TabIndex = 13;
            this.btn_adduser.Text = "Add Stock";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(894, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Product Size";
            // 
            // txt_psize
            // 
            this.txt_psize.Location = new System.Drawing.Point(1138, 328);
            this.txt_psize.Name = "txt_psize";
            this.txt_psize.Size = new System.Drawing.Size(100, 20);
            this.txt_psize.TabIndex = 26;
            // 
            // kitted_Galore_StaffDataSet
            // 
            this.kitted_Galore_StaffDataSet.DataSetName = "Kitted_Galore_StaffDataSet";
            this.kitted_Galore_StaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kittedGaloreStaffDataSetBindingSource
            // 
            this.kittedGaloreStaffDataSetBindingSource.DataSource = this.kitted_Galore_StaffDataSet;
            this.kittedGaloreStaffDataSetBindingSource.Position = 0;
            // 
            // stock_add_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 737);
            this.Controls.Add(this.txt_psize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pprice);
            this.Controls.Add(this.txt_pquantity);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "stock_add_frm";
            this.Text = "stock_add_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stock_add_frm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitted_Galore_StaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kittedGaloreStaffDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pprice;
        private System.Windows.Forms.TextBox txt_pquantity;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_psize;
        private Kitted_Galore_StaffDataSet kitted_Galore_StaffDataSet;
        private System.Windows.Forms.BindingSource kittedGaloreStaffDataSetBindingSource;
    }
}