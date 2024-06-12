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

namespace 文件管理
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

        private void btnWirte_Click(object sender, RoutedEventArgs e)
        {
            FileInfo fi=new FileInfo(@"D:\Users\XKY\Documents\AA学习小组PPT等文件\C# WPF\目录管理\文件管理\新建文本文档.txt");
            FileStream stream;
            if (!fi.Exists)
            {
                stream = fi.Create();

            }
            else
            {
                stream=fi.OpenWrite();
            }
            string input = txtwirte.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            FileInfo fi = new FileInfo(@"D:\Users\XKY\Documents\AA学习小组PPT等文件\C# WPF\目录管理\文件管理\新建文本文档.txt");
            FileStream stream;
            if (!fi.Exists)
            {
                MessageBox.Show("文件不存在！");
                return;
            }
            else
            {
                stream = fi.OpenRead();
            }
            byte[] buffer = new byte[fi.Length];
            stream.Read(buffer, 0, buffer.Length);
            string output = Encoding.Default.GetString(buffer);
            txtread.Text = output;
        }

        private void txtread_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtwirte_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}