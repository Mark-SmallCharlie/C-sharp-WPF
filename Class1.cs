using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    class Class1
    {

    }
    //写一个学生类，包含姓名、学号、成绩三个属性，并实现三个方法：
    //1. 输入学生信息：输入姓名、学号、成绩，并将其存储到学生类中。
    //2. 输出学生信息：输出学生的姓名、学号、成绩。
    //3. 计算平均成绩：计算学生的平均成绩，并输出。
    class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Grade { get; set; }

        public void Input()
        {
            Console.WriteLine("请输入学生姓名：");
            Name = Console.ReadLine();
            Console.WriteLine("请输入学生学号：");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入学生成绩：");
            Grade = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("学生姓名：{0}", Name);
            Console.WriteLine("学生学号：{0}", ID);
            Console.WriteLine("学生成绩：{0}", Grade);
        }
}
}
