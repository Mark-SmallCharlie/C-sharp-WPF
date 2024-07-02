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
using System.Diagnostics.Tracing;

namespace _0000跑马灯
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            txt1.Text = "0000";
        }
        private DispatcherTimer timer;
        private int iCounter = 0;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            //string txt=txt1.Text;
            //txt = txt.Substring(1);
            //iCounter++;
            //txt += iCounter.ToString();
            //txt1.Text = txt;
            //if (iCounter == 5)
            //{ 
            //    iCounter = 0;
            //    txt1.Text = "0000";
            //}
            txt1.Text=txt1.Text.Substring(1)+(++iCounter).ToString();
            if (iCounter == 5)
            { 
                iCounter = 0;
                txt1.Text = "0000";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}