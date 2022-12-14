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
using System.Net;
using System.Security.Principal;

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
            //Dictionary<string, string> table = new Dictionary<string, string>();
            //table.Add("A", "T_member");
            //table.Add("B", "T_test");
            //selctItem item = new selctItem()
            //{
            //    tableName = table,
            //    orderBy = "A.ID",
            //    colloumns = new List<string> { "A.*"},
            //    conditions = "A.ID = B.FK_member"
            //};
            //sqlFactory sqlFactory = new sqlFactory();
            //List<Dictionary<string,string>> temp = sqlFactory.SelectTable(item);
            //Console.WriteLine(sqlFactory.SelectTable(item)[0]["Password"]);
            
            //Insert function測試
            //寫成dic是為了組SqlParameter的字串
            //Dictionary<string,string> data = new Dictionary<string, string>();
            //data.Add("Account","test");
            //data.Add("Pwd", "123");
            //data.Add("Name", "測試");
            //data.Add("Permission", "1");
            //data.Add("Gender", "1");
            //data.Add("Verification", "1");
            //data.Add("Birth", "1997-02-20");
            //data.Add("Phone", "0982773827");
            //data.Add("Address", "測試用");
            //sqlFactory factory = new sqlFactory();
            //factory.sqlInsert("T_member", data);

        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            register register = new register();
            this.Visible = false;
            register.ShowDialog();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string msg = "";
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("A", "T_member");
            selctItem item = new selctItem()
            {
                tableName = table,
                colloumns = new List<string> { "A.ID","A.Account", "A.Verification", "A.Permission","A.Name" },
                conditions = $"A.Account ='{txt_account.Text}' AND A.Password = '{txt_pwd.Text}'"
            };
            var q = new sqlFactory().SelectTable(item);
            if (q.Count() == 1)
            {
                if (q[0]["Verification"] != "0")
                {
                    memberBasicinfo memberBasicinfo = new memberBasicinfo()
                    {
                        ID = Convert.ToInt16(q[0]["ID"]),
                        Name = q[0]["Name"],
                        Permission = q[0]["Permission"]
                    };
                    globalValue.memberBasicinfo = memberBasicinfo;
                    msg = $"{globalValue.memberBasicinfo.Name} 您好!\n" +
                        $"請按下確認至操作介面";
                    MessageBox.Show(msg);
                    controlCenter fr = new controlCenter();
                    fr.Show();
                    this.Hide();

                }
                else
                {
                    msg = $"請聯絡管理員開通帳號權限";
                    MessageBox.Show(msg);
                }
            }
            else
            {
                msg = "帳號密碼輸入錯誤";
                MessageBox.Show(msg);
                txt_account.Clear();
                txt_pwd.Clear();
            }
        }
    }
}
