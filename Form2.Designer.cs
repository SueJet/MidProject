namespace Homework1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxClassroom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhichClassroom = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblClassroomBool = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.listViewClassroom = new System.Windows.Forms.ListView();
            this.listViewAll = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.btnClassroomSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewDetailAll = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label1.Name = "label1";
            // 
            // cboxClassroom
            // 
            this.cboxClassroom.BackColor = System.Drawing.Color.White;
            this.cboxClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboxClassroom, "cboxClassroom");
            this.cboxClassroom.FormattingEnabled = true;
            this.cboxClassroom.Name = "cboxClassroom";
            this.cboxClassroom.SelectedIndexChanged += new System.EventHandler(this.cboxClassroom_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label2.Name = "label2";
            // 
            // lblWhichClassroom
            // 
            resources.ApplyResources(this.lblWhichClassroom, "lblWhichClassroom");
            this.lblWhichClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.lblWhichClassroom.Name = "lblWhichClassroom";
            // 
            // lblTotalMoney
            // 
            resources.ApplyResources(this.lblTotalMoney, "lblTotalMoney");
            this.lblTotalMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(123)))), ((int)(((byte)(86)))));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Name = "lblTotalMoney";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDeleteAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDeleteAll, "btnDeleteAll");
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblClassroomBool
            // 
            resources.ApplyResources(this.lblClassroomBool, "lblClassroomBool");
            this.lblClassroomBool.Name = "lblClassroomBool";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listViewClassroom
            // 
            resources.ApplyResources(this.listViewClassroom, "listViewClassroom");
            this.listViewClassroom.HideSelection = false;
            this.listViewClassroom.Name = "listViewClassroom";
            this.listViewClassroom.UseCompatibleStateImageBehavior = false;
            // 
            // listViewAll
            // 
            resources.ApplyResources(this.listViewAll, "listViewAll");
            this.listViewAll.HideSelection = false;
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label3.Name = "label3";
            // 
            // lblStore
            // 
            resources.ApplyResources(this.lblStore, "lblStore");
            this.lblStore.Name = "lblStore";
            // 
            // btnClassroomSave
            // 
            this.btnClassroomSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnClassroomSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClassroomSave, "btnClassroomSave");
            this.btnClassroomSave.ForeColor = System.Drawing.Color.White;
            this.btnClassroomSave.Name = "btnClassroomSave";
            this.btnClassroomSave.UseVisualStyleBackColor = false;
            this.btnClassroomSave.Click += new System.EventHandler(this.btnClassroomSave_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label5.Name = "label5";
            // 
            // lblTel
            // 
            resources.ApplyResources(this.lblTel, "lblTel");
            this.lblTel.Name = "lblTel";
            // 
            // lblAddress
            // 
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.Name = "lblAddress";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label6.Name = "label6";
            // 
            // listViewDetailAll
            // 
            this.listViewDetailAll.CheckBoxes = true;
            resources.ApplyResources(this.listViewDetailAll, "listViewDetailAll");
            this.listViewDetailAll.GridLines = true;
            this.listViewDetailAll.HideSelection = false;
            this.listViewDetailAll.Name = "listViewDetailAll";
            this.listViewDetailAll.UseCompatibleStateImageBehavior = false;
            this.listViewDetailAll.View = System.Windows.Forms.View.Details;
            this.listViewDetailAll.SelectedIndexChanged += new System.EventHandler(this.listViewDetailAll_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(202)))));
            this.label7.Name = "label7";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listViewDetailAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClassroomSave);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewAll);
            this.Controls.Add(this.listViewClassroom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblClassroomBool);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblWhichClassroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxClassroom);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxClassroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhichClassroom;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label lblClassroomBool;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listViewClassroom;
        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Button btnClassroomSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewDetailAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
    }
}