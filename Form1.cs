using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Homework1
{
    public partial class Form1 : Form
    {
        List<int> listStoreID = new List<int>();
        List<int> listDishID = new List<int>();
        List<string> listDishName = new List<string>();
        List<int> listDishPrice = new List<int>();
        List<string> listPicName = new List<string>();

        //public string classroom = "";
        //List<string> listClassroom = new List<string>();
        List<int> listStdID = new List<int>();
        List<string> listStd = new List<string>();
        //public int stdID = 0;

        public int amount;

        List<ArrayList> listOrderDetail = new List<ArrayList>();

        public int exitType = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadStore()
        {
            listStoreID.Clear();
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select [StoreID],[StoreName] from Store";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                listStoreID.Add((int)reader["StoreID"]);
                //listStoreName.Add((string)reader["StoreName"]);
                cboxStore.Items.Add((string)reader["StoreName"]);
            }
            reader.Close();
            conn.Close();
        }

        private void loadClassroom()
        {
            for (int i = 0; i < GlobalVar.listClassroom.Count; i++)
            {
                cboxClassroom.Items.Add(GlobalVar.listClassroom[i]);
            }
        }

        private void loadListViewDish()
        {
            listDishID.Clear();
            listDishName.Clear();
            listDishPrice.Clear();
            listPicName.Clear();
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select * from [DishMenu] where storeID =  @SearchStoreID";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            cmd.Parameters.AddWithValue("@SearchStoreID", GlobalVar.storeID);
            SqlDataReader reader = cmd.ExecuteReader();


            int j = 0;
            while (reader.Read() == true)
            {
                listDishID.Add((int)reader["DishID"]);
                listDishName.Add((string)reader["DishName"]);
                listDishPrice.Add((int)reader["Price"]);
                listPicName.Add((string)reader["PicName"]);
                //imageList1.Images.Add(Image.FromFile(image_dir + image_name));

                j += 1;
            }
            Console.WriteLine("資料筆數:{0}", j);
            reader.Close();
            conn.Close();

            listViewDish.Clear();
            listViewDish.View = View.Details;
            listViewDish.Columns.Add("便當名稱", 120);
            listViewDish.Columns.Add("價格", 80);
            listViewDish.FullRowSelect = true;
            listViewDish.MultiSelect = false;

            for (int i = 0; i < listDishID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listDishID[i] + "|" + listPicName[i];
                item.Text = listDishName[i];
                item.SubItems.Add(listDishPrice[i].ToString());
                listViewDish.Items.Add(item);
            }
        }
        private void loadListViewOrderColumns()
        {
            listViewOrder.Clear();
            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("訂購人", 80);
            listViewOrder.Columns.Add("便當名稱", 120);
            listViewOrder.Columns.Add("個數", 50);
            listViewOrder.Columns.Add("小計", 60);
            listViewOrder.FullRowSelect = true;
            listViewOrder.MultiSelect = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadClassroom();
            loadStore();
            loadListViewOrderColumns();

            if (GlobalVar.whoisUser == "head")
            {
                cboxClassroom.SelectedIndex = cboxClassroom.FindString(GlobalVar.headClassroom);
                cboxClassroom.Enabled = false;
                cboxUser.SelectedIndex = cboxUser.FindString(GlobalVar.headName);
                cboxUser.Enabled = false;
            }

            if (GlobalVar.storeLock == true)
            {
                loadListViewDish();
                cboxStore.SelectedIndex = listStoreID.FindIndex(a=>a == GlobalVar.storeID);
                cboxStore.Enabled = false;
            }

            if (GlobalVar.whoisUser == "std")
            {
                btnChkTotalOrder.Visible = false;
            }

            amount = 1;
            txtAmount.Text = amount.ToString();
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void cboxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.storeID = listStoreID[cboxStore.SelectedIndex];
            loadListViewDish();         
        }

        private void cboxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStd.Clear();
            cboxUser.Items.Clear();

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select * from [Student] where [Classroom] = @SearchClassroom";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            cmd.Parameters.AddWithValue("@SearchClassroom", cboxClassroom.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            int j = 0;
            while (reader.Read() == true)
            {
                listStdID.Add((int)reader["StdID"]);
                listStd.Add((string)reader["StdName"]);
                cboxUser.Items.Add((string)reader["StdName"]);

                j += 1;
            }
            Console.WriteLine("資料筆數:{0}", j);
            reader.Close();
            conn.Close();

        }

        private void cboxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //stdID = listStdID[cboxUser.SelectedIndex];
        }



        private void calculateMoney()
        {
            int totalMoney = 0;

            foreach (ArrayList arrayListTemp in listOrderDetail)
            {
                totalMoney += (int)arrayListTemp[3] * (int)arrayListTemp[2]; //單價 * 數量
            }

            lblTotalMoney.Text = totalMoney.ToString() + "元";
        }



        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                bool ifNum = System.Int32.TryParse(txtAmount.Text, out amount);

                if ((ifNum == true) && (amount >= 1))
                {
                    //輸入成功
                    if (amount > 20)
                    {
                        MessageBox.Show("數量過多請重新輸入");
                        amount = 1;
                        txtAmount.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("輸入數量錯誤");
                    amount = 1;
                    txtAmount.Text = "1";
                }
            }
            else
            {
                amount = 1;
            }
            
            
        }
        private void addIntoListOrderDetail()
        {
            ArrayList arrayOrder = new ArrayList();
            arrayOrder.Add(listStdID[cboxUser.SelectedIndex]);           //arrayOrder[0]
            string[] arrayTag = listViewDish.SelectedItems[0].Tag.ToString().Split('|');
            arrayOrder.Add(Convert.ToInt32(arrayTag[0]));     //DishID = arrayOrder[1] (int型態)
            arrayOrder.Add(amount);          //arrayOrder[2]
            int unitPrice = Convert.ToInt32(listViewDish.SelectedItems[0].SubItems[1].Text);
            arrayOrder.Add(unitPrice);       //Price = arrayOrder[3]
            listOrderDetail.Add(arrayOrder);            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboxStore.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇店家");
            }
            else if (cboxClassroom.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇班級");
            }
            else if (cboxUser.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇訂購人");
            }
            else if (listViewDish.SelectedItems.Count == 0)
            {
                MessageBox.Show("請選擇餐點");
            }
            else
            {                
                if(listViewOrder.Items.Count > 0)  //listViewOrder有東西才執行
                {
                    int j = 0;
                    for(int i = 0; i < listViewOrder.Items.Count; i++)  //檢查是否有菜重複
                    {
                        if (listViewDish.SelectedItems[0].Text == listViewOrder.Items[i].SubItems[1].Text) //選的菜已經出現在購物車
                        {
                            listOrderDetail[i][2] = (int)listOrderDetail[i][2] + amount;
                            j++;
                        }
                    }
                    if(j == 0)
                    {
                        addIntoListOrderDetail();
                        
                    }
                }
                else
                {
                    addIntoListOrderDetail();
                }
                updateCart();
                calculateMoney();
                cboxClassroom.Enabled = false;
                cboxStore.Enabled = false;
                cboxUser.Enabled = false;
            }
        }
        void updateCart()
        {
            loadListViewOrderColumns();

            for (int i = 0; i < listOrderDetail.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listStd[cboxUser.SelectedIndex]; //學生名字
                int did = (int)listOrderDetail[i][1];
                item.SubItems.Add(listDishName[listDishID.FindIndex(a => a == did)]); //便當名稱
                int am = (int)listOrderDetail[i][2];
                item.SubItems.Add(am.ToString()); //數量
                int perTotalPrice = (int)listOrderDetail[i][3] * am;
                item.SubItems.Add(perTotalPrice.ToString()); //小計
                listViewOrder.Items.Add(item);
            }
            /*
            ListViewItem item = new ListViewItem();
            item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
            //item.Tag = ;
            item.Text = listStd[cboxUser.SelectedIndex];
            item.SubItems.Add(listDishName[listViewDish.SelectedItems[0].Index]);
            item.SubItems.Add(amount.ToString());
            int perTotalPrice = Convert.ToInt32(listViewDish.SelectedItems[0].SubItems[1].Text) * amount;
            item.SubItems.Add(perTotalPrice.ToString());
            listViewOrder.Items.Add(item);
            */
        }
        
        private void listViewDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDish.SelectedItems.Count > 0)
            {
                string[] arrayTag = listViewDish.SelectedItems[0].Tag.ToString().Split('|');
                string selectPicName = arrayTag[1];
                string image_dir = @"images\";
                pictureBox1.Image = Image.FromFile(image_dir + selectPicName);
                
            }
        }
        
        private void orderAddToDB()
        {
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            foreach (ArrayList arrayListTemp in listOrderDetail)
            {
                string tSQL = "insert into OrderDetail values(@NewStdID, @NewDishID, @Newqty, @NewDate)";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@NewStdID", arrayListTemp[0]);
                cmd.Parameters.AddWithValue("@NewDishID", arrayListTemp[1]);
                cmd.Parameters.AddWithValue("@Newqty", arrayListTemp[2]);
                cmd.Parameters.AddWithValue("@NewDate", DateTime.Now);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("新增" + rows.ToString() + "筆資料");
            }
            conn.Close();
        }
        
        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            if(GlobalVar.whoisUser == "head" && GlobalVar.storeLock == false)
            {
                DialogResult R = MessageBox.Show("即將送出訂單，訂單送出後店家不可改變", "送出訂單", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (R == DialogResult.Yes)
                {
                    orderAddToDB();
                    //MessageBox.Show("已成功訂購，即將跳轉回登入頁面");
                    exitType = 1;
                    //GlobalVar.storeLock = true;
                    this.Close();   //跳回登入頁
                }
                else
                {
                    //取消
                }
            }
            else
            {
                DialogResult R = MessageBox.Show("即將送出訂單，訂單送出後不可改變", "送出訂單", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (R == DialogResult.Yes)
                {
                    orderAddToDB();
                    //MessageBox.Show("已成功訂購，即將跳轉回登入頁面");
                    exitType = 1;
                    this.Close();   //跳回登入頁
                }
                else
                {
                    //取消
                }
            }

        }

        private void btnDeleteChosen_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedIndices.Count > 0)
            { 
                
                for (int i = listViewOrder.SelectedIndices.Count - 1; i >= 0; i -= 1)
                {
                    listOrderDetail.RemoveAt(listViewOrder.SelectedIndices[i]);
                    listViewOrder.Items.RemoveAt(listViewOrder.SelectedIndices[i]);
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的品項");
            }
            calculateMoney();

            if (listViewOrder.Items.Count == 0)
            {
                if (GlobalVar.storeLock == false)
                {
                    cboxStore.Enabled = true;
                }
                if (GlobalVar.whoisUser == "std")
                {
                    cboxClassroom.Enabled = true;
                    cboxUser.Enabled = true;
                }
            }
   
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要清空購物車?", "即將清空購物車", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (R == DialogResult.Yes)
            {
                listOrderDetail.Clear();
                listViewOrder.Items.Clear();
                calculateMoney();
                if (GlobalVar.storeLock == false)
                {
                    cboxStore.Enabled = true;
                }
                if (GlobalVar.whoisUser == "std")
                {
                    cboxClassroom.Enabled = true;
                    cboxUser.Enabled = true;
                }
            }
            else
            {
                //取消
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitType != 1)
            {
                if (listViewOrder.Items.Count != 0)
                {
                    DialogResult R = MessageBox.Show("購物車內的物品尚未訂購，確定要關閉視窗?", "表單即將關閉", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        //關閉
                    }
                    else
                    {
                        //取消
                        e.Cancel = true; //e為關閉視窗的事件
                    }
                }
            }
            
        }

        private void btnChkTotalOrder_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            DialogResult r = myForm2.ShowDialog();
            if(r == DialogResult.OK)
            {
                exitType = 1;
                this.Close();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {            
            if (GlobalVar.storeLock == true)
            {
                loadListViewDish();
                cboxStore.SelectedIndex = listStoreID.FindIndex(a => a == GlobalVar.storeID);
                cboxStore.Enabled = false;
            }
            else
            {
                cboxStore.Enabled = true;
                //cboxStore.SelectedIndex = -1;
            }


            amount = 1;
            txtAmount.Text = amount.ToString();
        }
    }
}
