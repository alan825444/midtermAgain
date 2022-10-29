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
            string sqlStr = "SELECT ";
            if(item.colloumns.Count != 0 && item.colloumns != null)
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
            sqlStr += $"{item.tableName} ";

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
    }
}
