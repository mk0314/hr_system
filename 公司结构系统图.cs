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
    public partial class 公司系统结构 : Form
    {
        public 公司系统结构()
        {
            InitializeComponent();
        }

        private void 公司系统结构_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            主页面 n = new 主页面();
            n.Show();
            this.Hide();
        }
    }
}
