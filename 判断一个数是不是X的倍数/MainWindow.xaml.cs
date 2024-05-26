using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 判断一个数是不是X的倍数
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
            int x;
            x=Convert.ToInt32(sr3.Text);
            //将这个数的各个位上的数加起来并判断是不是3的倍数
            int sum = 0;
            int num = x;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 3 == 0)
            {
                print3.Text = "是";
                int y = x / 3;
                aliquot3.Text = y.ToString();
            }
            else
            {
                print3 .Text = "不是";
                aliquot3.Text = "None";
            }
             
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x;
            x = Convert.ToInt32(sr4.Text);
            //判断看这个数的末两位上的数是否是4的倍数
            int num = x % 100;
            if (num % 4 == 0)
            {
                print4.Text = "是";
                int y = x / 4;
                aliquot4.Text = y.ToString();
            }
            else
            {
                print4.Text = "不是";
                aliquot4.Text = "None";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int x;
            x=Convert.ToInt32(sr5.Text);
            //判断看这个数的末位上的数是否是5或0的倍数
            int num = x % 10;
            if (num % 5 == 0 || num == 0)
            {
                print5.Text = "是";
                int y = x / 5;
                aliquot5.Text = y.ToString();
            }
            else
            {
                print5.Text = "不是";
                aliquot5.Text = "None";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int x;
            x=Convert.ToInt32(sr6.Text);
            //判断看这个数的各个位上的数加起来是否是6的倍数
            int sum = 0;
            int num = x;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 6 == 0)
            {
                print6.Text = "是";
                int y = x / 6;
                aliquot6.Text = y.ToString();
            }
            else if(num%10==0|| num % 10 == 2 || num % 10 == 4 || num % 10 == 6 || num % 10 == 8)
            {
                print6.Text = "是";
                int y = x / 6;
                aliquot6.Text = y.ToString();
            }
            else
            {
                print6.Text = "不是";
                aliquot6.Text = "None";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int x;
            x = Convert.ToInt32(sr37.Text);
            //int sum = 0;
            int num = x;
            //while (num > 0)
            //{
            //    sum += num % 10;
            //    num /= 10;
            //}
            //if (sum > num)
            //{
            //    while (sum > 0) ;
            //}
            //else
            //{
            //    while (sum < 111)
            //    {
            //        sum -= 111;
            //    }
            if (num % 37 == 0)
            {
                print37.Text = "是";
                int y = x / 37;
                aliquot37.Text = y.ToString();
            }
            else
            {
                print37.Text = "不是";
                aliquot37.Text = "None";
            }
            //把x按三位分开求和, 如果结果大于三位数则再求和
            //如果结果等于三位数则判断末位是否为3或7,如果是则是37的倍数,否则不是
            //如果结果小于三位数则减去111,再求和,如果结果等于三位数则判断末位是否为3或7,如果是则是37的倍数,否则不是
            //如果结果大于三位数则循环
            //int X = Convert.ToInt32(sr37.Text);
            //int sum = 0;
            //while (true)
            //{
            //    sum = 0;
            //    while (X > 0)
            //    {
            //        sum += X % 1000;
            //        X /= 1000;
            //    }

            //    if (sum > 999)
            //    {
            //        X = sum;
            //    }
            //    else
            //    {
            //        if (sum < 100)
            //        {
            //            sum -= 111;
            //        }

            //        if (sum < 100)
            //        {
            //            print37.Text = "不是";
            //            aliquot37.Text = "None";

            //        }
            //        else
            //        {
            //            int lastDigit = sum % 10;
            //            if (lastDigit == 3 || lastDigit == 7)
            //            {
            //                print37.Text = "是";
            //                int y = X / 37;
            //                aliquot37.Text = y.ToString();
            //            }
            //            else
            //            {
            //                print37.Text = "不是";
            //                aliquot37.Text = "None";
            //            }
            //            break;
            //        }
            //    }

            // 
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //清除文本框内容
            sr3.Text = "";
            sr4.Text = "";
            sr5.Text = "";
            sr6.Text = "";
            sr37.Text = "";
        }
    }
}
