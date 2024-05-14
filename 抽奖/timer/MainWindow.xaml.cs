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
using System.Windows.Threading;

namespace timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += ShowNumber;

        }
        private void ShowNumber(object? sender, EventArgs e)
        {
            int anyNumber=Convert.ToInt32(txtany.Text);
            Random ran = new Random();
            int number = ran.Next(1, anyNumber);
            txtNumber.Text = number.ToString();
        }
        private DispatcherTimer timer=new DispatcherTimer();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            MessageBox.Show("恭喜"+txtNumber.Text+"中奖！");
        }
    }
}