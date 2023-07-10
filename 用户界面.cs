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
    public partial class 用户界面 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串,采用默认windows管理员连接
        string user, pass;
        public 用户界面()
        {
            InitializeComponent();
        }
        public 用户界面(string n, string p)
        {
            InitializeComponent();
            user = n;
            pass = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 员工 where 员工编号='" + user + "' ";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            登录界面 n =new  登录界面 ();
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 员工";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.Trim();
            string b = textBox2.Text.Trim();
            string c = textBox3.Text.Trim();
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("员工编号、姓名和身份证号码不能同时为空，请重新输入");
            }
            else
            {
                dataGridView1.Visible = true;
                SqlConnection con = new SqlConnection(sqlStr);//连接数据库
                con.Open();//打开连接
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    string cmdStr = "select * from 员工 where 员工编号='" + a + "' and 姓名='" + b + "' and 身份证号='" + c + "'";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
                if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    string cmdStr = "select * from 员工 where 姓名='" + b + "'";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    string cmdStr = "select * from 员工 where 员工编号='" + a + "' ";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    string cmdStr = "select * from 员工 where 员工编号='" + a + "' and 姓名='" + b + "' ";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "")
                {
                    string cmdStr = "select * from 员工 where 员工编号='" + a + "' and 身份证号='" + c + "'";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
                if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    string cmdStr = "select * from 员工 where  姓名='" + b + "' and 身份证号='" + c + "'";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "")
                {
                    string cmdStr = "*,部门名 from 员工 JOIN 部门 on 部门.领导人号 =员工.员工编号 where  身份证号='" + c + "'";//定义查询语句
                    SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                    //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                    System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""&&textBox2.Text ==""&&textBox3.Text=="")
            {
                string d = textBox1.Text.Trim();
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
                MessageBox.Show("只能进行员工编号查询个人薪资且员工编号不能为空，请重新输入！！！");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 奖惩记录";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
            //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
