using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeSystem
{
    public partial class StuMake : Form
    {
        string[] str = new string[5];

        public StuMake()
        {
            InitializeComponent();
            button3.Visible = false;//隐藏修改按钮
        }

        //用于修改，参数位构造函数
        public StuMake(string[] a)
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            textBox5.Text = str[4];
            button1.Visible = false;//隐藏添加按钮
            button3.Visible = true;//显示修改按钮
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void 学生基本信息填写_Load(object sender, EventArgs e)
        {

        }
        //添加一条学生信息
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            string sql = "Insert into 学生表 values('" + textBox1.Text + "','" 
                + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"
                + textBox5.Text + "','333','0')";
            //MessageBox.Show(sql);
            Dao dao = new Dao();
            int i = dao.Execute(sql);
            if (i > 0)
            {
                MessageBox.Show("添加成功！");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //取消事件
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            this.Close();

        }

        //修改事件
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("修该后有空值！检查是否有漏填！");
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update 学生表 set ID='" + textBox1.Text + "'where Id='" + str[0] + "'and Name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[0] = textBox1.Text;  //更新数据ID
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update 学生表 set Name='" + textBox2.Text + "'where Id='" + str[0] + "'and Name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[1] = textBox2.Text;  //更新数据name
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update 学生表 set Class='" + textBox3.Text + "'where Id='" + str[0] + "'and Name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[2] = textBox3.Text;  //更新数据ClassRoom
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update 学生表 set Birthday='" + textBox4.Text + "'where Id='" + str[0] + "'and Name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[3] = textBox4.Text;  //更新数据生日
                }
                if (textBox5.Text != str[4])
                {
                    string sql = "update 学生表 set JG='" + textBox5.Text + "'where Id='" + str[0] + "'and Name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[4] = textBox5.Text;  //更新数据JG
                }
                MessageBox.Show("修改成功！");
                this.Close();
            }

        }
    }
}
