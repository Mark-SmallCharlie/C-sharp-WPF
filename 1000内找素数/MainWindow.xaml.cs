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

namespace 找1000内素数_for_
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
            int i;
            string a = " ";
            for( i=2;i<=n; i++)
            {
                bool isPrime = true;
                for(int j=2;j<i/2;j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }   
                } 
                if(isPrime)
                    {
                        a += i + " ";
                    }
            }
            txtjg.Text = a;
        }
    }
}
