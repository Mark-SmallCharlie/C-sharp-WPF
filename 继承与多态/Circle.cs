using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承与多态
{
    // 定义类Circle，继承自抽象类Shape
    public class Circle : Shape
    {
        private double radius;

        // 带一个参数的构造函数
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive number.");
            }
            this.radius = radius;
        }

        // 实现父类的两个抽象方法
        public override double CalculatePerimeter()    //圆的周长
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()         //圆的面积
        {
            return Math.PI * radius * radius;
        }
    }
}
