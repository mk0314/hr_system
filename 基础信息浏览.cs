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
    public partial class 基础信息浏览 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
        public 基础信息浏览()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            主页面 f = new 主页面();
            f.Show();
            this.Hide();
        }

        private void 基础信息浏览_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                string d = textBox1.Text.Trim();
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                SqlConnection con = new SqlConnection(sqlStr);//连接数据库
                con.Open();//打开连接
                string cmdStr = "select 工资编号,工资.员工编号,姓名,基本工资,实发工资,员工.部门号,起始时间,截止时间,发薪日期 from 工资 JOIN 员工 on 员工.员工编号= 工资.员工编号 where 员工.员工编号 ='" + d + "'";//定义查询语句
                SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("员工不能为空，请重新输入");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = textBox1.Text.Trim();
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select 合同编号,员工.员工编号,姓名,职称,合同起始,合同到期,入职日期,工龄 ,部门号 from 合同表 JOIN 员工 on 员工.员工编号= 合同表.员工编号 JOIN 工龄 on 员工.员工编号 =工龄.员工编号  where 合同表.员工编号='" + d + "'";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = textBox1.Text.Trim();
            dataGridView3.Visible = true;
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select 员工.员工编号,姓名,职称,部门号,上班日期,上班时间,下班时间,刷卡机号,打卡次数 from 出勤 JOIN 员工 on 员工.员工编号= 出勤.员工编号 where 出勤.员工编号= '" + d + "'";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView3.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select* from 奖惩记录 JOIN 员工 on 员工.员工编号= 奖惩记录.员工编号 ";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select* from 加班表 JOIN 员工 on 员工.员工编号= 加班表.员工编号 ";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView3.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select* from 培训 JOIN 员工 on 员工.员工编号= 培训.员工编号 ";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
        }
    }
}
