using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student名单
{
    public class FileStorage
    {
        public FileStorage(string path)
        {
            file = new FileInfo(path);
            if (!file.Exists)
            { 
              //如果文件不存在，则创建文件
              file.CreateText().Close();
            }
        }

        private FileInfo file;

        public void Add(Student student)
        {
          StreamWriter sw = file.AppendText();
            string line = string.Format("{0}|{1}|{2}|{3}",
            student.Class,student.ID,student.Name,student.Gender);// 格式化学生信息为字符串
            // 将格式化后的学生信息写入文件
            sw.WriteLine(line);          
            sw.Close();
        }
        
        public void Load(List<Student> students)
        {
            // 读取文件并解析学生信息
            StreamReader sr = file.OpenText();
            if (sr == null)
            {
                throw new Exception("文件打开失败");
            }
            string line = sr.ReadLine();
            try
            {
                while (line != null)
                {
                    string[] parts = line.Split('|'); 
                    Student student = new Student();
                    student.Class = parts[0];
                    student.ID = parts[1];
                    student.Name = parts[2];
                    student.Gender = parts[3];

                    students.Add(student);

                    line = sr.ReadLine();
                }
            }
            finally
            {
                sr.Close();
            }
        }
           
        
        public void Save(List<Student> students)
        {
            //先删除原有文件,再用循环依次写入当前学生信息
            file.Delete();
            StreamWriter sw = file.CreateText();
            foreach (Student student in students)
            {
                string line = string.Format("{0}|{1}|{2}|{3}",
                student.Class, student.ID, student.Name, student.Gender);
                sw.WriteLine(line);
            }
            sw.Close();

        }
    }
}
