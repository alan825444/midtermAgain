using midtermAgain.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace midtermAgain
{
    internal class sqlFactory
    {
        public string dbConStr = ConfigurationManager.ConnectionStrings["midterm"].ToString();

        public SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(dbConStr);
            con.Open();
            return con;

        }

        public List<Dictionary<string, string>> SelectTable(selctItem item)
        {
            SqlConnection con = connection();
            //組成SQL字串，此處沒有特別使用parameter是因為主要為程式內自己使用的查詢，不會讓使用者有機會進行sql injection
            string sqlStr = "SELECT ";
            if(item.colloumns.Count != 0)
            {
                foreach (var colloumn in item.colloumns)
                {
                    sqlStr += $"{colloumn},";
                }
                sqlStr =  sqlStr.Trim(',');
                sqlStr += " FROM ";
            }
            else
            {
                sqlStr += "* FROM ";
            }
            foreach ( var table in item.tableName)
            {
                sqlStr += $"{table.Value} as {table.Key} ,";
            }

            sqlStr = sqlStr.Trim(',');

            if(item.conditions != "")
            {
                sqlStr += $"WHERE {item.conditions} ";
            }

            if(item.groupby != "")
            {
                sqlStr += $"GROUP BY {item.groupby}";
            }

            if (item.orderBy != "")
            {
                sqlStr += $"ORDER BY {item.orderBy} ";
            }

            if(item.other != "")
            {
                sqlStr += $"{item.other}";
            }
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            
            
            SqlCommand cmd = new SqlCommand(sqlStr,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();
                for (int i = 0; i <= dr.FieldCount-1; i++)
                {
                    temp.Add(dr.GetName(i).ToString(),dr.GetValue(i).ToString());
                }
                result.Add(temp);

            }
            dr.Close();
            con.Close();

            return result;
        }
        public bool sqlInsert(string tableName, Dictionary<string,string> datas)
        {
            SqlConnection con = connection();
            string sqlStr = $"INSERT INTO {tableName} VALUES (";
            foreach (var data in datas)
            {
                sqlStr += $"@{data.Key},";
            }
            sqlStr = sqlStr.Trim(',');
            sqlStr += ")";
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            foreach (var data in datas)
            {
                cmd.Parameters.AddWithValue($"@{data.Key}",data.Value);
            }
            int q = cmd.ExecuteNonQuery();
            con.Close();
            if (q > 0)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public bool sqlUpdate(string table, Dictionary<string,string> datas, string condition)
        {
            SqlConnection con = connection();
            string sqlStr = $"UPDATE {table} SET";
            foreach (var data in datas)
            {
                sqlStr += $" {data.Key} = @{data.Key},";
            }
            sqlStr = sqlStr.Trim(',');
            sqlStr += $" WHERE {condition}";
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            foreach (var data in datas)
            {
                cmd.Parameters.AddWithValue($"@{data.Key}",data.Value);
            }
            var q = cmd.ExecuteNonQuery();
            if(q > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
            

        }
    }
}
