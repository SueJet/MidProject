using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Pwd : Form
    {
        int exitType = 1;
        public Pwd()
        {
            InitializeComponent();
        }

        private void Pwd_Load(object sender, EventArgs e)
        {
            chkPwdExist();
        }

        private void chkPwdExist()
        {
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select * from ManagerPwd";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int j = 0;
            while (reader.Read() == true)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                j++;
            }
            if (j == 0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPwd.Text != "")
            {
                int num = 0;
                bool ifNum = System.Int32.TryParse(txtNewPwd.Text, out num);

                if (ifNum == true)
                {
                    //輸入成功
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    txtNewPwd.Text = "";
                }
            }
        }

        private void txtNewPwd2_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPwd2.Text != "")
            {
                int num = 0;
                bool ifNum = System.Int32.TryParse(txtNewPwd2.Text, out num);

                if (ifNum == true)
                {
                    //輸入成功
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    txtNewPwd2.Text = "";
                }
            }
        }

        private void btnNewPwd_Click(object sender, EventArgs e)
        {
            // random salt
            if(txtNewPwd.Text == txtNewPwd2.Text && txtNewPwd.Text.Length == 6)
            {
                System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                byte[] saltBytes = new byte[36];
                rng.GetBytes(saltBytes);
                string salt = Convert.ToBase64String(saltBytes);
                byte[] passwordAndSaltBytes = Encoding.UTF8.GetBytes(txtNewPwd.Text + salt);
                byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
                string hashString = Convert.ToBase64String(hashBytes);

                SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
                conn.Open();
                string tSQL = "insert into ManagerPwd values(@NewPwd, @NewSalt)";
                SqlCommand cmd = new SqlCommand(tSQL, conn);
                cmd.Parameters.AddWithValue("@NewPwd", hashString);
                cmd.Parameters.AddWithValue("@NewSalt", salt);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("已成功建立密碼，請重新登入");
                this.Close();
            }
            else if(txtNewPwd.Text != txtNewPwd2.Text)
            {
                MessageBox.Show("輸入密碼不一致");
                txtNewPwd.Text = "";
                txtNewPwd2.Text = "";
            }
            else 
            {
                MessageBox.Show("密碼不到六位");
                txtNewPwd.Text = "";
                txtNewPwd2.Text = "";
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtPwd.Text != "")
            {
                int num = 0;
                bool ifNum = System.Int32.TryParse(txtPwd.Text, out num);

                if (ifNum == true)
                {
                    //輸入成功
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    txtPwd.Text = "";
                }
            }
        }

        private void btnChkPwd_Click(object sender, EventArgs e)
        {
            string dbHash = "";
            string salt = "";
            SqlConnection conn = new SqlConnection(GlobalVar.myDBConnectionString);
            conn.Open();
            string tSQL = "select top 1 * from ManagerPwd";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                dbHash = (string)reader["Password"];
                salt = (string)reader["Salt"];
            }
            reader.Close();
            conn.Close();

            byte[] passwordAndSaltBytes = Encoding.UTF8.GetBytes(txtPwd.Text + salt);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);

            if(hashString == dbHash)
            {
                exitType = 1;
            }
            else 
            {
                exitType = 0;
            }
        }

        private void Pwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitType == 0)
            {
                e.Cancel = true;
                MessageBox.Show("輸入密碼錯誤");
                txtPwd.Text = "";
                exitType = 1;
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

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPwd.Text.Length >= 6)
            {
                if (e.KeyChar == (char)Keys.Back)
                { }
                else
                { e.Handled = true; }
            }
        }
    }
}
