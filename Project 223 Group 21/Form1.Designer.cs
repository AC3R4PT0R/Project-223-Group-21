
namespace Project_223_Group_21
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_rm = new System.Windows.Forms.CheckBox();
            this.cbx_show = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = " Kitted Galore  Management System";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(394, 202);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 3;
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(394, 265);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(100, 20);
            this.text_pass.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(168, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 150);
            this.panel1.TabIndex = 5;
            // 
            // cbx_rm
            // 
            this.cbx_rm.AutoSize = true;
            this.cbx_rm.Location = new System.Drawing.Point(362, 303);
            this.cbx_rm.Name = "cbx_rm";
            this.cbx_rm.Size = new System.Drawing.Size(94, 17);
            this.cbx_rm.TabIndex = 6;
            this.cbx_rm.Text = "Remember me";
            this.cbx_rm.UseVisualStyleBackColor = true;
            // 
            // cbx_show
            // 
            this.cbx_show.AutoSize = true;
            this.cbx_show.Location = new System.Drawing.Point(540, 235);
            this.cbx_show.Name = "cbx_show";
            this.cbx_show.Size = new System.Drawing.Size(102, 17);
            this.cbx_show.TabIndex = 7;
            this.cbx_show.Text = "Show Password";
            this.cbx_show.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(305, 369);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(432, 369);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 639);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cbx_show);
            this.Controls.Add(this.cbx_rm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbx_rm;
        private System.Windows.Forms.CheckBox cbx_show;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
    }
}

