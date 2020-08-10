namespace Homework1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxClassroom = new System.Windows.Forms.ComboBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxUser = new System.Windows.Forms.ComboBox();
            this.listViewDish = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeleteChosen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnChkTotalOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(164, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "便當訂購系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "班級";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "訂購人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(293, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "數量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(293, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "總價";
            // 
            // cboxClassroom
            // 
            this.cboxClassroom.BackColor = System.Drawing.Color.White;
            this.cboxClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxClassroom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxClassroom.FormattingEnabled = true;
            this.cboxClassroom.Location = new System.Drawing.Point(82, 32);
            this.cboxClassroom.MaxDropDownItems = 4;
            this.cboxClassroom.Name = "cboxClassroom";
            this.cboxClassroom.Size = new System.Drawing.Size(128, 32);
            this.cboxClassroom.TabIndex = 8;
            this.cboxClassroom.SelectedIndexChanged += new System.EventHandler(this.cboxClassroom_SelectedIndexChanged);
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(123)))), ((int)(((byte)(86)))));
            this.lblTotalMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Location = new System.Drawing.Point(362, 560);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(73, 24);
            this.lblTotalMoney.TabIndex = 11;
            this.lblTotalMoney.Text = "0元";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(322, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "加入購物車";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnAddToDB.FlatAppearance.BorderSize = 0;
            this.btnAddToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToDB.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddToDB.ForeColor = System.Drawing.Color.White;
            this.btnAddToDB.Location = new System.Drawing.Point(341, 595);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(94, 41);
            this.btnAddToDB.TabIndex = 13;
            this.btnAddToDB.Text = "確定訂購";
            this.btnAddToDB.UseVisualStyleBackColor = false;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(361, 285);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(74, 33);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(22, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "品項";
            // 
            // cboxStore
            // 
            this.cboxStore.BackColor = System.Drawing.Color.White;
            this.cboxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxStore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxStore.FormattingEnabled = true;
            this.cboxStore.Location = new System.Drawing.Point(283, 32);
            this.cboxStore.MaxDropDownItems = 4;
            this.cboxStore.Name = "cboxStore";
            this.cboxStore.Size = new System.Drawing.Size(128, 32);
            this.cboxStore.TabIndex = 20;
            this.cboxStore.SelectedIndexChanged += new System.EventHandler(this.cboxStore_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(229, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "店家";
            // 
            // cboxUser
            // 
            this.cboxUser.BackColor = System.Drawing.Color.White;
            this.cboxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxUser.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxUser.FormattingEnabled = true;
            this.cboxUser.Location = new System.Drawing.Point(82, 68);
            this.cboxUser.MaxDropDownItems = 4;
            this.cboxUser.Name = "cboxUser";
            this.cboxUser.Size = new System.Drawing.Size(128, 32);
            this.cboxUser.TabIndex = 21;
            this.cboxUser.SelectedIndexChanged += new System.EventHandler(this.cboxUser_SelectedIndexChanged);
            // 
            // listViewDish
            // 
            this.listViewDish.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewDish.HideSelection = false;
            this.listViewDish.Location = new System.Drawing.Point(20, 130);
            this.listViewDish.Name = "listViewDish";
            this.listViewDish.Size = new System.Drawing.Size(229, 235);
            this.listViewDish.TabIndex = 22;
            this.listViewDish.UseCompatibleStateImageBehavior = false;
            this.listViewDish.SelectedIndexChanged += new System.EventHandler(this.listViewDish_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(273, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeleteChosen
            // 
            this.btnDeleteChosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDeleteChosen.FlatAppearance.BorderSize = 0;
            this.btnDeleteChosen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteChosen.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteChosen.ForeColor = System.Drawing.Color.White;
            this.btnDeleteChosen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteChosen.Location = new System.Drawing.Point(141, 595);
            this.btnDeleteChosen.Name = "btnDeleteChosen";
            this.btnDeleteChosen.Size = new System.Drawing.Size(132, 41);
            this.btnDeleteChosen.TabIndex = 25;
            this.btnDeleteChosen.Text = "移出所選項目";
            this.btnDeleteChosen.UseVisualStyleBackColor = false;
            this.btnDeleteChosen.Click += new System.EventHandler(this.btnDeleteChosen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "購物車";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(20, 396);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(411, 159);
            this.listViewOrder.TabIndex = 27;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteAll.Location = new System.Drawing.Point(20, 595);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(115, 41);
            this.btnDeleteAll.TabIndex = 28;
            this.btnDeleteAll.Text = "清空購物車";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnChkTotalOrder
            // 
            this.btnChkTotalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnChkTotalOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChkTotalOrder.FlatAppearance.BorderSize = 0;
            this.btnChkTotalOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChkTotalOrder.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChkTotalOrder.ForeColor = System.Drawing.Color.White;
            this.btnChkTotalOrder.Location = new System.Drawing.Point(303, 76);
            this.btnChkTotalOrder.Name = "btnChkTotalOrder";
            this.btnChkTotalOrder.Size = new System.Drawing.Size(132, 41);
            this.btnChkTotalOrder.TabIndex = 29;
            this.btnChkTotalOrder.Text = "查看所有訂單";
            this.btnChkTotalOrder.UseVisualStyleBackColor = false;
            this.btnChkTotalOrder.Click += new System.EventHandler(this.btnChkTotalOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(303, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "日期";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(346, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 20);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "XXXX/XX/XX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(452, 651);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChkTotalOrder);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteChosen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewDish);
            this.Controls.Add(this.cboxUser);
            this.Controls.Add(this.cboxStore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAddToDB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.cboxClassroom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "便當訂購系統";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxClassroom;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxUser;
        private System.Windows.Forms.ListView listViewDish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeleteChosen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnChkTotalOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
    }
}

