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

namespace 阶梯电费
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///计算电费
    ///<param name="dian">用电量</param>>
    ///<param name="limit">临界用电量</param>>
    ///<param name="price">阶梯电费单价</param>>
    ///<param name="exprice" >超出电费单价</param>
    ///<returns>应缴电费</returns>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double CalcAmount(double dian, int limit, double price, double exPrice)                       //用电函数的定义
        {
            double amount = 0.0;
            if (limit > dian)
            {
                amount = dian * price;
            }
            else
            {
                amount = limit * price + (dian - limit) * price;
            }
            return amount;
        }

        private double GentianAmount()                 //提示用户输入正确的用电量
        {
            if (txtdian.Text == "")
            {
                MessageBox.Show("请输入用电量");
                return 0;
            }
            double dian = 0;
            try
            {
                dian = Convert.ToDouble(txtdian.Text);
                if (dian < 0)
                {
                    MessageBox.Show("用电量不能为负数。");
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的用电量：");
                return 0;
            }
            return dian;
        }
        private void Button_Click(object sender, RoutedEventArgs e)                    //在按钮里定义A城市的计价标准及运算
        {
            double dian = GentianAmount();
            double amount = CalcAmount(dian, 5, 2.5, 4);
            txtfei.Text = string.Format("{0:F}", amount);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)                  //在按钮里定义B城市的计价标准及运算
        {
            double dian = GentianAmount();
            double amount = CalcAmount(dian, 7, 2.6, 4.2);
            txtfei.Text = string.Format("{0:F}", amount);
        }
    }

}