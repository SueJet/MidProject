using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Configuration;

namespace Homework1
{
    public partial class Form2 : Form
    {
        //public int[] dishCount = new int[5];
        public List<ArrayList> listCheckOrderUser = new List<ArrayList>();

        //List<string> listClassroom = new List<string>();
        List<string> listDishName = new List<string>();
        List<int> listTotalqty = new List<int>();
        bool closeForm = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void loadClassroom()
        {
            for (int i = 0; i < GlobalVar.listClassroom.Count; i++)
            { 
                cboxClassroom.Items.Add(GlobalVar.listClassroom[i]);
            }
        }

        private void loadStoreData()
        {
            if (GlobalVar.storeLock == true)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "select [StoreName],[Address],[Tel] from Store where StoreID = @SearchStoreID";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@SearchStoreID", GlobalVar.storeID);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    lblStore.Text = (string)reader["StoreName"];
                    lblAddress.Text = (string)reader["Address"];
                    lblTel.Text = (string)reader["Tel"];
                }
                reader.Close();
                conn.Close();
            }
        }

        private void loadListViewAll()
        {
            listViewAll.Clear();
            listViewAll.View = View.Details;
            listViewAll.Columns.Add("產品名稱", 120);
            listViewAll.Columns.Add("個數", 80);
            listViewAll.FullRowSelect = true;
            

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select d.DishName, sum(o.qty) as Totalqty from DishMenu as d inner join OrderDetail as o on(d.DishID = o.DishID) group by o.DishID, d.DishName";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();


            int j = 0;
            while (reader.Read() == true)
            {
                listDishName.Add((string)reader["DishName"]);
                listTotalqty.Add((int)reader["Totalqty"]);

                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = (string)reader["DishName"];
                item.SubItems.Add(reader["Totalqty"].ToString());
                listViewAll.Items.Add(item);

                j += 1;
            }
            //Console.WriteLine("資料筆數:{0}", j);
            reader.Close();
            conn.Close();

        }
        private void calculateTotalMoney()
        {
            int total = 0;

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select sum(o.qty) * d.Price as [PerTotal] from DishMenu as d inner join OrderDetail as o on(d.DishID = o.DishID) group by o.DishID, d.Price";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                total += (int)reader["PerTotal"];
            }

            lblTotalMoney.Text = "總價" + total.ToString() + "元";
            reader.Close();
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadClassroom();
            loadListViewAll();
            loadStoreData();
            calculateTotalMoney();
            loadListViewDetailAll();
            label7.Location = new Point(738, 0);
            lblDate.Location = new Point(785, 0);
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
        
        private void loadListViewClassroom()
        {
            listViewClassroom.Clear();
            listViewClassroom.View = View.Details;
            listViewClassroom.Columns.Add("姓名", 100);
            listViewClassroom.Columns.Add("便當名稱", 120);
            listViewClassroom.Columns.Add("個數", 80);
            listViewClassroom.Columns.Add("小計", 80);
            listViewClassroom.FullRowSelect = true;

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select o.OrderID, (select StdName from Student where stdID = o.StdID) as StdName, d.DishName, o.qty, (o.qty * d.Price) as PerTotal from DishMenu as d inner join OrderDetail as o on(d.DishID = o.DishID) where o.StdID in (select StdID from Student where Classroom = @SearchClassroom)";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            cmd.Parameters.AddWithValue("@SearchClassroom", GlobalVar.listClassroom[cboxClassroom.SelectedIndex]);
            SqlDataReader reader = cmd.ExecuteReader();

            int j = 0;
            while (reader.Read() == true)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = reader["OrderID"].ToString();
                item.Text = (string)reader["StdName"];
                item.SubItems.Add((string)reader["DishName"]);
                item.SubItems.Add(reader["qty"].ToString());
                item.SubItems.Add(reader["PerTotal"].ToString());
                listViewClassroom.Items.Add(item);

                j += 1;
            }
            reader.Close();
            conn.Close();
        }

        private void cboxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxClassroom.SelectedIndex > -1)
            {
                lblClassroomBool.Text = "";
            }
            lblWhichClassroom.Text = GlobalVar.listClassroom[cboxClassroom.SelectedIndex] + " 訂購明細";

            loadListViewClassroom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show($"刪除此訂單?\n{listViewClassroom.SelectedItems[0].Text}_{listViewClassroom.SelectedItems[0].SubItems[1].Text}_{listViewClassroom.SelectedItems[0].SubItems[2].Text}個", "訂單即將刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "delete from OrderDetail where [OrderID] = @SearchID";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@SearchID", Convert.ToInt32(listViewClassroom.SelectedItems[0].Tag));
                int rows = cmd.ExecuteNonQuery();  //執行不查詢
                conn.Close();

                loadListViewClassroom();
                loadListViewAll();
                calculateTotalMoney();
                loadListViewDetailAll();
            }
            
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您是否要刪除所有訂單?", "訂單即將清除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "truncate table [OrderDetail]";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                int rows = cmd.ExecuteNonQuery();  //執行不查詢
                conn.Close();
                //MessageBox.Show(rows.ToString() + " 個資料列受影響");

                //GlobalVar.storeLock = false;
                //GlobalVar.storeID = -1;
                closeForm = true; //回Form1時將Form1一起關閉，將此按鈕設為DialogResult.OK，按了按鈕最後一定會執行關閉此視窗，在關閉視窗時傳回DialogResult.OK;  
            }
            else
            {
                closeForm = false; //在Form2_FormClosing中，將關閉視窗的事件取消
            }
            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeForm == true)
            {
            }
            else
            {
                e.Cancel = true;
                closeForm = true; //取消關閉之後，再使視窗可以被關閉
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            string s = dir.Parent.Parent.FullName;
            
            //string strClassroom = Convert.ToString(cboxClassroom.Items[cboxClassroom.SelectedIndex]);

            string str1 = s + "\\";
            string str2 = @"全班訂購品項檔.txt";
            string strAllPath = str1 + str2;

            List<string> linesOrderDetailResult = new List<string>();

            linesOrderDetailResult.Add("全校訂購明細");
            linesOrderDetailResult.Add("-------------------------------------");
            for (int i = 0; i < listViewAll.Items.Count;i++)
            {
                string strMsg1 = listViewAll.Items[i].Text;
                string strMsg2 = listViewAll.Items[i].SubItems[1].Text;
                linesOrderDetailResult.Add(strMsg1 + " " + strMsg2 + "個");
            }
            linesOrderDetailResult.Add("-------------------------------------");
            linesOrderDetailResult.Add(lblTotalMoney.Text);

            System.IO.File.WriteAllLines(strAllPath, linesOrderDetailResult, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }

        private void btnClassroomSave_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            string s = dir.Parent.Parent.FullName;

            //string strClassroom = Convert.ToString(cboxClassroom.Items[cboxClassroom.SelectedIndex]);

            string str1 = s + "\\";
            string str2 = GlobalVar.listClassroom[cboxClassroom.SelectedIndex] + @"訂購品項檔.txt";
            string strAllPath = str1 + str2;

            List<string> linesOrderDetailResult = new List<string>();

            linesOrderDetailResult.Add(GlobalVar.listClassroom[cboxClassroom.SelectedIndex] + "訂購明細");
            linesOrderDetailResult.Add("-------------------------------------");
            if (listViewClassroom.Items.Count > 0)
            {
                for (int i = 0; i < listViewAll.Items.Count; i++)
                {
                    string strMsg1 = listViewClassroom.Items[i].Text;
                    string strMsg2 = listViewClassroom.Items[i].SubItems[1].Text;
                    string strMsg3 = listViewClassroom.Items[i].SubItems[2].Text;
                    string strMsg4 = listViewClassroom.Items[i].SubItems[3].Text;
                    linesOrderDetailResult.Add(strMsg1 + " " + strMsg2 + " " + strMsg3 + "個 共" + strMsg4 + "元");
                }
            }
            linesOrderDetailResult.Add("-------------------------------------");
            linesOrderDetailResult.Add(lblTotalMoney.Text);

            System.IO.File.WriteAllLines(strAllPath, linesOrderDetailResult, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }

        private void loadListViewDetailAll()
        {            
            listViewDetailAll.Clear();
            listViewDetailAll.View = View.Details;
            listViewDetailAll.Columns.Add("繳費", 50);
            listViewDetailAll.Columns.Add("小計", 60);
            listViewDetailAll.Columns.Add("個數", 60);
            listViewDetailAll.Columns.Add("便當名稱", 90);
            listViewDetailAll.Columns.Add("姓名", 90);
            listViewDetailAll.Columns.Add("班級", 88);
            for (int i = 0; i < 6;i++)
            {
                listViewDetailAll.Columns[i].TextAlign = HorizontalAlignment.Right;
            }
            /*
            listViewDetailAll.Columns.Add("繳費", 50);
            listViewDetailAll.Columns.Add("班級", 80);
            listViewDetailAll.Columns.Add("姓名", 90);
            listViewDetailAll.Columns.Add("便當名稱", 90);
            listViewDetailAll.Columns.Add("個數", 60);
            listViewDetailAll.Columns.Add("小計", 60);
            */
            //listViewDetailAll.CheckBoxes.;
            listViewDetailAll.FullRowSelect = true;

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select (select Classroom from Student where stdID = o.StdID) as Classroom , (select StdName from Student where stdID = o.StdID) as StdName, d.DishName, o.qty, (o.qty * d.Price) as PerTotal from DishMenu as d inner join OrderDetail as o on(d.DishID = o.DishID) order by Classroom, StdName";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            int j = 0;
            while (reader.Read() == true)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = "";
                item.SubItems.Add(reader["PerTotal"].ToString());
                item.SubItems.Add(reader["qty"].ToString());
                item.SubItems.Add((string)reader["DishName"]);
                item.SubItems.Add((string)reader["StdName"]);
                item.SubItems.Add((string)reader["Classroom"]);
                /*item.SubItems.Add((string)reader["Classroom"]);
                item.SubItems.Add((string)reader["StdName"]);
                item.SubItems.Add((string)reader["DishName"]);
                item.SubItems.Add(reader["qty"].ToString());
                item.SubItems.Add(reader["PerTotal"].ToString());*/
                listViewDetailAll.Items.Add(item);

                j += 1;
            }
            reader.Close();
            conn.Close();
        }

        private void listViewDetailAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewDetailAll.SelectedItems.Clear();
        }

        
    }
}
