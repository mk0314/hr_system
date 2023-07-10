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
    public partial class 信息查询 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
        public 信息查询()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            主页面 f = new 主页面();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
                label10.Visible = true;
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
                    string cmdStr = "select * from 员工 where  身份证号='" + c + "'";//定义查询语句
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
    }
}
