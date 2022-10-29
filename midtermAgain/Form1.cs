using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using midtermAgain.model;

namespace midtermAgain
{
    public partial class Form1 : Form
    {
        //資料庫連接字串
        public string dbConStr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //利用config建立連接字串
            dbConStr = ConfigurationManager.ConnectionStrings["midterm"].ToString(); 
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(dbConStr);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from table", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //con.Close();
            selctItem item = new selctItem()
            {
                tableName = "T_member",
                orderBy = "ID"
            };
            item.tableName = "T_member";
            sqlFactory sqlFactory = new sqlFactory();
            List<Dictionary<string,string>> temp = sqlFactory.SelectTable(item);
            Console.WriteLine(sqlFactory.SelectTable(item)[1]["Password"]);

        }
    }
}
