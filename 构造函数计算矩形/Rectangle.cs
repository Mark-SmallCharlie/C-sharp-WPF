using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数矩形计算
{
   
    public class Rectangle
    {
        private double _width;
        private double _length;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("矩形的长度必须大于0！");
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("矩形的宽度必须大于0！");
                _width = value;
            }
        }

        public double Perimeter()
        {
            return 2 * (_length + _width);
        }

        public double Area()
        {
            return _length * _width;
        }
    }
    public class FormWindow
    {
        public void CalculateRectangleProperties()
        {
            string lengthInput = "5"; // 这里应该是从用户输入获取的字符串  
            string widthInput = "10"; // 这里应该是从用户输入获取的字符串  

            double length = GetValue(lengthInput);
            double width = GetValue(widthInput);

            Rectangle rectangle = new Rectangle(length, width);
            double perimeter = rectangle.Perimeter();
            double area = rectangle.Area();

            // 现在可以使用perimeter和area变量  
            Console.WriteLine($"矩形的周长是: {perimeter}");
            Console.WriteLine($"矩形的面积是: {area}");
        }

        // 其他窗体类成员和方法...  

        public double GetValue(string input)
        {
            double value;
            bool isSuccessful = double.TryParse(input, out value);

            if (!isSuccessful || value <= 0)
            {
                throw new ArgumentException("输入的值必须是一个大于0的正数！");
            }

            return value;
        }
     }
}
