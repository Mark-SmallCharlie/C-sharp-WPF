using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 成绩可视化分析;


namespace StudentGradeSystem
{
    public partial class StuCtrl : Form
    {
        string SID;//学生SID
        string[] str = new string[5];
        public StuCtrl()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            toolStripStatusLabel1.Text = "欢迎学号为" + SID + "的同学登录学生系统";
            timer1.Start();
            Table();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void StuCtrl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void StuCtrl_Load(object sender, EventArgs e)
        {

        }
        //让表显示数据
        private void Table()
        {
            string sql = "select *from 学生表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e;
                a = dr["Id"].ToString();
                b = dr["Name"].ToString();
                c = dr["Class"].ToString();
                d = dr["Birthday"].ToString();
                e = dr["JG"].ToString();
                string[] str = { a, b, c, d, e };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();//关闭连接
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuMake stuMake = new StuMake();
            stuMake.ShowDialog();

        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定删除吗？", "", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string id, name;
                id = dataGridView2.SelectedCells[0].Value.ToString();
                name = dataGridView2.SelectedCells[1].Value.ToString();
                string sql = "delete from 学生表 where id ='" + id + "'and name='" + name + "'";
                MessageBox.Show(sql);
                Dao dao = new();
                dao.Execute(sql);
                dataGridView2.Rows.Clear();
                Table();
            }
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView2.SelectedCells[0].Value.ToString(), dataGridView2.SelectedCells[1].Value.ToString(), dataGridView2.SelectedCells[2].Value.ToString(), dataGridView2.SelectedCells[3].Value.ToString(), dataGridView2.SelectedCells[4].Value.ToString() };
            StuMake stuMake = new StuMake(str);
            stuMake.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Table();
        }

        private void 开始选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuClass stuClass = new StuClass("");
            stuClass.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 修改学生密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuFixMm stuFixMm = new StuFixMm(SID);
            stuFixMm.Show();
        }

        private void 我的成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
           form2.Show();
        }
    }
}
