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
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Homework1
{
    class GlobalVar
    {
        public static string myDBConnectionString = ConfigurationManager.ConnectionStrings["MidProjectConnectionString"].ConnectionString;
        public static int storeID = -1;
        public static string whoisUser = "";
        public static bool storeLock = false;
        public static string headClassroom = "";
        public static string headName = "";

        public static List<string> listClassroom = new List<string>();

        public static void loadClassroomFromDB()
        {
            listClassroom.Clear();
            SqlConnection conn = new SqlConnection(myDBConnectionString);
            conn.Open();
            string tSQL = "select [Classroom] from Student group by [Classroom] order by 1";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                listClassroom.Add((string)reader["Classroom"]);
                //cboxClassroom.Items.Add((string)reader["Classroom"]);
            }
            reader.Close();
            conn.Close();
        }

        public static void chkStoreLockOrNot()
        {
            SqlConnection conn = new SqlConnection(myDBConnectionString);
            conn.Open();
            string tSQL = "select storeID from DishMenu where DishID in (select top 1 DishID from OrderDetail)";
            SqlCommand cmd = new SqlCommand(tSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int j = 0;
            while (reader.Read() == true)
            {
                storeID = (int)reader["storeID"];
                storeLock = true;
                j++;
            }
            if(j == 0)
            {
                storeID = -1;
                storeLock = false;
            }
        }

    }
}
