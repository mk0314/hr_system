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
    public partial class 登录界面 : Form
    {
       
        public 登录界面()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string userpwd = textBox2.Text.Trim();
            string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 员工 where 员工编号='" + username + "' and 员工编号='" + userpwd + "'";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
            if (sRead.Read())//if(sRead.Read())的意思是，如果能查找到
            {

                sRead.Close();
                string cmdStr1 = "select * from 管理人员 where 职工编号='" + username + "' and 职工编号='" + userpwd + "'";//定义查询语句
                SqlCommand sqlCom1 = new SqlCommand(cmdStr1, con);//定义查询命令
                SqlDataReader sRead1 = sqlCom1.ExecuteReader();//执行查询
                if (sRead1.Read())//if(sRead.Read())的意思是，如果能查找到 
                {
                    MessageBox.Show("欢迎来到管理员界面");
                    主页面 f = new 主页面(textBox1.Text, textBox2.Text);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("欢迎来到用户界面");
                    用户界面 m=new 用户界面();
                     m.Show ();
                    this.Hide ();
                }
               
            }
          
            else
            {
                MessageBox.Show("用户名与密码不匹配，请重新输入!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = null;
            textBox1.Focus();
            this.Close();
        }

        private void 登录界面_Load(object sender, EventArgs e)
        {

        }
    }
}





