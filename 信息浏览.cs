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
    public partial class 信息浏览 : Form
    {
        
        string user, pass;
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库
        public 信息浏览(string a, string b)
        {
            InitializeComponent();
            user = a;
            pass = b;
        }
        public 信息浏览()
        {
            InitializeComponent();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            主页面 f = new 主页面();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                 信息添加 f = new 信息添加();
                 f.Show();
                 this.Hide();
            
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 员工";//定义查询语句
            SqlCommand sqlCom = new SqlCommand(cmdStr, con);//定义查询命令
          
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
           
            

                try
                {
                  
                    con.Open();//打开连接
                    string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                    string delete_by_id = "delete from 员工 where 员工编号='" + select_id.Trim() + "'";//sql删除语句
                    SqlCommand cmd = new SqlCommand(delete_by_id, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                    信息浏览 n = new 信息浏览();
                    n.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("请正确选择行!");
                }
                finally
                {
                    con.Dispose();
                }
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
 

}

 private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
 {
     


        }

        private void button2_Click(object sender, EventArgs e)
        {
            信息查询 n = new 信息查询();
            n.Show();
            this.Hide();
        }
    }
}
