﻿using System;
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
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("A", "T_member");
            table.Add("B", "T_test");
            selctItem item = new selctItem()
            {
                tableName = table,
                orderBy = "A.ID",
                colloumns = new List<string> { "A.*"},
                conditions = "A.ID = B.FK_member"
            };
            sqlFactory sqlFactory = new sqlFactory();
            List<Dictionary<string,string>> temp = sqlFactory.SelectTable(item);
            Console.WriteLine(sqlFactory.SelectTable(item)[0]["Password"]);

        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            register register = new register();
            this.Visible = false;
            register.ShowDialog();
            
        }
    }
}
