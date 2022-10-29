using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermAgain.model
{
    internal class selctItem
    {
        public Dictionary<string,string> tableName { get; set; }
        public List<string> colloumns = new List<string>();
        public string conditions = "";
        public string groupby = ""; 
        public string orderBy = "";
        public string other = "";


    }
}
