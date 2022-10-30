using midtermAgain.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midtermAgain
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btn_regist_confirm_Click(object sender, EventArgs e)
        {
            if (collumn_verification())
            {
                data_insert();
            };
            

        }

        private bool collumn_verification()
        {
            bool result = false;
            //檢查是否重複
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("A", "T_member");
            selctItem item = new selctItem()
            {
                tableName = table,
                colloumns = new List<string> { "A.*" },
                conditions = $"A.Account = '{txt_Account.Text}'"
            };
            sqlFactory sqlFactory = new sqlFactory();
            if (sqlFactory.SelectTable(item).Count() > 0)
            {
                MessageBox.Show("資料重複");
                return result;
            };

            //欄位不可為空
            if (txt_Account.Text == "" || txt_address.Text == "" ||  txt_name.Text == "" || txt_phone.Text=="" || txt_phone.Text =="" || dtp_birth.Text == "")
            {
                MessageBox.Show("請完整填寫所有資料");
                return result;
            }
            //密碼對照
            if(txt_pwd1.Text == "" || txt_pwd2.Text == "" || (txt_pwd1.Text != txt_pwd2.Text))
            {
                MessageBox.Show("密碼不可為空 或 密碼與確認密碼不一致");
                return result;
            }
            result = true;
            return result; 
        }

        private void data_insert()
        {
            //permission 1. 最高管理員 2. 管理者 3. 員工
            //verification 預設為0,可由管理員與管理者做認證
            
            
            registerData temp = new registerData()
            {
                Account = txt_Account.Text,
                Pwd = txt_pwd1.Text,
                Name = txt_name.Text,
                Address = txt_address.Text,
                Phone = txt_phone.Text,
                Birth = DateTime.Parse(dtp_birth.Text),
                Gender = radioButton1.Checked? '1':'2',
                Permission = '3',
                Verification = '0'
            };
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Account",temp.Account);
            data.Add("Password",temp.Pwd);
            data.Add("Name",temp.Name);
            data.Add("Permission",temp.Permission.ToString());
            data.Add("Verification",temp.Verification.ToString());
            data.Add("Gender",temp.Gender.ToString());
            data.Add("Birth", temp.Birth.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo));
            data.Add("Phone",temp.Phone);
            data.Add("Address",temp.Address);
            sqlFactory sqlFactory = new sqlFactory();
            if (sqlFactory.sqlInsert("T_member",data))
            {
                MessageBox.Show("註冊成功，請等待管理員審核");
                this.Close();
                Form1 fr1 = new Form1();
                fr1.Visible = true;
            }
            else
            {
                MessageBox.Show("註冊失敗，請與管理員聯絡");
            }
        }
    }
}
