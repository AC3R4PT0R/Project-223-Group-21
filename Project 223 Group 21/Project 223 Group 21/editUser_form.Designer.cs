
namespace Project_223_Group_21
{
    partial class editUser_form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitted_Galore_StaffDataSet = new Project_223_Group_21.Kitted_Galore_StaffDataSet();
            this.kittedGaloreStaffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_upselect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manpass = new System.Windows.Forms.TextBox();
            this.btn_finalup = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitted_Galore_StaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kittedGaloreStaffDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            // btn_upselect
            // 
            this.btn_upselect.Location = new System.Drawing.Point(1056, 262);
            this.btn_upselect.Name = "btn_upselect";
            this.btn_upselect.Size = new System.Drawing.Size(130, 25);
            this.btn_upselect.TabIndex = 2;
            this.btn_upselect.Text = "Update selection";
            this.btn_upselect.UseVisualStyleBackColor = true;
            this.btn_upselect.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1065, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(997, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 44);
            this.label4.TabIndex = 21;
            this.label4.Text = "Update user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1011, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "New Password";
            // 
            // txt_manpass
            // 
            this.txt_manpass.Location = new System.Drawing.Point(1111, 314);
            this.txt_manpass.Name = "txt_manpass";
            this.txt_manpass.Size = new System.Drawing.Size(100, 20);
            this.txt_manpass.TabIndex = 22;
            // 
            // btn_finalup
            // 
            this.btn_finalup.Location = new System.Drawing.Point(1054, 360);
            this.btn_finalup.Name = "btn_finalup";
            this.btn_finalup.Size = new System.Drawing.Size(130, 25);
            this.btn_finalup.TabIndex = 26;
            this.btn_finalup.Text = "Update Information";
            this.btn_finalup.UseVisualStyleBackColor = true;
            this.btn_finalup.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1043, 538);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(155, 40);
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1053, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Choose User to be updated";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 193);
            this.dataGridView1.TabIndex = 29;
            // 
            // editUser_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 788);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_finalup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_manpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_upselect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editUser_form";
            this.Text = "editUser_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.editUser_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitted_Galore_StaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kittedGaloreStaffDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.BindingSource kittedGaloreStaffDataSetBindingSource;
        private Kitted_Galore_StaffDataSet kitted_Galore_StaffDataSet;
        private System.Windows.Forms.Button btn_upselect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_manpass;
        private System.Windows.Forms.Button btn_finalup;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}