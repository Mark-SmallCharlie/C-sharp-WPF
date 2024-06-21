using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_student2
{
    internal class FileStorage
    {

        public FileStorage(string path)
        {
            file = new FileInfo(path);
            if (!file.Exists)
            {
                file.CreateText().Close();
            }
        }

        private FileInfo file;

        public void Add(Student student)
        {
            StreamWriter sw = file.AppendText();
            string line = string.Format("{0}|{1}|{2}|{3}", student.Class, student.Id, student.Name, student.Gender);
            sw.WriteLine(line);
            sw.Close();
        }

        public void Load(List<Student> students)
        {
            StreamReader sr = file.OpenText();
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split('|');
                Student student = new Student();
                student.Class = parts[0];
                student.Id = parts[1];
                student.Name = parts[2];
                student.Gender = parts[3];

                students.Add(student);

                line = sr.ReadLine();
            }
            sr.Close();
        }

        public void Save(List<Student> students)
        {
            // 思路：删除原文件，使用循环将当前的学生信息依次写入文件
            file.Delete();
            StreamWriter sw = file.CreateText();
            foreach (Student student in students)
            {
                string line = string.Format("{0}|{1}|{2}|{3}",
                student.Class, student.Id, student.Name, student.Gender);
                sw.WriteLine(line);
            }
            sw.Close();
        }
    }
}
