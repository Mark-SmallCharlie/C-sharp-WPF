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
    public partial class Stukebiao : Form
    {
        string SID;
        public Stukebiao(string sID)
        {
            SID = sID;
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from 选课记录 where sid='" + SID + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string cID = dr["cid"].ToString();
                string sql2 = "select * from 课程表 where Id='" + cID + "'";
                IDataReader dr2 = dao.read(sql2);
                dr2.Read();
                string a, b, c, d;
                a = dr2["Id"].ToString();
                b = dr2["Name"].ToString();
                c = dr2["Grade"].ToString();
                d = dr2["Teacher"].ToString();
                string[] str = { a, b, c, d };
                dataGridView1.Rows.Add(str);
                dr2.Close();
            }
            dr.Close();

        }

        private void Stukebiao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 取消这门课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "delete from 选课记录 where sid='" + SID + "' and cid='" + cID + "'";
            Dao dao = new Dao();
            dao.Execute(sql);
            Table();
        }
    }
}
