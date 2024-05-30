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

namespace WpfApplication2deng
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
            adam4150 =new ADAM4150(model);
        }
        private ADAM4150 adam4150;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool ret = adam4150.OnOff(ADAM4150FuncID.OnDO1);
            if (ret)
            {
                MessageBox.Show("打开成功！");
            }
            else
            {
                MessageBox.Show("打开失败！");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool ret = adam4150.OnOff(ADAM4150FuncID.OffDO1);
            if (ret)
            {
                MessageBox.Show("关闭成功！");
            }
            else
            {
                MessageBox.Show("关闭失败！");
            }
        }
    }
}
