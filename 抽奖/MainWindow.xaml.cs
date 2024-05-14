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

namespace 抽奖timer
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
        private int number;
        private bool isRunning;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Thread th = new Thread(ShowNumber);
            th.Start();
        }

        private void ShowNumber()
        { 
            Random rnd = new Random();
            isRunning=true;
            while (isRunning)
            {
                number = rnd.Next(1, 101);
                Dispatcher.Invoke(UpdateUI);
                Thread.Sleep(100);
            }
        }
       private void UpdateUI()
        {
            txtNumber.Text =number.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            isRunning=false;
            MessageBox.Show("恭喜" + txtNumber.Text + "中奖！");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            isRunning = false;
           
        }
    }
}