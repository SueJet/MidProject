namespace Homework1
{
    partial class StartForm
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
            this.btnManager = new System.Windows.Forms.Button();
            this.btnStdOrder = new System.Windows.Forms.Button();
            this.btnStdHead = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎來到訂便當系統";
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Location = new System.Drawing.Point(107, 138);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(155, 60);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "學員與商家管理";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnStdOrder
            // 
            this.btnStdOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdOrder.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStdOrder.ForeColor = System.Drawing.Color.White;
            this.btnStdOrder.Location = new System.Drawing.Point(107, 326);
            this.btnStdOrder.Name = "btnStdOrder";
            this.btnStdOrder.Size = new System.Drawing.Size(155, 60);
            this.btnStdOrder.TabIndex = 2;
            this.btnStdOrder.Text = "我要點餐!";
            this.btnStdOrder.UseVisualStyleBackColor = false;
            this.btnStdOrder.Click += new System.EventHandler(this.btnStdOrder_Click);
            // 
            // btnStdHead
            // 
            this.btnStdHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStdHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdHead.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStdHead.ForeColor = System.Drawing.Color.White;
            this.btnStdHead.Location = new System.Drawing.Point(107, 232);
            this.btnStdHead.Name = "btnStdHead";
            this.btnStdHead.Size = new System.Drawing.Size(155, 60);
            this.btnStdHead.TabIndex = 3;
            this.btnStdHead.Text = "值日生";
            this.btnStdHead.UseVisualStyleBackColor = false;
            this.btnStdHead.Click += new System.EventHandler(this.btnStdHead_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.lblHead.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHead.Location = new System.Drawing.Point(82, 82);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(67, 24);
            this.lblHead.TabIndex = 4;
            this.lblHead.Text = "值日生";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(263, -1);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 20);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "XXXX/XX/XX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(220, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "日期";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(368, 462);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnStdHead);
            this.Controls.Add(this.btnStdOrder);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "訂便當系統";
            this.Activated += new System.EventHandler(this.StartForm_Activated);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnStdOrder;
        private System.Windows.Forms.Button btnStdHead;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
    }
}