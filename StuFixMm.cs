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
    public partial class StuFixMm : Form
    {
        string SID;
        string str;
        public StuFixMm()
        {
            InitializeComponent();
            //textBox2.Text = str;
        }
        public StuFixMm(string sid)
         {
             InitializeComponent();
             SID = sid;
             string sql = "select * from 学生表 where Id='" + SID + "'";
             Dao dao = new Dao();
             dao.Execute(sql);
             IDataReader dr = dao.read(sql);
             dr.Read();
            // textBox1.Text = dr["Password"].ToString(); 
             SID=textBox2.Text;
             dr.Close();

         }
        
         private void button1_Click(object sender, EventArgs e)
         {
             string sql = "Update 学生表 set Password='"+textBox2.Text+"' where Id='"+SID+"'";
             Dao dao = new Dao();
             int i=dao.Execute(sql);
             if (i > 0)
             {
                 MessageBox.Show("修改成功！");
                 this.Close();
             }
             else
            {
                MessageBox.Show("修改失败！");
            }

         }

    }
}
