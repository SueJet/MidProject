namespace Homework1
{
    partial class Pwd
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
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnChkPwd = new System.Windows.Forms.Button();
            this.btnNewPwd = new System.Windows.Forms.Button();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblNewPwd2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPwd2 = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPwd.Location = new System.Drawing.Point(43, 42);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(48, 24);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "密碼";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPwd.Location = new System.Drawing.Point(98, 39);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(235, 33);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // btnChkPwd
            // 
            this.btnChkPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnChkPwd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChkPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChkPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChkPwd.ForeColor = System.Drawing.Color.White;
            this.btnChkPwd.Location = new System.Drawing.Point(345, 36);
            this.btnChkPwd.Name = "btnChkPwd";
            this.btnChkPwd.Size = new System.Drawing.Size(90, 36);
            this.btnChkPwd.TabIndex = 2;
            this.btnChkPwd.Text = "登入";
            this.btnChkPwd.UseVisualStyleBackColor = false;
            this.btnChkPwd.Click += new System.EventHandler(this.btnChkPwd_Click);
            // 
            // btnNewPwd
            // 
            this.btnNewPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnNewPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewPwd.ForeColor = System.Drawing.Color.White;
            this.btnNewPwd.Location = new System.Drawing.Point(348, 71);
            this.btnNewPwd.Name = "btnNewPwd";
            this.btnNewPwd.Size = new System.Drawing.Size(90, 36);
            this.btnNewPwd.TabIndex = 3;
            this.btnNewPwd.Text = "確認";
            this.btnNewPwd.UseVisualStyleBackColor = false;
            this.btnNewPwd.Click += new System.EventHandler(this.btnNewPwd_Click);
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNewPwd.Location = new System.Drawing.Point(24, 36);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(67, 24);
            this.lblNewPwd.TabIndex = 1;
            this.lblNewPwd.Text = "新密碼";
            // 
            // lblNewPwd2
            // 
            this.lblNewPwd2.AutoSize = true;
            this.lblNewPwd2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNewPwd2.Location = new System.Drawing.Point(5, 77);
            this.lblNewPwd2.Name = "lblNewPwd2";
            this.lblNewPwd2.Size = new System.Drawing.Size(86, 24);
            this.lblNewPwd2.TabIndex = 0;
            this.lblNewPwd2.Text = "確認密碼";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNewPwd);
            this.groupBox1.Controls.Add(this.txtNewPwd2);
            this.groupBox1.Controls.Add(this.txtNewPwd);
            this.groupBox1.Controls.Add(this.lblNewPwd);
            this.groupBox1.Controls.Add(this.lblNewPwd2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(2, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "建立新密碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "請輸入六位數字";
            // 
            // txtNewPwd2
            // 
            this.txtNewPwd2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewPwd2.Location = new System.Drawing.Point(98, 74);
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.PasswordChar = '*';
            this.txtNewPwd2.Size = new System.Drawing.Size(235, 33);
            this.txtNewPwd2.TabIndex = 2;
            this.txtNewPwd2.TextChanged += new System.EventHandler(this.txtNewPwd2_TextChanged);
            this.txtNewPwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPwd2_KeyPress);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewPwd.Location = new System.Drawing.Point(98, 33);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(235, 33);
            this.txtNewPwd.TabIndex = 1;
            this.txtNewPwd.TextChanged += new System.EventHandler(this.txtNewPwd_TextChanged);
            this.txtNewPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPwd_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChkPwd);
            this.groupBox2.Controls.Add(this.txtPwd);
            this.groupBox2.Controls.Add(this.lblPwd);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(2, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 106);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "請輸入密碼";
            // 
            // Pwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(481, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pwd";
            this.Text = "Pwd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pwd_FormClosing);
            this.Load += new System.EventHandler(this.Pwd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnChkPwd;
        private System.Windows.Forms.Button btnNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblNewPwd2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNewPwd2;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label1;
    }
}