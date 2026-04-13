using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace StudentGradeSystem
{
    public partial class TeachGrade : Form
    {
        public TeachGrade()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            Table();
            Table2();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Table()
        {
            string sql = "select *from 成绩表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f;
                a = dr["Id"].ToString();
                b = dr["Course"].ToString();
                c = dr["Grade"].ToString();
                d = dr["Rank"].ToString();
                e = dr["cid"].ToString();
                f = dr["Name"].ToString();
                string[] str = { a, b, c, d, e, f };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
        private void Table2()
        {
            string sql = "select*from 成绩表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f;
                a = dr["Id"].ToString();
                b = dr["Course"].ToString();
                c = dr["Grade"].ToString();
                d = dr["Rank"].ToString();
                e = dr["cid"].ToString();
                f = dr["Name"].ToString();
                string[] str = { a, b, c, d, e, f };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();
        }
        private void TableID()
        {
            string sql = "select*from 成绩表 where Id='" + textBox1.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            string id, course, grade, rank, cid, name;
            while (dr.Read())
            {
                id = dr["Id"].ToString();
                course = dr["Course"].ToString();
                grade = dr["Grade"].ToString();
                rank = dr["Rank"].ToString();
                cid = dr["cid"].ToString();
                name = dr["Name"].ToString();
                string[] str = { id, course, grade, rank, cid, name };
                dataGridView3.Rows.Add(str);
            }
            dr.Close();
        }
        private void TableCourse()
        {
            string sql = "select*from 成绩表 where Course='" + textBox3.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            string id, course, grade, rank, cid, name;
            while (dr.Read())
            {
                id = dr["Id"].ToString();
                course = dr["Course"].ToString();
                grade = dr["Grade"].ToString();
                rank = dr["Rank"].ToString();
                cid = dr["cid"].ToString();
                name = dr["Name"].ToString();
                string[] str = { id, course, grade, rank, cid, name };
                dataGridView3.Rows.Add(str);
            }
            dr.Close();
        }
        private void TableName()
        {
            string sql = "select*from 成绩表 where Name='" + textBox2.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            string id, course, grade, rank, cid, name;
            while (dr.Read())
            {
                id = dr["Id"].ToString();
                course = dr["Course"].ToString();
                grade = dr["Grade"].ToString();
                rank = dr["Rank"].ToString();
                cid = dr["cid"].ToString();
                name = dr["Name"].ToString();
                string[] str = { id, course, grade, rank, cid, name };
                dataGridView3.Rows.Add(str);
            }
            dr.Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            //时间显示控件
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //添加的数据表
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改的数据表
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;//允许用户添加行
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            // SetupDataGridView1();

        }
        /*private void SetupDataGridView1()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Course";
            dataGridView1.Columns[2].Name = "Grade";
            dataGridView1.Columns[3].Name = "Rank";
            dataGridView1.Columns[4].Name = "cid";
            dataGridView1.Columns[5].Name = "Name";


        }
        */
        private void TeachGrade_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //取消事件
        private void button4_Click(object sender, EventArgs e)
        {
            //清空选中行
            MessageBox.Show("选中整行进行清空！");
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);
            }
        }
        //确定添加按键事件
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Insert into 成绩表 (Id,Course,Grade,Rank,cid, Name) values (@val1, @val2, @val3, @val4, @val5, @val6)";
                Dao dao = new Dao();
                if (dataGridView1.Rows.Count > 0 && !dataGridView1.Rows[0].IsNewRow)
                {
                    // 确保dataGridView1.Rows[0].Cells[i].Value不为null
                    string val1 = dataGridView1.Rows[0].Cells[0].Value?.ToString() ?? string.Empty;
                    string val2 = dataGridView1.Rows[0].Cells[1].Value?.ToString() ?? string.Empty;
                    string val3 = dataGridView1.Rows[0].Cells[2].Value?.ToString() ?? string.Empty;
                    string val4 = dataGridView1.Rows[0].Cells[3].Value?.ToString() ?? string.Empty;
                    string val5 = dataGridView1.Rows[0].Cells[4].Value?.ToString() ?? string.Empty;
                    string val6 = dataGridView1.Rows[0].Cells[5].Value?.ToString() ?? string.Empty;

                    // 输出调试信息
                    Console.WriteLine("DataGridView Values:");
                    Console.WriteLine("Id: " + val1);
                    Console.WriteLine("Course: " + val2);
                    Console.WriteLine("Grade: " + val3);
                    Console.WriteLine("Rank: " + val4);
                    Console.WriteLine("cid: " + val5);
                    Console.WriteLine("Name: " + val6);

                    // 添加参数
                    dao.AddParameter("@val1", val1);
                    dao.AddParameter("@val2", val2);
                    dao.AddParameter("@val3", val3);
                    dao.AddParameter("@val4", val4);
                    dao.AddParameter("@val5", val5);
                    dao.AddParameter("@val6", val6);


                    int i = dao.Execute(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败：" + ex.Message);
            }
        }

        //确定修改按键事件
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update 成绩表 set Course=@val1,Grade=@val2,Rank=@val3,cid=@val4,Name=@val5 where Id=@val6";
                Dao dao = new Dao();
                if (dataGridView2.Rows.Count > 0 && !dataGridView2.Rows[0].IsNewRow)
                {
                    dao.AddParameter("@val1", dataGridView2.Rows[0].Cells[1].Value.ToString());
                    dao.AddParameter("@val2", dataGridView2.Rows[0].Cells[2].Value.ToString());
                    dao.AddParameter("@val3", dataGridView2.Rows[0].Cells[3].Value.ToString());
                    dao.AddParameter("@val4", dataGridView2.Rows[0].Cells[4].Value.ToString());
                    dao.AddParameter("@val5", dataGridView2.Rows[0].Cells[5].Value.ToString());
                    dao.AddParameter("@val6", dataGridView2.Rows[0].Cells[0].Value.ToString());
                    int i = dao.Execute(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败：" + ex.Message);
            }
        }

        /*  private void button4_Click_1(object sender, EventArgs e)
          {
              //清空选中行
              MessageBox.Show("选中整行进行清空！");
              if (dataGridView1.SelectedRows.Count > 0)
              {
                  dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
              }

          }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentCell != null)
                MessageBox.Show("选中整行进行取消！");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //按学号查询成绩
            TableID();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            //按姓名查询成绩
            TableName();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //按课程查询成绩
            TableCourse();
        }

        private void 返回管理界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROOT root = new ROOT();
            root.Show();
            this.Hide();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        //开始添加图标

    }
}
