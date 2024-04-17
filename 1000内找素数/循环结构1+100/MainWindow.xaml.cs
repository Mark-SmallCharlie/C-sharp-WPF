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

namespace 循环结构1_100
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
            int n;
            n = Convert.ToInt32(txt1.Text);
            int sum;
            sum = 0;
            int i = 1;
            //while (i<=n)
            //{
            //    sum += i;
            //    i++;
            //}
            //do
            //{
            //    sum += i;
            //    i++;
            //}
            //while (i <= n);
            for (i=1;i <= n; i++)
            {
                sum += i;
            }
            txtjg.Text=sum.ToString();
        }
    }
}
