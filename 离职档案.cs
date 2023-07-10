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
    public partial class 离职档案 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
        public 离职档案()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            主页面 n = new 主页面();
            n.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.Trim();
            if (textBox1.Text == "")
            {
                MessageBox.Show("员工编号、姓名和身份证号码不能同时为空，请重新输入");
            }
            else
            {
                SqlConnection con = new SqlConnection(sqlStr);//连接数据库
                con.Open();//打开连接
                string cmdStr = "select *,姓名 from 离职表 join 员工 on 离职表.员工编号=员工.员工编号 where 离职表.员工编号='" + a + "' ";//定义查询语句
                SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
                //SqlDataReader sRead = sqlCom.ExecuteReader();//执行查询
                System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
        }

        private void 离职档案_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 离职表  ";//定义查询语句
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
