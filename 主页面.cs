using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class 主页面 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";
        string user, pass;
        public 主页面()
        {
            InitializeComponent();

        }
        public 主页面(string n, string p)
        {
            InitializeComponent();
            
            user = n;
            pass = p;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            基础信息浏览 n = new 基础信息浏览();
            n.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            信息查询 n = new 信息查询();
            n.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new 信息浏览();
            form.Show();
            
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                档案及人事调动管理 n = new 档案及人事调动管理();
                n.Show();
                this.Hide();
          
              
           
            
        }

        private void 主页面_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
                管理员 n = new 管理员();
                n.Show();
                this.Hide();
               
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            公司系统结构 n = new 公司系统结构(); 
            n.Show();
            this.Hide();
        }
    }
}
