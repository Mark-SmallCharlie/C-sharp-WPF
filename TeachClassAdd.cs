using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace StudentGradeSystem
{
    public partial class TeachClassAdd : Form
    {
        string[] str = new string[4];
        public TeachClassAdd()
        {
            InitializeComponent();
            button3.Visible = false; //默认隐藏“添加”按钮

        }
        //用于修改，参数位构造函数
        public TeachClassAdd(string[] a)
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = a[0];
            textBox2.Text = a[1];
            textBox3.Text = a[2];
            textBox4.Text = a[3];
            button1Add.Visible = false;
            button3.Visible = true; //显示“修改”按钮

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //取消按钮
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            this.Close();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            string sql = "Insert into 课程表 values('" + textBox1.Text + "','" 
                + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            Dao dao = new Dao();
            int i = dao.Execute(sql);
            if (i > 0)
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }

        }
        //修改按钮
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update 课程表 set Id='" + textBox1.Text + "' where Id='" + str[0] + "'and Name '" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[0] = textBox1.Text;//修改str数组中的值
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update 课程表 set Name='" + textBox2.Text + "' where Id='" + str[0] + "'and Name '" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update 课程表 set Teacher='" + textBox3.Text + "' where Id='" + str[0] + "'and Name '" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update 课程表 set Grade='" + textBox4.Text + "' where Id='" + str[0] + "'and Name '" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[3] = textBox4.Text;
                }
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }
    }
}
