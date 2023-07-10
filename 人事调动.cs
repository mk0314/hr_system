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
    public partial class 人事调动 : Form
    {
        string sqlStr = "server=MK96;database=人事管理系统;Trusted_Connection=yes";//连接数据库
        public 人事调动()
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
            if(textBox1.Text!=""&&textBox2.Text!=""&&comboBox1.Text!=""&&comboBox2.Text!=""&&comboBox3.Text!=""&&textBox3.Text!=""&&textBox4.Text!=""&&textBox5.Text!="")
            {
                SqlConnection con = new SqlConnection(sqlStr);//连接数据库
                con.Open();//打开连接
                string 员工编号 = textBox2.Text.ToString();
                //string sql = "update 职务调动 set 调动编号 = '" + textBox1.Text.ToString() + "',员工编号 = '" + textBox2.Text.ToString() + "', 调动前职称 = '" + comboBox1.Text.ToString() + "',调动后职称 = '" + comboBox2.Text.ToString() + "', 调动后部门号 = '" + comboBox3.Text.ToString() + "' , 调动日期 = '" + textBox3.Text.ToString() + "', 批复日期 = '" + textBox4.Text.ToString() + "', 调动原因 = '" + textBox5.Text.ToString() + "'where 员工编号 = '" + 员工编号 + "'";

                string sql = "insert into 职务调动(调动编号,员工编号,调动前职称,调动后职称,调动后部门号,调动日期,批复日期,调动原因) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                string sql1 = "UPDATE 员工 SET 员工.部门号 = 职务调动.调动后部门号  , 员工.职称 =职务调动.调动后职称 FROM 员工 , 职务调动 WHERE 员工.员工编号 = 职务调动.员工编号";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                //cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                int count = cmd1.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("亲，数据更新成功！");

                }
                else
                {
                    MessageBox.Show("亲，数据更新失败！");

                }
                con.Close();
                
            }
            else
            {
                MessageBox.Show("输入信息不完整，请重新输入");
            }
           
           
        }
    }
}
