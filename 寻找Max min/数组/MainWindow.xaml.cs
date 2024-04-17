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

namespace 数组
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //获取输入的数列字符串
            string numbers = txtsl.Text;
            //将字符串拆分为字符串数组
            string[] numArr = numbers.Split(',');
            //定义一个整形数组，用于存放转换后的整型数
            int[] intArr = new int[numArr.Length];
            //遍历字符串数组，将每个字符串转换为整形数              
            for (int i = 0; i <= numArr.Length; i++)
            {
  
                    intArr[i] = Convert.ToInt32(numArr[i]);
            }
            //最大值，最小值，平均值；
            int max = intArr[0];
            int min = intArr[0];
            int sum = 0;
            for (int i = 0; i < intArr.Length; i++)
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
            double average = (double)sum / intArr.Length;

            // 输出结果  
            txtjg.Text = string.Format("最大值：{0}\n最小值：{1}\n平均值：{2:F2}", max, min, average);
            Console.WriteLine("最大值: " + max);
            Console.WriteLine("最小值: " + min);
            Console.WriteLine("平均值: " + average);
        }
    }
}
        // 求数组中的最大值  
        //static int FindMax(int[] array)
        //{
        //    if (array == null || array.Length == 0)
        //        throw new ArgumentException("数组不能为空或没有元素");

        //    int max = array[0];
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //            max = array[i];
        //    }
        //    return max;
        //}

        // 求数组中的最小值  
        //static int FindMin(int[] array)
        //{
        //    if (array == null || array.Length == 0)
        //        throw new ArgumentException("数组不能为空或没有元素");

        //    int min = array[0];
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //            min = array[i];
        //    }
        //    return min;
  
    // 求数组中的平均值  
    //static double average(int[] array)
    //{
    //    if (array == null || array.length == 0)
    //        throw new argumentexception("数组不能为空或没有元素");

    //    int sum = 0;
    //    foreach (int num in array)
    //    {
    //        sum += num;
    //    }
    //    return (double)sum / array.length;
    //排序
    //    for (int i = 1; i < numarr; i++)
    //    {
    //        for (int j = 0; j < numarr - i - 1; j++)
    //        {
    //            if (numarr[j] > numarr[i])
    //            {
    //                int temp = numarr[j];
    //                numarr[j] = numarr[j + 1];
    //                numarr[j + 1] = temp;
    //            }
    //        }
    //    }


    //}

       
 
