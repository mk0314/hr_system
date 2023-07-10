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
    public partial class 管理员 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
        public 管理员()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            主页面 f = new 主页面();
            f.Show();
            this.Hide();
            this.Controls.Clear();
            InitializeComponent(); 
        }

        private void 管理员_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            string cmdStr = "select * from 管理人员";//定义查询语句
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
