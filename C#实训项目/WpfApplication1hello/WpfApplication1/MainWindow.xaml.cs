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
using LEDLibrary;
using ComLibrary;

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

            player = new LEDPlayer("COM8");  //使用指定的COM口序号创建LED操作对象，并赋值player成员变量
        }

        private LEDPlayer player;//LED操作对象成员

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string result = player.DisplayText(tb_LEDText.Text);
            if (result != "")
            {
                MessageBox.Show(result);
            }
        }

        
    }
}
