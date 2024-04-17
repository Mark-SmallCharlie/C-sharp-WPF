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

namespace WpfApp42
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
            double water = GetWaterAmount();
            double amount = CalcAmount(water, 5, 2.5, 4);
            txtAmount.Text = string.Format("{0:F}", amount);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double water = GetWaterAmount();
            double amount = CalcAmount(water, 7, 2.6, 4.2);
            txtAmount.Text = string.Format("{0:F}", amount);
        }

        private double GetWaterAmount()
        {
            if(txtWater.Text == "")
            {
                MessageBox.Show("请输入用水量。");
                return 0;
            }
            double water = 0;
            try
            {
                water=Convert.ToDouble(txtWater.Text);
                if(water<0)
                {
                    MessageBox.Show("用水量不能为负数。");
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的用水量。");
                return 0;
            }
            return water;
        }

        /// <summary>
        /// 水费计算
        /// </summary>
        /// <param name="water">用水量</param>
        /// <param name="limit">一阶临界水量</param>
        /// <param name="price">一阶水费单价</param>
        /// <param name="exPrice">超阶水费单价</param>
        /// <returns>应缴水费</returns>
        private double CalcAmount(double water, int limit, double price, double exPrice)
        {
            double amount= 0;
            if (water <= limit)
            {
                amount = water * price;
            }
            else
            {
                amount = limit * price + (water - limit) * exPrice;
            }
            return amount;
        }
    }
}