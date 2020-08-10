namespace Homework1
{
    partial class Manager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxClassroomEdit = new System.Windows.Forms.ComboBox();
            this.btnStdDelete = new System.Windows.Forms.Button();
            this.btnStdAdd = new System.Windows.Forms.Button();
            this.lblStdID = new System.Windows.Forms.Label();
            this.btnStdSaveChange = new System.Windows.Forms.Button();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewStd = new System.Windows.Forms.ListView();
            this.cboxClassroom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStoreDelete = new System.Windows.Forms.Button();
            this.btnStoreAdd = new System.Windows.Forms.Button();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.btnStoreSaveChange = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewStore = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDishSaveChangeCancel = new System.Windows.Forms.Button();
            this.btnEditPic = new System.Windows.Forms.Button();
            this.btnDishSaveChange = new System.Windows.Forms.Button();
            this.btnDishDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDishAddCancel = new System.Windows.Forms.Button();
            this.btnNewPic = new System.Windows.Forms.Button();
            this.btnDishAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDishID = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listViewDish = new System.Windows.Forms.ListView();
            this.cboxStore = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNewPwd = new System.Windows.Forms.Button();
            this.txtNewPwd2 = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblNewPwd2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 412);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.tabPage1.Controls.Add(this.cboxClassroomEdit);
            this.tabPage1.Controls.Add(this.btnStdDelete);
            this.tabPage1.Controls.Add(this.btnStdAdd);
            this.tabPage1.Controls.Add(this.lblStdID);
            this.tabPage1.Controls.Add(this.btnStdSaveChange);
            this.tabPage1.Controls.Add(this.txtStdName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listViewStd);
            this.tabPage1.Controls.Add(this.cboxClassroom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "學生管理";
            // 
            // cboxClassroomEdit
            // 
            this.cboxClassroomEdit.BackColor = System.Drawing.Color.White;
            this.cboxClassroomEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClassroomEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxClassroomEdit.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.cboxClassroomEdit.FormattingEnabled = true;
            this.cboxClassroomEdit.Location = new System.Drawing.Point(481, 198);
            this.cboxClassroomEdit.MaxDropDownItems = 4;
            this.cboxClassroomEdit.Name = "cboxClassroomEdit";
            this.cboxClassroomEdit.Size = new System.Drawing.Size(132, 32);
            this.cboxClassroomEdit.TabIndex = 21;
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStdDelete.ForeColor = System.Drawing.Color.White;
            this.btnStdDelete.Location = new System.Drawing.Point(580, 277);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(99, 46);
            this.btnStdDelete.TabIndex = 20;
            this.btnStdDelete.Text = "刪除";
            this.btnStdDelete.UseVisualStyleBackColor = false;
            this.btnStdDelete.Click += new System.EventHandler(this.btnStdDelete_Click);
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStdAdd.ForeColor = System.Drawing.Color.White;
            this.btnStdAdd.Location = new System.Drawing.Point(377, 277);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(99, 46);
            this.btnStdAdd.TabIndex = 20;
            this.btnStdAdd.Text = "新增";
            this.btnStdAdd.UseVisualStyleBackColor = false;
            this.btnStdAdd.Click += new System.EventHandler(this.btnStdAdd_Click);
            // 
            // lblStdID
            // 
            this.lblStdID.BackColor = System.Drawing.Color.Transparent;
            this.lblStdID.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.lblStdID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStdID.Location = new System.Drawing.Point(481, 82);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(132, 24);
            this.lblStdID.TabIndex = 19;
            this.lblStdID.Text = "0";
            this.lblStdID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStdSaveChange
            // 
            this.btnStdSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStdSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdSaveChange.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStdSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnStdSaveChange.Location = new System.Drawing.Point(477, 277);
            this.btnStdSaveChange.Name = "btnStdSaveChange";
            this.btnStdSaveChange.Size = new System.Drawing.Size(102, 46);
            this.btnStdSaveChange.TabIndex = 18;
            this.btnStdSaveChange.Text = "儲存修改";
            this.btnStdSaveChange.UseVisualStyleBackColor = false;
            this.btnStdSaveChange.Click += new System.EventHandler(this.btnStdSaveChange_Click);
            // 
            // txtStdName
            // 
            this.txtStdName.Location = new System.Drawing.Point(481, 135);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(132, 33);
            this.txtStdName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(418, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "班級";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(418, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(407, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "StdID";
            // 
            // listViewStd
            // 
            this.listViewStd.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewStd.BackColor = System.Drawing.SystemColors.Window;
            this.listViewStd.FullRowSelect = true;
            this.listViewStd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStd.HideSelection = false;
            this.listViewStd.LabelWrap = false;
            this.listViewStd.Location = new System.Drawing.Point(11, 49);
            this.listViewStd.Margin = new System.Windows.Forms.Padding(0);
            this.listViewStd.MultiSelect = false;
            this.listViewStd.Name = "listViewStd";
            this.listViewStd.Size = new System.Drawing.Size(312, 324);
            this.listViewStd.TabIndex = 12;
            this.listViewStd.UseCompatibleStateImageBehavior = false;
            this.listViewStd.View = System.Windows.Forms.View.Details;
            this.listViewStd.SelectedIndexChanged += new System.EventHandler(this.listViewStd_SelectedIndexChanged);
            // 
            // cboxClassroom
            // 
            this.cboxClassroom.BackColor = System.Drawing.Color.White;
            this.cboxClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxClassroom.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.cboxClassroom.FormattingEnabled = true;
            this.cboxClassroom.Location = new System.Drawing.Point(61, 11);
            this.cboxClassroom.MaxDropDownItems = 4;
            this.cboxClassroom.Name = "cboxClassroom";
            this.cboxClassroom.Size = new System.Drawing.Size(96, 32);
            this.cboxClassroom.TabIndex = 11;
            this.cboxClassroom.SelectedIndexChanged += new System.EventHandler(this.cboxClassroom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "班級";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnStoreDelete);
            this.tabPage2.Controls.Add(this.btnStoreAdd);
            this.tabPage2.Controls.Add(this.lblStoreID);
            this.tabPage2.Controls.Add(this.btnStoreSaveChange);
            this.tabPage2.Controls.Add(this.txtTel);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.txtStoreName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listViewStore);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "店家管理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(267, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "電話";
            // 
            // btnStoreDelete
            // 
            this.btnStoreDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStoreDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStoreDelete.ForeColor = System.Drawing.Color.White;
            this.btnStoreDelete.Location = new System.Drawing.Point(511, 302);
            this.btnStoreDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnStoreDelete.Name = "btnStoreDelete";
            this.btnStoreDelete.Size = new System.Drawing.Size(94, 46);
            this.btnStoreDelete.TabIndex = 31;
            this.btnStoreDelete.Text = "刪除";
            this.btnStoreDelete.UseVisualStyleBackColor = false;
            this.btnStoreDelete.Click += new System.EventHandler(this.btnStoreDelete_Click);
            // 
            // btnStoreAdd
            // 
            this.btnStoreAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStoreAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStoreAdd.ForeColor = System.Drawing.Color.White;
            this.btnStoreAdd.Location = new System.Drawing.Point(311, 302);
            this.btnStoreAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnStoreAdd.Name = "btnStoreAdd";
            this.btnStoreAdd.Size = new System.Drawing.Size(94, 46);
            this.btnStoreAdd.TabIndex = 32;
            this.btnStoreAdd.Text = "新增";
            this.btnStoreAdd.UseVisualStyleBackColor = false;
            this.btnStoreAdd.Click += new System.EventHandler(this.btnStoreAdd_Click);
            // 
            // lblStoreID
            // 
            this.lblStoreID.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreID.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.lblStoreID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStoreID.Location = new System.Drawing.Point(342, 39);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(320, 24);
            this.lblStoreID.TabIndex = 30;
            this.lblStoreID.Text = "0";
            this.lblStoreID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStoreSaveChange
            // 
            this.btnStoreSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnStoreSaveChange.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStoreSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnStoreSaveChange.Location = new System.Drawing.Point(411, 302);
            this.btnStoreSaveChange.Margin = new System.Windows.Forms.Padding(0);
            this.btnStoreSaveChange.Name = "btnStoreSaveChange";
            this.btnStoreSaveChange.Size = new System.Drawing.Size(94, 46);
            this.btnStoreSaveChange.TabIndex = 29;
            this.btnStoreSaveChange.Text = "儲存修改";
            this.btnStoreSaveChange.UseVisualStyleBackColor = false;
            this.btnStoreSaveChange.Click += new System.EventHandler(this.btnStoreSaveChange_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(342, 243);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(320, 33);
            this.txtTel.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(342, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(320, 33);
            this.txtAddress.TabIndex = 28;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(342, 105);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(135, 33);
            this.txtStoreName.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(267, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(267, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "店名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(238, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "StoreID";
            // 
            // listViewStore
            // 
            this.listViewStore.BackColor = System.Drawing.SystemColors.Window;
            this.listViewStore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewStore.HideSelection = false;
            this.listViewStore.Location = new System.Drawing.Point(11, 16);
            this.listViewStore.Name = "listViewStore";
            this.listViewStore.Size = new System.Drawing.Size(171, 358);
            this.listViewStore.TabIndex = 24;
            this.listViewStore.UseCompatibleStateImageBehavior = false;
            this.listViewStore.SelectedIndexChanged += new System.EventHandler(this.listViewStore_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.btnDishDelete);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.lblDishID);
            this.tabPage3.Controls.Add(this.txtPrice);
            this.tabPage3.Controls.Add(this.txtDishName);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.listViewDish);
            this.tabPage3.Controls.Add(this.cboxStore);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(728, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "菜色管理";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.groupBox2.Controls.Add(this.btnDishSaveChangeCancel);
            this.groupBox2.Controls.Add(this.btnEditPic);
            this.groupBox2.Controls.Add(this.btnDishSaveChange);
            this.groupBox2.Location = new System.Drawing.Point(454, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 212);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // btnDishSaveChangeCancel
            // 
            this.btnDishSaveChangeCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDishSaveChangeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishSaveChangeCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDishSaveChangeCancel.ForeColor = System.Drawing.Color.White;
            this.btnDishSaveChangeCancel.Location = new System.Drawing.Point(9, 156);
            this.btnDishSaveChangeCancel.Name = "btnDishSaveChangeCancel";
            this.btnDishSaveChangeCancel.Size = new System.Drawing.Size(146, 46);
            this.btnDishSaveChangeCancel.TabIndex = 36;
            this.btnDishSaveChangeCancel.Text = "取消所選照片";
            this.btnDishSaveChangeCancel.UseVisualStyleBackColor = false;
            this.btnDishSaveChangeCancel.EnabledChanged += new System.EventHandler(this.btnDishSaveChangeCancel_EnabledChanged);
            this.btnDishSaveChangeCancel.Click += new System.EventHandler(this.btnDishSaveChangeCancel_Click);
            this.btnDishSaveChangeCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDishSaveChangeCancel_Paint);
            // 
            // btnEditPic
            // 
            this.btnEditPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnEditPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPic.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditPic.ForeColor = System.Drawing.Color.White;
            this.btnEditPic.Location = new System.Drawing.Point(9, 31);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.Size = new System.Drawing.Size(146, 46);
            this.btnEditPic.TabIndex = 35;
            this.btnEditPic.Text = "修改便當照片";
            this.btnEditPic.UseVisualStyleBackColor = false;
            this.btnEditPic.EnabledChanged += new System.EventHandler(this.btnEditPic_EnabledChanged);
            this.btnEditPic.Click += new System.EventHandler(this.btnEditPic_Click);
            this.btnEditPic.Paint += new System.Windows.Forms.PaintEventHandler(this.btnEditPic_Paint);
            // 
            // btnDishSaveChange
            // 
            this.btnDishSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDishSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishSaveChange.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDishSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnDishSaveChange.Location = new System.Drawing.Point(32, 92);
            this.btnDishSaveChange.Name = "btnDishSaveChange";
            this.btnDishSaveChange.Size = new System.Drawing.Size(96, 46);
            this.btnDishSaveChange.TabIndex = 29;
            this.btnDishSaveChange.Text = "儲存修改";
            this.btnDishSaveChange.UseVisualStyleBackColor = false;
            this.btnDishSaveChange.EnabledChanged += new System.EventHandler(this.btnDishSaveChange_EnabledChanged);
            this.btnDishSaveChange.Click += new System.EventHandler(this.btnDishSaveChange_Click);
            this.btnDishSaveChange.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDishSaveChange_Paint);
            // 
            // btnDishDelete
            // 
            this.btnDishDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDishDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDishDelete.ForeColor = System.Drawing.Color.White;
            this.btnDishDelete.Location = new System.Drawing.Point(626, 254);
            this.btnDishDelete.Name = "btnDishDelete";
            this.btnDishDelete.Size = new System.Drawing.Size(94, 46);
            this.btnDishDelete.TabIndex = 31;
            this.btnDishDelete.Text = "刪除";
            this.btnDishDelete.UseVisualStyleBackColor = false;
            this.btnDishDelete.EnabledChanged += new System.EventHandler(this.btnDishDelete_EnabledChanged);
            this.btnDishDelete.Click += new System.EventHandler(this.btnDishDelete_Click);
            this.btnDishDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDishDelete_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.groupBox1.Controls.Add(this.btnDishAddCancel);
            this.groupBox1.Controls.Add(this.btnNewPic);
            this.groupBox1.Controls.Add(this.btnDishAdd);
            this.groupBox1.Location = new System.Drawing.Point(286, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 212);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增";
            // 
            // btnDishAddCancel
            // 
            this.btnDishAddCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDishAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishAddCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDishAddCancel.ForeColor = System.Drawing.Color.White;
            this.btnDishAddCancel.Location = new System.Drawing.Point(30, 157);
            this.btnDishAddCancel.Name = "btnDishAddCancel";
            this.btnDishAddCancel.Size = new System.Drawing.Size(99, 46);
            this.btnDishAddCancel.TabIndex = 35;
            this.btnDishAddCancel.Text = "取消新增";
            this.btnDishAddCancel.UseVisualStyleBackColor = false;
            this.btnDishAddCancel.EnabledChanged += new System.EventHandler(this.btnDishAddCancel_EnabledChanged);
            this.btnDishAddCancel.Click += new System.EventHandler(this.btnDishAddCancel_Click);
            this.btnDishAddCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDishAddCancel_Paint);
            // 
            // btnNewPic
            // 
            this.btnNewPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnNewPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPic.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewPic.ForeColor = System.Drawing.Color.White;
            this.btnNewPic.Location = new System.Drawing.Point(10, 32);
            this.btnNewPic.Name = "btnNewPic";
            this.btnNewPic.Size = new System.Drawing.Size(146, 46);
            this.btnNewPic.TabIndex = 34;
            this.btnNewPic.Text = "新增便當照片";
            this.btnNewPic.UseVisualStyleBackColor = false;
            this.btnNewPic.EnabledChanged += new System.EventHandler(this.btnNewPic_EnabledChanged);
            this.btnNewPic.Click += new System.EventHandler(this.btnNewPic_Click);
            this.btnNewPic.Paint += new System.Windows.Forms.PaintEventHandler(this.btnNewPic_Paint);
            // 
            // btnDishAdd
            // 
            this.btnDishAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDishAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDishAdd.ForeColor = System.Drawing.Color.White;
            this.btnDishAdd.Location = new System.Drawing.Point(30, 93);
            this.btnDishAdd.Name = "btnDishAdd";
            this.btnDishAdd.Size = new System.Drawing.Size(99, 46);
            this.btnDishAdd.TabIndex = 32;
            this.btnDishAdd.Text = "新增";
            this.btnDishAdd.UseVisualStyleBackColor = false;
            this.btnDishAdd.EnabledChanged += new System.EventHandler(this.btnDishAdd_EnabledChanged);
            this.btnDishAdd.Click += new System.EventHandler(this.btnDishAdd_Click);
            this.btnDishAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDishAdd_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblDishID
            // 
            this.lblDishID.BackColor = System.Drawing.Color.Transparent;
            this.lblDishID.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.lblDishID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDishID.Location = new System.Drawing.Point(548, 7);
            this.lblDishID.Name = "lblDishID";
            this.lblDishID.Size = new System.Drawing.Size(155, 24);
            this.lblDishID.TabIndex = 30;
            this.lblDishID.Text = "0";
            this.lblDishID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(552, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 33);
            this.txtPrice.TabIndex = 28;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(552, 60);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(151, 33);
            this.txtDishName.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(494, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "價格";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(456, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "便當名稱";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(473, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "DishID";
            // 
            // listViewDish
            // 
            this.listViewDish.BackColor = System.Drawing.SystemColors.Window;
            this.listViewDish.FullRowSelect = true;
            this.listViewDish.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDish.HideSelection = false;
            this.listViewDish.Location = new System.Drawing.Point(14, 50);
            this.listViewDish.Name = "listViewDish";
            this.listViewDish.Size = new System.Drawing.Size(266, 324);
            this.listViewDish.TabIndex = 24;
            this.listViewDish.UseCompatibleStateImageBehavior = false;
            this.listViewDish.SelectedIndexChanged += new System.EventHandler(this.listViewDish_SelectedIndexChanged);
            // 
            // cboxStore
            // 
            this.cboxStore.BackColor = System.Drawing.Color.White;
            this.cboxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxStore.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.cboxStore.FormattingEnabled = true;
            this.cboxStore.Location = new System.Drawing.Point(64, 12);
            this.cboxStore.MaxDropDownItems = 4;
            this.cboxStore.Name = "cboxStore";
            this.cboxStore.Size = new System.Drawing.Size(96, 32);
            this.cboxStore.TabIndex = 23;
            this.cboxStore.SelectedIndexChanged += new System.EventHandler(this.cboxStore_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(10, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "店家";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.btnNewPwd);
            this.tabPage4.Controls.Add(this.txtNewPwd2);
            this.tabPage4.Controls.Add(this.txtOldPwd);
            this.tabPage4.Controls.Add(this.txtNewPwd);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.lblNewPwd);
            this.tabPage4.Controls.Add(this.lblNewPwd2);
            this.tabPage4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(728, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "修改密碼";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "請輸入六位數字";
            // 
            // btnNewPwd
            // 
            this.btnNewPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnNewPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewPwd.ForeColor = System.Drawing.Color.White;
            this.btnNewPwd.Location = new System.Drawing.Point(481, 212);
            this.btnNewPwd.Name = "btnNewPwd";
            this.btnNewPwd.Size = new System.Drawing.Size(90, 36);
            this.btnNewPwd.TabIndex = 13;
            this.btnNewPwd.Text = "確認";
            this.btnNewPwd.UseVisualStyleBackColor = false;
            this.btnNewPwd.Click += new System.EventHandler(this.btnNewPwd_Click);
            // 
            // txtNewPwd2
            // 
            this.txtNewPwd2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewPwd2.Location = new System.Drawing.Point(230, 215);
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.PasswordChar = '*';
            this.txtNewPwd2.Size = new System.Drawing.Size(235, 33);
            this.txtNewPwd2.TabIndex = 12;
            this.txtNewPwd2.TextChanged += new System.EventHandler(this.txtNewPwd2_TextChanged);
            this.txtNewPwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPwd2_KeyPress);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOldPwd.Location = new System.Drawing.Point(231, 134);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(235, 33);
            this.txtOldPwd.TabIndex = 10;
            this.txtOldPwd.TextChanged += new System.EventHandler(this.txtOldPwd_TextChanged);
            this.txtOldPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldPwd_KeyPress);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewPwd.Location = new System.Drawing.Point(231, 174);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(235, 33);
            this.txtNewPwd.TabIndex = 10;
            this.txtNewPwd.TextChanged += new System.EventHandler(this.txtNewPwd_TextChanged);
            this.txtNewPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPwd_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(157, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "舊密碼";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNewPwd.Location = new System.Drawing.Point(157, 177);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(67, 24);
            this.lblNewPwd.TabIndex = 11;
            this.lblNewPwd.Text = "新密碼";
            // 
            // lblNewPwd2
            // 
            this.lblNewPwd2.AutoSize = true;
            this.lblNewPwd2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNewPwd2.Location = new System.Drawing.Point(138, 218);
            this.lblNewPwd2.Name = "lblNewPwd2";
            this.lblNewPwd2.Size = new System.Drawing.Size(86, 24);
            this.lblNewPwd2.TabIndex = 9;
            this.lblNewPwd2.Text = "確認密碼";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(764, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "Manager";
            this.Text = "學員與店家管理系統";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboxClassroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxClassroomEdit;
        private System.Windows.Forms.Button btnStdDelete;
        private System.Windows.Forms.Button btnStdAdd;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Button btnStdSaveChange;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewStd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStoreDelete;
        private System.Windows.Forms.Button btnStoreAdd;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.Button btnStoreSaveChange;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewStore;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDishDelete;
        private System.Windows.Forms.Button btnDishAdd;
        private System.Windows.Forms.Label lblDishID;
        private System.Windows.Forms.Button btnDishSaveChange;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listViewDish;
        private System.Windows.Forms.ComboBox cboxStore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnNewPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDishAddCancel;
        private System.Windows.Forms.Button btnDishSaveChangeCancel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd2;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblNewPwd2;
    }
}