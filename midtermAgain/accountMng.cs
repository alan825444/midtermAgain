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
    public partial class accountMng : Form
    {
        public accountMng()
        {
            InitializeComponent();
        }

        private void accountMng_Load(object sender, EventArgs e)
        {
            comboboxLoad();
            cb_Permision.SelectedIndex = 0;
            cb_gender.SelectedIndex = 0;
            cb_verification.SelectedIndex = 0;
            dataLoad();
            this.cb_gender.SelectedIndexChanged +=
            new System.EventHandler(ComboBox_SelectedIndexChanged);
            this.cb_Permision.SelectedIndexChanged +=
            new System.EventHandler(ComboBox_SelectedIndexChanged);
            this.cb_verification.SelectedIndexChanged +=
            new System.EventHandler(ComboBox_SelectedIndexChanged);

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            sqlFactory sqlFactory = new sqlFactory();
            var ID = dgv_info.Rows[dgv_info.CurrentCell.RowIndex].Cells[0].Value;
            Dictionary<string,string> data = new Dictionary<string,string>();
            data.Add("Verification","1");
            if (sqlFactory.sqlUpdate("T_member", data, $"ID= {ID}"))
            {
                MessageBox.Show("帳號認證成功");
            }
            else
            {
                MessageBox.Show("帳號認證失敗");
            };
            dataLoad();
        }

        private void dataLoad()
        {
            sqlFactory sqlFactory = new sqlFactory();
            string whereStr = "";
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("A", "T_member");
            table.Add("B", "Config_permission");
            if(cb_Permision.SelectedIndex != 0) 
            {
                whereStr += $"A.Permission = {cb_Permision.SelectedIndex} AND ";
            }

            if(cb_gender.SelectedIndex != 0)
            {
                whereStr += $"A.Gender = {cb_gender.SelectedIndex} AND ";
            }

            if (cb_verification.SelectedIndex != 0)
            {
                whereStr += $"A.Verification = {cb_verification.SelectedIndex-1} AND ";
            }

            whereStr += $"A.ID != {globalValue.memberBasicinfo.ID} AND B.ID = A.permission";

            List<Dictionary<string,string>> datas = sqlFactory.SelectTable(new selctItem
            {
                tableName = table,
                colloumns = new List<string> { "A.*,B.Permission as pmsName", "convert(varchar, A.Birth, 111) as C_birth" } ,
                conditions = whereStr,
            });
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("帳號");
            dataTable.Columns.Add("名稱");
            dataTable.Columns.Add("權限");
            dataTable.Columns.Add("認證");
            dataTable.Columns.Add("性別");
            dataTable.Columns.Add("生日");
            dataTable.Columns.Add("電話");
            dataTable.Columns.Add("地址");

            foreach (var item in datas)
            {
                string verification = item["Verification"] == "1" ? "已認證" : "未認證";
                string gender = item["Gender"] == "1" ? "男" : "女";
                dataTable.Rows.Add(new string[] { item["ID"], item["Account"], item["Name"], item["pmsName"], verification, gender, item["C_birth"], item["Phone"], item["Address"] });
            }
            dgv_info.DataSource = dataTable;
        }

        private void comboboxLoad()
        {
            sqlFactory sqlFactory = new sqlFactory();
            string whereStr = "";
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("A", "Config_permission");
            var data = sqlFactory.SelectTable(new selctItem
            {
                tableName = table,
                colloumns = new List<string>() {"A.Permission"},
                conditions = whereStr
            });
            cb_Permision.Items.Add("全部");
            foreach (var item in data)
            {
                cb_Permision.Items.Add(item["Permission"]);
            }

            cb_gender.Items.Add("全部");
            cb_gender.Items.Add("男");
            cb_gender.Items.Add("女");

            cb_verification.Items.Add("全部");
            cb_verification.Items.Add("未認證");
            cb_verification.Items.Add("已認證");
        }


    }
}
