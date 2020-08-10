using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Manager : Form
    {
        List<int> listStoreID = new List<int>();
        public string image_name = "";
        //public bool isAddNewPic = false;
        public bool isChangePic = false;
        List<string> listOldPicName = new List<string>();
        public string filePath = "";

        public Manager()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //標籤背景填充顏色
            SolidBrush BackBrush = new SolidBrush(Color.FromArgb(240, 228, 212));
            //標籤文字填充顏色
            SolidBrush FrontBrush = new SolidBrush(Color.Black);
            StringFormat StringF = new StringFormat();
            //設定文字對齊方式
            StringF.Alignment = StringAlignment.Center;

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                //獲取標籤頭工作區域
                Rectangle Rec = tabControl1.GetTabRect(i);
                //繪製標籤頭背景顏色
                e.Graphics.FillRectangle(BackBrush, Rec);
                //繪製標籤頭文字
                e.Graphics.DrawString(tabControl1.TabPages[i].Text, new Font("微軟正黑體", 10), FrontBrush, Rec, StringF);
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalVar.listClassroom.Count; i++)
            {
                cboxClassroom.Items.Add(GlobalVar.listClassroom[i]);
                cboxClassroomEdit.Items.Add(GlobalVar.listClassroom[i]);
            }
            loadListViewStore();
            loadCboxStore();
            btnDishAdd.Enabled = false;
            btnDishAddCancel.Enabled = false;
            btnDishSaveChangeCancel.Enabled = false;
        }
        private void loadListViewStd()
        {
            listViewStd.Clear();
            listViewStd.View = View.Details;
            listViewStd.Columns.Add("StdID", 80);
            listViewStd.Columns.Add("姓名", 100);
            listViewStd.Columns.Add("班級", 125);
            listViewStd.FullRowSelect = true;
            listViewStd.MultiSelect = false;

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select * from [Student] where Classroom = @SearchClassroom";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            cmd.Parameters.AddWithValue("@SearchClassroom", cboxClassroom.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = reader["StdID"].ToString();
                item.SubItems.Add((string)reader["StdName"]);
                item.SubItems.Add((string)reader["Classroom"]);
                listViewStd.Items.Add(item);
            }

            reader.Close();
            conn.Close();

        }
        private void cboxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadListViewStd();
            lblStdID.Text = "0";
            txtStdName.Text = "";
            cboxClassroomEdit.SelectedIndex = -1;
        }
        private void listViewStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStd.SelectedItems.Count > 0)
            {
                lblStdID.Text = listViewStd.SelectedItems[0].Text;
                txtStdName.Text = listViewStd.SelectedItems[0].SubItems[1].Text;
                cboxClassroomEdit.SelectedIndex = GlobalVar.listClassroom.FindIndex(a => a == listViewStd.SelectedItems[0].SubItems[2].Text);
            }
            else if (listViewStd.SelectedItems.Count == 0)
            {
                lblStdID.Text = "0";
                txtStdName.Text = "";
                cboxClassroomEdit.SelectedIndex = -1;
            }
        }
        private void btnStdSaveChange_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblStdID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "update Student set [StdName] = @UpName, [Classroom] = @UpClassroom where [StdID] = @SearchID";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@UpName", txtStdName.Text);
                cmd.Parameters.AddWithValue("@UpClassroom", cboxClassroomEdit.SelectedItem.ToString());
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                loadListViewStd();
                lblStdID.Text = "0";
                txtStdName.Text = "";
                cboxClassroomEdit.SelectedIndex = -1;
                //MessageBox.Show(rows.ToString() + "個資料列受到影響");
            }
            else
            {
                MessageBox.Show("請先選取欲變更的學生");
            }
        }
        private void btnStdAdd_Click(object sender, EventArgs e)
        {
            if (txtStdName.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else if (cboxClassroomEdit.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇班級");
            }
            else
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "insert into [Student] values (@NewName, @NewClassroom);";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@NewName", txtStdName.Text);
                cmd.Parameters.AddWithValue("@NewClassroom", cboxClassroomEdit.SelectedItem.ToString());
                int rows = cmd.ExecuteNonQuery();  //執行不查詢
                conn.Close();
                lblStdID.Text = "0";
                txtStdName.Text = "";
                cboxClassroomEdit.SelectedIndex = -1;
                loadListViewStd();
                //MessageBox.Show(rows.ToString() + " 個資料列受影響");
            }
        }
        private void btnStdDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblStdID.Text, out intID);
            if (intID > 0)
            {
                DialogResult R = MessageBox.Show($"您確定要刪除這筆資料?\n{intID.ToString()}__{txtStdName.Text}__{cboxClassroomEdit.SelectedItem.ToString()}", "即將刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    conn.Open();
                    string tSQL = "delete from Student where [StdID] = @SearchID";
                    SqlCommand cmd = new SqlCommand(tSQL, conn);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    int rows = cmd.ExecuteNonQuery();  //執行不查詢
                    conn.Close();

                    lblStdID.Text = "0";
                    txtStdName.Text = "";
                    cboxClassroomEdit.SelectedIndex = -1;
                    loadListViewStd();
                    //MessageBox.Show("資料刪除成功, 影響 " + rows.ToString() + " 筆");
                }
            }
            else
            {
                MessageBox.Show("沒有選取學生");
            }
        }
        /*-----------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------店家管理----------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------------*/
        private void loadListViewStore()
        {
            listViewStore.Clear();
            listViewStore.View = View.Details;
            listViewStore.Columns.Add("店家", 161);
            listViewStore.FullRowSelect = true;
            listViewStore.MultiSelect = false;
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select * from Store";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = (string)reader["StoreName"];
                item.Tag = reader["StoreID"].ToString() + "|" + (string)reader["Address"] + "|" + (string)reader["Tel"];
                listViewStore.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
        private void listViewStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStore.SelectedItems.Count > 0)
            {
                string[] arrayTag = listViewStore.SelectedItems[0].Tag.ToString().Split('|');
                lblStoreID.Text = arrayTag[0];
                txtStoreName.Text = listViewStore.SelectedItems[0].Text;
                txtAddress.Text = arrayTag[1];
                txtTel.Text = arrayTag[2];
            }
            else if (listViewStore.SelectedItems.Count == 0)
            {
                lblStoreID.Text = "0";
                txtStoreName.Text = "";
                txtAddress.Text = "";
                txtTel.Text = "";
            }
        }

        private void btnStoreAdd_Click(object sender, EventArgs e)
        {
            if (txtStoreName.Text == "")
            {
                MessageBox.Show("請輸入店名");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("請輸入地址");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("請輸入電話");
            }
            else
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "insert into [Store] values (@NewStoreName, @NewAddress, @NewTel);";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@NewStoreName", txtStoreName.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewTel", txtTel.Text);
                int rows = cmd.ExecuteNonQuery();  //執行不查詢
                conn.Close();
                lblStoreID.Text = "0";
                txtStoreName.Text = "";
                txtAddress.Text = "";
                txtTel.Text = "";
                loadListViewStore();
                //MessageBox.Show(rows.ToString() + " 個資料列受影響");
            }
        }

        private void btnStoreSaveChange_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblStoreID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "update Store set [StoreName] = @UpName, [Address] = @UpAddress, [Tel] = @UpTel where [StoreID] = @SearchID";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@UpName", txtStoreName.Text);
                cmd.Parameters.AddWithValue("@UpAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@UpTel", txtTel.Text);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                loadListViewStore();
                lblStoreID.Text = "0";
                txtStoreName.Text = "";
                txtAddress.Text = "";
                txtTel.Text = "";
                //MessageBox.Show(rows.ToString() + "個資料列受到影響");
            }
            else
            {
                MessageBox.Show("請先選取欲變更的店家");
            }
        }

        private void btnStoreDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblStoreID.Text, out intID);
            if (intID > 0)
            {
                DialogResult R = MessageBox.Show($"您確定要刪除這筆資料?\n{intID.ToString()}__{txtStoreName.Text}__{txtAddress.Text}__{txtTel.Text}", "即將刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    conn.Open();
                    string tSQL = "delete from Store where [StoreID] = @SearchID";
                    SqlCommand cmd = new SqlCommand(tSQL, conn);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    int rows = cmd.ExecuteNonQuery();  //執行不查詢
                    conn.Close();
                    lblStoreID.Text = "0";
                    txtStoreName.Text = "";
                    txtAddress.Text = "";
                    txtTel.Text = "";
                    loadListViewStore();
                    loadCboxStore();
                    //MessageBox.Show("資料刪除成功, 影響 " + rows.ToString() + " 筆");
                }
            }
            else
            {
                MessageBox.Show("沒有選取欲刪除的店家");
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------菜色管理-----------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
        private void releaseAndSetPicNull()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void loadCboxStore()
        {
            listStoreID.Clear();
            cboxStore.Items.Clear();
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select [StoreID],[StoreName] from Store";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                listStoreID.Add((int)reader["StoreID"]);
                cboxStore.Items.Add((string)reader["StoreName"]);
            }
            reader.Close();
            conn.Close();
        }

        private void loadListViewDish()
        {
            listViewDish.Clear();
            listViewDish.View = View.Details;
            listViewDish.Columns.Add("便當名稱", 120);
            listViewDish.Columns.Add("價格", 80);
            listViewDish.FullRowSelect = true;
            listViewDish.MultiSelect = false;

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select * from [DishMenu] where StoreID = @SearchStore";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            cmd.Parameters.AddWithValue("@SearchStore", listStoreID[cboxStore.SelectedIndex]);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = reader["DishID"].ToString() + "|" + (string)reader["PicName"];
                item.Text = (string)reader["DishName"];
                item.SubItems.Add(reader["Price"].ToString());
                listViewDish.Items.Add(item);
            }

            reader.Close();
            conn.Close();

        }

        private void cboxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxStore.SelectedIndex > -1)
            {
                loadListViewDish();
            }
            lblDishID.Text = "0";
            txtDishName.Text = "";
            txtPrice.Text = "";
            releaseAndSetPicNull();
        }

        private void listViewDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDish.SelectedItems.Count > 0)
            {
                string[] arrayTag = listViewDish.SelectedItems[0].Tag.ToString().Split('|');
                string selectPicName = arrayTag[1];
                string image_dir = @"images\";
                lblDishID.Text = arrayTag[0];
                txtDishName.Text = listViewDish.SelectedItems[0].Text;
                txtPrice.Text = listViewDish.SelectedItems[0].SubItems[1].Text;
                releaseAndSetPicNull();
                pictureBox1.Image = Image.FromFile(image_dir + selectPicName);
            }
            else
            {
                lblDishID.Text = "0";
                txtDishName.Text = "";
                txtPrice.Text = "";
                releaseAndSetPicNull();
            }
        }

        private void btnNewPic_Click(object sender, EventArgs e)
        {
            lblDishID.Text = "0";
            txtDishName.Text = "";
            txtPrice.Text = "";
            releaseAndSetPicNull();
            listViewDish.SelectedItems.Clear();

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";  //可篩選可選擇的圖檔類型，|前面只是提示字
            DialogResult R = f.ShowDialog();                                //|後面是真的篩選的類型，用分號分開檔案類型

            if (R == DialogResult.OK)
            {
                releaseAndSetPicNull();
                pictureBox1.Image = Image.FromFile(f.FileName);       //FileName 包含路徑
                // 檔名:年月日時分秒+四位亂數
                string fileExt = Path.GetExtension(f.SafeFileName);   //SafeFileName 不包含路徑
                Random myRnd = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddhhmmss") + myRnd.Next(1000, 9999).ToString() + fileExt;
                btnDishAdd.Enabled = true;
                btnDishAddCancel.Enabled = true;
                cboxStore.Enabled = false;
                listViewDish.Enabled = false;
                groupBox2.Enabled = false;
                btnDishDelete.Enabled = false;
            }
        }

        private void btnDishAdd_Click(object sender, EventArgs e)
        {
            int newPrice = 0;
            if (txtDishName.Text == "")
            {
                MessageBox.Show("請填入便當名稱");
            }
            else if (txtPrice.Text == "" || Int32.TryParse(txtPrice.Text, out newPrice) == false)
            {
                MessageBox.Show("請填入價格或正確形式的價格");
            }
            else
            {
                string image_dir = @"images\";
                pictureBox1.Image.Save(image_dir + image_name);
                //isAddNewPic = false;

                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "insert into [DishMenu] values (@NewStoreID, @NewDishName, @NewPrice, @NewPicName)";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@NewStoreID", listStoreID[cboxStore.SelectedIndex]);
                cmd.Parameters.AddWithValue("@NewDishName", txtDishName.Text);
                cmd.Parameters.AddWithValue("@NewPrice", newPrice);
                cmd.Parameters.AddWithValue("@NewPicName", image_name);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                loadListViewDish();
                btnDishAdd.Enabled = false;
                btnDishAddCancel.Enabled = false;
                cboxStore.Enabled = true;
                listViewDish.Enabled = true;
                groupBox2.Enabled = true;
                btnDishDelete.Enabled = true;
            }
        }

        private void btnDishAddCancel_Click(object sender, EventArgs e)
        {
            //isAddNewPic = false;
            btnDishAdd.Enabled = false;
            btnDishAddCancel.Enabled = false;
            cboxStore.Enabled = true;
            listViewDish.Enabled = true;
            groupBox2.Enabled = true;
            btnDishDelete.Enabled = true;
            image_name = "";
            lblDishID.Text = "0";
            txtDishName.Text = "";
            txtPrice.Text = "";
            releaseAndSetPicNull();
        }

        private void btnEditPic_Click(object sender, EventArgs e)
        {
            if (listViewDish.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選取欲修改的便當");
            }
            else
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";  //可篩選可選擇的圖檔類型，|前面只是提示字
                DialogResult R = f.ShowDialog();                                //|後面是真的篩選的類型，用分號分開檔案類型

                if (R == DialogResult.OK)
                {
                    releaseAndSetPicNull();
                    pictureBox1.Image = Image.FromFile(f.FileName);       //FileName 包含路徑
                                                                          // 檔名:年月日時分秒+四位亂數
                    filePath = f.FileName;
                    string fileExt = Path.GetExtension(f.SafeFileName);   //SafeFileName 不包含路徑
                    Random myRnd = new Random();
                    image_name = DateTime.Now.ToString("yyyyMMddhhmmss") + myRnd.Next(1000, 9999).ToString() + fileExt;
                    isChangePic = true;
                    btnDishSaveChangeCancel.Enabled = true;
                    cboxStore.Enabled = false;
                    listViewDish.Enabled = false;
                    groupBox1.Enabled = false;
                    btnDishDelete.Enabled = false;
                }
            }
        }

        private void btnDishSaveChange_Click(object sender, EventArgs e)
        {
            int newPrice = 0;
            int intID = 0;
            Int32.TryParse(lblDishID.Text, out intID);
            if (intID <= 0)
            {
                MessageBox.Show("請先選擇欲修改的便當資料");
            }
            else if (txtDishName.Text == "")
            {
                MessageBox.Show("請填入便當名稱");
            }
            else if (txtPrice.Text == "" || Int32.TryParse(txtPrice.Text, out newPrice) == false)
            {
                MessageBox.Show("請填入價格或正確形式的價格");
            }
            else
            {
                if (isChangePic == true)
                {
                    string[] arrayTag = listViewDish.SelectedItems[0].Tag.ToString().Split('|');
                    string oldPicName = arrayTag[1];

                    string image_dir = @"images\";
                    pictureBox1.Image.Save(image_dir + image_name);
                    File.Delete(image_dir + oldPicName);
                    isChangePic = false;

                    SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    conn.Open();
                    string tSQL = "update [DishMenu] set [DishName] = @UpDishName, [Price] = @UpPrice, [PicName] = @UpPicName where [DishID] = @SearchDishID";
                    SqlCommand cmd = new SqlCommand(tSQL, conn);
                    cmd.Parameters.AddWithValue("@SearchDishID", intID);
                    cmd.Parameters.AddWithValue("@UpDishName", txtDishName.Text);
                    cmd.Parameters.AddWithValue("@UpPrice", newPrice);
                    cmd.Parameters.AddWithValue("@UpPicName", image_name);
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    loadListViewDish();
                    lblDishID.Text = "0";
                    txtDishName.Text = "";
                    txtPrice.Text = "";
                    releaseAndSetPicNull();
                    btnDishSaveChangeCancel.Enabled = false;
                    cboxStore.Enabled = true;
                    listViewDish.Enabled = true;
                    groupBox1.Enabled = true;
                    btnDishDelete.Enabled = true;
                }
                else
                {
                    SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    conn.Open();
                    string tSQL = "update [DishMenu] set [DishName] = @UpDishName, [Price] = @UpPrice where [DishID] = @SearchDishID";
                    SqlCommand cmd = new SqlCommand(tSQL, conn);
                    cmd.Parameters.AddWithValue("@SearchDishID", intID);
                    cmd.Parameters.AddWithValue("@UpDishName", txtDishName.Text);
                    cmd.Parameters.AddWithValue("@UpPrice", newPrice);
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    loadListViewDish();
                    lblDishID.Text = "0";
                    txtDishName.Text = "";
                    txtPrice.Text = "";
                    releaseAndSetPicNull();
                }
            }
        }

        private void btnDishSaveChangeCancel_Click(object sender, EventArgs e)
        {
            isChangePic = false;
            btnDishSaveChangeCancel.Enabled = false;
            cboxStore.Enabled = true;
            listViewDish.Enabled = true;
            groupBox1.Enabled = true;
            btnDishDelete.Enabled = true;
            image_name = "";
            string[] arrayTag = listViewDish.SelectedItems[0].Tag.ToString().Split('|');
            string selectPicName = arrayTag[1];
            string image_dir = @"images\";
            lblDishID.Text = arrayTag[0];
            txtDishName.Text = listViewDish.SelectedItems[0].Text;
            txtPrice.Text = listViewDish.SelectedItems[0].SubItems[1].Text;
            releaseAndSetPicNull();
            pictureBox1.Image = Image.FromFile(image_dir + selectPicName);

        }

        private void btnDishDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblDishID.Text, out intID);
            if (intID > 0)
            {
                DialogResult R = MessageBox.Show($"您確定要刪除這筆資料?\n{intID.ToString()}__{txtDishName.Text}__{txtPrice.Text}元", "即將刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    conn.Open();
                    string tSQL = "delete from DishMenu where [DishID] = @SearchID";
                    SqlCommand cmd = new SqlCommand(tSQL, conn);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    int rows = cmd.ExecuteNonQuery();  //執行不查詢
                    conn.Close();
                    lblDishID.Text = "0";
                    txtDishName.Text = "";
                    txtPrice.Text = "";
                    releaseAndSetPicNull();

                    string image_dir = @"images\";
                    string[] arrayTag = listViewDish.SelectedItems[0].Tag.ToString().Split('|');
                    string oldPicName = arrayTag[1];
                    File.Delete(image_dir + oldPicName);

                    loadListViewDish();
                    //MessageBox.Show("資料刪除成功, 影響 " + rows.ToString() + " 筆");
                }
            }
            else
            {
                MessageBox.Show("沒有選取欲刪除的便當");
            }
            //將某家店的餐點全部刪除時，觸發刪除店家
            if (listViewDish.Items.Count == 0)
            {
                DialogResult R = MessageBox.Show($"{cboxStore.SelectedItem.ToString()}中已經沒有可購買的便當了，是否刪除店家資訊?\n", "即將刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    conn.Open();
                    string tSQL = "delete from Store where [StoreID] = @SearchID";
                    SqlCommand cmd = new SqlCommand(tSQL, conn);
                    cmd.Parameters.AddWithValue("@SearchID", listStoreID[cboxStore.SelectedIndex]);
                    int rows = cmd.ExecuteNonQuery();  //執行不查詢
                    conn.Close();
                    lblStoreID.Text = "0";
                    txtStoreName.Text = "";
                    txtAddress.Text = "";
                    txtTel.Text = "";
                    loadListViewStore();
                    loadCboxStore();
                }
            }

        }


        /*-----------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------密碼管理----------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------------*/
        private void lockInputNum(string text)
        {
            if (text != "")
            {
                int num = 0;
                bool ifNum = System.Int32.TryParse(text, out num);

                if (ifNum == true)
                {
                    //輸入成功
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    text = "";
                }
            }
        }

        private void txtOldPwd_TextChanged(object sender, EventArgs e)
        {
            lockInputNum(txtOldPwd.Text);
        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {
            lockInputNum(txtNewPwd.Text);
        }

        private void txtNewPwd2_TextChanged(object sender, EventArgs e)
        {
            lockInputNum(txtNewPwd2.Text);
        }

        private void btnNewPwd_Click(object sender, EventArgs e)
        {
            string dbHash = "";
            string dbsalt = "";
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select top 1 * from ManagerPwd";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                dbHash = (string)reader["Password"];
                dbsalt = (string)reader["Salt"];
            }
            reader.Close();
            byte[] passwordAndSaltBytes = Encoding.UTF8.GetBytes(txtOldPwd.Text + dbsalt);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);

            if (hashString == dbHash)
            {
                if (txtNewPwd.Text != txtNewPwd2.Text)
                {
                    MessageBox.Show("新密碼不一致");
                    txtNewPwd.Text = "";
                    txtNewPwd2.Text = "";
                }
                else if (txtNewPwd.Text.Length != 6)
                {
                    MessageBox.Show("新密碼未滿六位數字");
                    txtNewPwd.Text = "";
                    txtNewPwd2.Text = "";
                }
                else
                {
                    System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                    byte[] saltBytes = new byte[36];
                    rng.GetBytes(saltBytes);
                    string newsalt = Convert.ToBase64String(saltBytes);
                    byte[] newpasswordAndSaltBytes = Encoding.UTF8.GetBytes(txtNewPwd.Text + newsalt);
                    byte[] newhashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(newpasswordAndSaltBytes);
                    string newhashString = Convert.ToBase64String(newhashBytes);

                    //SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                    //conn.Open();
                    string tSQL2 = "update [ManagerPwd] set [Password] = @UpPwd, [Salt] = @UpSalt where [Password] = @OldPwd";
                    SqlCommand cmd2 = new SqlCommand(tSQL2, conn);
                    cmd2.Parameters.AddWithValue("@OldPwd", hashString);
                    cmd2.Parameters.AddWithValue("@UpPwd", newhashString);
                    cmd2.Parameters.AddWithValue("@UpSalt", newsalt);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("更改密碼成功");
                    txtOldPwd.Text = "";
                    txtNewPwd.Text = "";
                    txtNewPwd2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("舊密碼錯誤");
                txtOldPwd.Text = "";
                txtNewPwd.Text = "";
                txtNewPwd2.Text = "";
            }
        }

        private void txtOldPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtOldPwd.Text.Length >= 6)
            {
                if (e.KeyChar == (char)Keys.Back)
                { }
                else
                { e.Handled = true; }
            }
        }

        private void txtNewPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNewPwd.Text.Length >= 6)
            {
                if (e.KeyChar == (char)Keys.Back)
                { }
                else
                { e.Handled = true; }
            }
        }

        private void txtNewPwd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNewPwd2.Text.Length >= 6)
            {
                if (e.KeyChar == (char)Keys.Back)
                { }
                else
                { e.Handled = true; }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------/
        //---------------------------------------------------按鈕可用與不可用之變色--------------------------------------------------------/
        //------------------------------------------------------------------------------------------------------------------------------/
        private void btnChangeColor(Button btn)
        {
            btn.ForeColor = btn.Enabled == false ? Color.White : Color.White;
            btn.BackColor = btn.Enabled == false ? Color.FromArgb(240, 228, 212) : Color.FromArgb(209, 128, 99);
        }

        private void btnDishAdd_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnDishAdd);
        }

        private void btnDishAdd_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnDishAdd.Text = string.Empty;
            e.Graphics.DrawString("新增", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void btnNewPic_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnNewPic);
        }

        private void btnNewPic_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnNewPic.Text = string.Empty;
            e.Graphics.DrawString("新增便當照片", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void btnDishAddCancel_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnDishAddCancel);
        }

        private void btnDishAddCancel_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnDishAddCancel.Text = string.Empty;
            e.Graphics.DrawString("取消新增", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void btnEditPic_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnEditPic);
        }

        private void btnEditPic_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnEditPic.Text = string.Empty;
            e.Graphics.DrawString("修改便當照片", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void btnDishSaveChange_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnDishSaveChange);
        }

        private void btnDishSaveChange_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnDishSaveChange.Text = string.Empty;
            e.Graphics.DrawString("儲存修改", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void btnDishSaveChangeCancel_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnDishSaveChangeCancel);
        }

        private void btnDishSaveChangeCancel_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnDishSaveChangeCancel.Text = string.Empty;
            e.Graphics.DrawString("取消所選照片", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void btnDishDelete_EnabledChanged(object sender, EventArgs e)
        {
            btnChangeColor(btnDishDelete);
        }

        private void btnDishDelete_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnDishDelete.Text = string.Empty;
            e.Graphics.DrawString("刪除", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
    }
}
