using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace 目录管理
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
            txtml.Text = Directory.GetCurrentDirectory();
            
        }

        private void btnsetml_Click(object sender, RoutedEventArgs e)
        {
            string dirPath = txtml.Text;
            DirectoryInfo dir = Directory.CreateDirectory(dirPath);
        }

        private void btndelml_Click(object sender, RoutedEventArgs e)
        {
            string dirPath = txtml.Text;
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (dir.Exists)
            {
                dir.Delete();
            }

        }
    }
}