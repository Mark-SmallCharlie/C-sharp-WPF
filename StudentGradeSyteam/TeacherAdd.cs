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
    public partial class TeacherAdd : Form
    {
        string[] str = new string[4];
        public TeacherAdd()
        {
            InitializeComponent();
            button3.Visible = false;//默认不显示修改按钮
        }

        //用于修改，参数位构造函数
        public TeacherAdd(string[] a)
        {
            InitializeComponent();
            for (int i = 0; i < 0; i++)
            {
                str[i] = a[i];
                textBox1.Text = str[0];
                textBox2.Text = str[1];
                textBox3.Text = str[2];
                textBox4.Text = str[3];
                button1.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TeacherAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //确定添加事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            string sql = "Insert into 教师表 values('" + textBox1.Text + "','" 
                    + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            //MessageBox.Show(sql);
            Dao dao = new Dao();
            int i = dao.Execute(sql); 
            if (i > 0)
            {
                MessageBox.Show("添加成功！");
            }
        }


        //取消事件
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            this.Close();
        }

        //修改事件
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("修该后有空值！检查是否有漏填！");
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update 教师表 ser Id='" + textBox1.Text + "'where Id='" + str[0] + "'and Name='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[0] = textBox1.Text; //修改原来的数据
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update 教师表 set Name='" + textBox2.Text + "'where Id='" + str[0] + "'and Name='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[1] = textBox2.Text; //修改原来的数据
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update 教师表 set Password='" + textBox3.Text + "'where Id='" + str[0] + "'and Name='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[2] = textBox3.Text; //修改原来的数据
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update 教师表 set ZC='" + textBox4.Text + "'where Id='" + str[0] + "'and Name='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[3] = textBox4.Text; //修改原来的数据
                }
                MessageBox.Show("修改成功！");
            }
        }
    }
}
