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
            dbConStr = ConfigurationManager.ConnectionStrings["TEST"].ToString(); 
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from T_member", con);
            SqlDataReader reader = cmd.ExecuteReader();
            var test = reader.FieldCount;
            MessageBox.Show(Convert.ToString(test));

        }
    }
}
