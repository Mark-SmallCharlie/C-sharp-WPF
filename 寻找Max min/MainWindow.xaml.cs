using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Max_and_min
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();          // 初始化窗口组件  
        }
        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // 此方法会在txt1文本框的内容改变时被调用  
            // 可以在这里添加处理文本变化的逻辑，但当前是空的
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string numbers =txt1.Text;                                      // 获取txt1文本框中的文本内容，并按逗号分割成字符串数组  
            string[] numArr = numbers.Split(',');
            int[] intArr = new int[numArr.Length];                          // 将字符串数组转换成整数数组
            int max = intArr[0];                                            // 初始化最大值为数组的第一个元素，最小值和总和为0 
            int min = intArr[0];
            int sum = 0;

            try
            {
                for (int i = 0; i < numArr.Length; i++)
                {
                    intArr[i] = Convert.ToInt32(numArr[i]);
                }
                for (int i = 0; i < numArr.Length; i++)                        // 遍历数组，计算最大值、最小值和总和 
                {
                    if (intArr[i] > max)
                    {
                        max = intArr[i];
                    }
                    if (intArr[i] < min)
                    {
                        min = intArr[i];
                    }
                    sum += intArr[i];
                }
            }
            catch (FormatException)
            {
                // 如果输入的不是一个有效的整数（例如浮点数），则显示错误消息  
                MessageBox.Show("请输入整数");
                return; // 退出方法，不继续执行后续代码  
            }
            catch (OverflowException)
            {
                // 如果转换结果超出了int的范围，则显示错误消息  
                MessageBox.Show("输入的数字超出了整数的范围");
                return; // 退出方法，不继续执行后续代码  
            }
            catch (Exception ex)
            {
                // 捕获其他类型的异常  
                MessageBox.Show("发生错误: " + ex.Message);
                return; // 退出方法，不继续执行后续代码  
            }

            for (int i = 0;i<intArr.Length-1;i++)         //冒泡排序
            {
                for (int j = 0;j<intArr.Length-i-1;j++)
                {
                    if (intArr[j] > intArr[j+1])
                    {
                        int temp = intArr[j];
                        intArr[j] = intArr[j+1];
                        intArr[j+1] = temp;
                    }
                }
            }

            string s = "";                                              //s存放排序大小 s初始化为空字符串，用于存放排序后的整数数组元素转换为的字符串形式  
            for (int i = 0; i < intArr.Length; i++)                     //遍历整数数组intArr的每一个元素
            {
                s += string.Format("{0,-3}，", intArr[i]);                //使用string.Format将数组元素格式化为一个至少宽度为3的字符串，并左对齐，然后将这个格式化后的字符串追加到s中    
            }

            double average = (double)sum / intArr.Length;             // 计算平均值 
            txtjg.Text = string.Format("最大值：{0}\n最小值：{1}\n平均值：{2:F2}\n排序后：\n{3}", max, min, average,s);          //文本框输出
        }
            //另一种使用StringBuilder构建排序后的数组字符串表示
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    sb.AppendFormat("{0,-3}", intArr[i]);
            //}
            //string sortedNumbers = sb.ToString();                      // 获取排序后的字符串  
        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) 
            {
                e.Handled = true;
                Button_Click(sender, e);
            }
        }
    }
}