using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 矩形周长面积和圆
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)           //矩形按钮函数
        {
            double length, width, area, zc;                    //double 定义长，宽，面积及周长
            string strlong, strwidth;                          //定义长，宽输入常量
            strlong = txtlong.Text;                            //常量赋值给输入文本框
            strwidth = txtwidth.Text;
            try
            {
                length = Convert.ToDouble(strlong);                //尝试异常处理 数值对象转换
                width = Convert.ToDouble(strwidth);                //
                if (length <= 0 || width <= 0)
                {
                    throw new Exception("输入正数！");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("输入正确的数字!");
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
          

            area = length + width;                             //公式定义
            zc = 2 * (length + width);          

            string strArea = area.ToString();                  //常量定义输出
            string strZc = zc.ToString();
            txtjieguo.Text="面积=" + strArea + ",周长=" + strZc;       //输出文本
            

            //string jieguo = string.Format("面积={0},周长={1}", area, zc);
            //txtjieguo.Text = jieguo;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)          //圆按钮函数
        {
            double banji, mianji,yzc;                                          //double 定义半径面积及周长
            string strbj;                                                      //string 半径
            strbj = txtbj.Text;                                                //输入文本对应
                try
                {
                    banji = Convert.ToDouble(strbj);                                   // try函数 
                    if(banji<=0)
                    {
                        throw new Exception("输入正数！");
                    }
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("输入正确的数字!");
                    return;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            mianji = 3.1415926 * banji * banji;                                //公式定义
            yzc = 2 * 3.1415926 * banji;                                       //

            string strmianji = mianji.ToString();                              //
            string stryzc = yzc.ToString();                                    //         
            txtmianji.Text = strmianji;                                        //输出文本
            txtyzc.Text = stryzc;

        }
    }
}
