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
using System.Threading;
using System.Windows.Threading;
using System.Timers;
using System.IO;


namespace 考核2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval =TimeSpan.FromSeconds(1);
            timer.Tick += ShowRandomNum;
        }


        private void ShowRandomNum(object? sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 100);
            txt1.Text = num.ToString();
        }

        private FileStorage fileStorage = 
                new FileStorage(@"D:\Users\XKY\Documents\AA学习小组PPT等文件\C# WPF\考核2\考核2\Numbers.txt");
        private FileInfo file;
        private StreamWriter writer;
        private DispatcherTimer timer = new DispatcherTimer();

        
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // 开启计时器
            timer.Start();           
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            // 停止计时器
            timer.Stop();
            // 将数字写入文件
            fileStorage.Add(txt1.Text);
            fileStorage.open();
            
        }
    }
}