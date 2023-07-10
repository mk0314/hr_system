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
    public partial class 信息添加 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库字符串uid=mk96;password=mengkuncurry
        public 信息添加()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlStr);//连接数据库
            con.Open();//打开连接
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM 员工 ", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "员工");
            DataTable tb = ds.Tables["员工"];

            object[] o = new object[9] { this.textBox1.Text.TrimEnd(), this.textBox2.Text.TrimEnd(), this.comboBox1.Text.TrimEnd(), this.textBox4.Text.TrimEnd(), this.comboBox2.Text.TrimEnd(), this.textBox6.Text.TrimEnd(), this.textBox7.Text.TrimEnd(), this.comboBox3.Text.TrimEnd(), this.comboBox4.Text.TrimEnd() };
            tb.Rows.Add(o);
            dataAdapter.Update(ds, "员工");
            ds.AcceptChanges();
            信息浏览 n = new 信息浏览();
            n.Show();
            this.Hide();
        }
    }
}
