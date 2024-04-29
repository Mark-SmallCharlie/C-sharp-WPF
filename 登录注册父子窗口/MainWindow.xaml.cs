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

namespace WpfApp1
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
            WindowState = WindowState.Maximized;                                                 //最大化
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;                                                   //还原
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;                                                    //最小化
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();    
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)                        //注册界面
        {
            zhuc zhuce = new zhuc();
            zhuce.Owner = this;  
            zhuce.WindowStartupLocation=WindowStartupLocation.CenterOwner; 
            zhuce.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)                     //登录界面
        {
            denl denl = new denl();
            denl.Owner = this;
            denl.Show();
        }
    }
}
