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
    public partial class ROOT : Form
    {
        string[] str = new string[4];
        public ROOT()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            Table();
            Table2();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ROOT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //显示教师表
        private void Table()
        {
            string sql = "select *from 教师表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d;
                a = dr["Id"].ToString();
                b = dr["Name"].ToString();
                c = dr["Password"].ToString();
                d = dr["ZC"].ToString();
                string[] str = { a, b, c, d };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();

        }


        private void 添加教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAdd teachAdd = new TeacherAdd();
            teachAdd.ShowDialog();

        }

        //显示课程表
        private void Table2()
        {
            string sql = "select *from 课程表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d;
                a = dr["Id"].ToString();
                b = dr["Name"].ToString();
                c = dr["Teacher"].ToString();
                d = dr["Grade"].ToString();
                string[] str = { a, b, c, d };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();
        }

        private void 删除教师信息(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定删除吗？", "", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string id, name;
                id = dataGridView1.SelectedCells[0].Value.ToString();
                name = dataGridView1.SelectedCells[1].Value.ToString();
                string sql = "delete from 教师表 where id ='" + id + "'and name='" + name + "'";
                //MessageBox.Show(sql);
                Dao dao = new Dao();
                dao.Execute(sql);
                dataGridView1.Rows.Clear();
                Table();
            }
        }

        private void 修改教师信息(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString() };
            TeacherAdd teachAdd = new TeacherAdd(str);
            teachAdd.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //刷新图标
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Table();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachClassAdd teachClassAdd = new TeachClassAdd();
            teachClassAdd.ShowDialog();
        }

        private void 删除课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定删除吗？", "", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string id, name;
                id = dataGridView2.SelectedCells[0].Value.ToString();
                name = dataGridView2.SelectedCells[1].Value.ToString();
                string sql = "delete from 课程表 where Id ='" + id + "'and Name='" + name + "'";
                //MessageBox.Show(sql);
                Dao dao = new Dao();
                dao.Execute(sql);
                dataGridView2.Rows.Clear();
                Table2();
            }
        }

        private void 修改课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView2.SelectedCells[0].Value.ToString(), dataGridView2.SelectedCells[1].Value.ToString(), dataGridView2.SelectedCells[2].Value.ToString(), dataGridView2.SelectedCells[3].Value.ToString() };
            TeachClassAdd teachClassAdd = new TeachClassAdd(str);
            teachClassAdd.ShowDialog();
        }

        private void 学生成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //事件为跳转到学生信息管理界面
            StuCtrl stuCtrl = new StuCtrl();
            stuCtrl.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Table2();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Table2();
        }

        private void 账号管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 学生成绩添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachGrade teacherGradeAdd = new TeachGrade();
            teacherGradeAdd.ShowDialog();
        }
    }
}
