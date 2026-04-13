using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentGradeSystem
{
    internal class Dao
    {
        private string connectionString = "数据库连接";
        private SqlCommand cmd;
        public Dao()
        {
            cmd = new SqlCommand();
        }
        public SqlConnection connection()
        {
            string str = "Data Source=ThinkBook-KaiLi;Initial Catalog=学生成绩管理系统;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();//打开数据库连接
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand sc = new SqlCommand(sql, connection());
            return sc;
        }
        //用于delete update insert返回受影响的行数
        public int Execute(string sql)
        { 
            return command(sql).ExecuteNonQuery();
        }
        ////用于select语句返回SqlDataReader
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void AddParameter(string parameterName, object value)
        {
            if (cmd == null)
            {
                throw new InvalidOperationException("SqlCommand未初始化");
            }
            cmd.Parameters.AddWithValue(parameterName, value);
        }
    }
}
