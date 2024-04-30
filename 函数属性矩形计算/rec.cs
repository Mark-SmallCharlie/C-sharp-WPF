using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace 类方式矩形计算
{
    internal class rec
    {
        public rec(double intputWidth,double inputLength,double intputArea, double intputzc) 
        {
            Width = intputWidth;
            lenght = inputLength;
            area = intputArea;
            zc = intputzc;
        }

        public rec(double width, double length)
        {
            this.width = width;
            Length = length;
        }

        private double width;
        private double lenght;
        private double area;
        private double zc;

        public double Width 
        {
            get { return width; }
            set
            {  
                if (value <= 0)
                {
                    throw new Exception("矩形宽度必须大于0！");
                }
                width = value;
            } 
        }

        public double Length
        {
            get { return lenght; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("矩形长度必须大于0！");
                }
                lenght = value;
            }

        }
        public double Area
        {
            get { return area = lenght * width; }
        }
        public double Zc
        {
            get { return zc =2*(lenght+width); }
            //set { zc =2*(lenght*width); }
        }

        

    }
}
