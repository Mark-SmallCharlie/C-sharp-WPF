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


namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComSettingModel modle = new ComSettingModel();
            modle.DigitalQuantityCom = "COM8";
            adam4150 = new ADAM4150(modle);
        }
        private ADAM4150 adam4150;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            adam4150.SetData();
            bool ret = adam4150.DI4;
            if (ret)
            {
               labStatus.Content = "感应到红外";
            }
            else
            {
                labStatus.Content = "未感应到红外";
            }

        }
    }
}
