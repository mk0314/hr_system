using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class 档案及人事调动管理 : Form
    {
        public 档案及人事调动管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            离职档案 n = new 离职档案();
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           人事调动 n = new 人事调动();
            n.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            主页面 n = new 主页面();
            n.Show();
            this.Hide();
        }
    }
}
