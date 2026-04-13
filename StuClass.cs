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
    public partial class StuClass : Form
    {
        string SID;
        public StuClass(string sID)
        {
            SID = sID;
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            Table();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Table()
        {
            string sql = "select *from 课程表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d;
                a = dr["Id"].ToString();
                b = dr["Name"].ToString();
                c = dr["Grade"].ToString();
                d = dr["Teacher"].ToString();
                string[] str = { a, b, c, d };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();

        }

        private void 选择该课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cID = dataGridView1.SelectedCells[0].Value.ToString();
            string sql1 = "select *from 选课记录 where sid='" + SID + "'and cid='" + cID + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql1);
            if (!dr.Read())
            {
                string sql = "Insert into 选课记录 values('" + SID + "','" + cID + "')";
                int i = dao.Execute(sql);
                if (i > 0)
                {
                    MessageBox.Show("选课成功！");
                }
            }
            else
            {
                MessageBox.Show("该课程已选！");
            }
        }

        private void 我的课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stukebiao stukebiao = new Stukebiao(SID);
            stukebiao.Show();
        }
    }
}
