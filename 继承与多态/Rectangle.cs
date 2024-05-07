using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承与多态
{
    // 定义类Rectangle，继承自抽象类Shape
    public class Rectangle : Shape
    {

        private double length;
        private double width;

        // 带两个参数的构造函数
        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Length and width must be positive numbers.");
            }
            this.length = length;
            this.width = width;


        }

        // 实现父类的两个抽象方法
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public override double CalculateArea()
        {
            return length * width;
        }
        

    }

}
