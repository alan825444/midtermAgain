using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midtermAgain
{
    public partial class controlCenter : Form
    {
        public controlCenter()
        {
            InitializeComponent();
        }

        private void controlCenter_Load(object sender, EventArgs e)
        {

        }

        private void btn_accountMng_Click(object sender, EventArgs e)
        {
            accountMng fr = new accountMng();
            fr.Show();
        }
    }
}
