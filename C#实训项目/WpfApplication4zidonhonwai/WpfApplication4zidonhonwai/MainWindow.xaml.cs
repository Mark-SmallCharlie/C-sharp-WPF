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
using ComLibrary;
using DigitalLibrary;
using System.Windows.Threading;


namespace WpfApplication4zidonhonwai
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComSettingModel model = new ComSettingModel();
            model.DigitalQuantityCom = "COM8";
            adam4150=new ADAM4150(model);

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
        }
        private ADAM4150 adam4150;
        private DispatcherTimer timer;
        void timer_Tick(object sender, EventArgs e)
        {
            adam4150.SetData();
            if (adam4150.DI4)
            {
                labStatus.Content = "感应到红外";
            }
            else
            {
                labStatus.Content = "未感应到红外";
            }
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
