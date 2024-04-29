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

namespace 构造函数矩形计算
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
            try
            {
                double width = GetValue(txtwidth.Text);
                double length = GetValue(txtlong1.Text);

                Rectangle rectangle = new Rectangle(width, length);
                double area = rectangle.Area();
                double perimeter = rectangle.Perimeter();

                txtmj.Text = string.Format("{0:F2}", area); // 使用了冒号(:)而不是分号(;)  
                txtzc.Text = string.Format("{0:F2}", perimeter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double GetValue(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("输入不能为空！");
            }

            if (!double.TryParse(str, out double value))
            {
                throw new Exception("输入必须是有效的数字！");
            }

            return value;

        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}