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
    public partial class StartForm : Form
    {
        
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            GlobalVar.loadClassroomFromDB();
            chooseHead();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Pwd myPwd = new Pwd();
            DialogResult p = myPwd.ShowDialog();
            if (p == DialogResult.OK)
            {
                Manager myManager = new Manager();
                myManager.ShowDialog();
            }
            else
            {
            }
            
        }

        private void btnStdHead_Click(object sender, EventArgs e)
        {
            GlobalVar.whoisUser = "head";
            Form1 myForm1 = new Form1();
            myForm1.ShowDialog();
        }

        private void btnStdOrder_Click(object sender, EventArgs e)
        {
            if (GlobalVar.storeLock == true)
            {
                GlobalVar.whoisUser = "std";
                Form1 myForm1 = new Form1();
                myForm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("請先等待值日生選擇店家");
            }
        }

        private void StartForm_Activated(object sender, EventArgs e)
        {
            GlobalVar.chkStoreLockOrNot();
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            chooseHead();
        }

        private void chooseHead() //選定值日生
        {
            DateTime dtstart = Convert.ToDateTime("2020-5-11");
            DateTime dtnow = DateTime.Now;
            TimeSpan ts = dtnow - dtstart;
            int strday = Convert.ToInt32(ts.TotalDays);
            int workday = strday / 7 * 5 + (strday % 7);
            int stdqty = 0;
            

            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select count(*) as stdqty from Student";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                stdqty = (int)reader["stdqty"];
            }
            reader.Close();
            conn.Close();
            
            string tSQL2 = " select * from [Student] order by [StdID] offset @Num row fetch next 1 rows only";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(tSQL2, conn);
            int row = (workday % stdqty);
            cmd2.Parameters.AddWithValue("@Num", row);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            

            while (reader2.Read() == true)
            {
                GlobalVar.headClassroom = (string)reader2["Classroom"];
                GlobalVar.headName = (string)reader2["StdName"];
            }
            reader2.Close();
            conn.Close();
            
            lblHead.Text = $"值日生 {GlobalVar.headClassroom} {GlobalVar.headName}";
            lblHead.Location = new Point((this.Width - lblHead.Width) / 2 - 5, 82);
        }
    }
}
