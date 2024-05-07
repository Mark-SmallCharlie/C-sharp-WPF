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

namespace 继承与多态
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
                double Width = Convert.ToDouble(txtWidth.Text);
                double Length = Convert.ToDouble(txtLength.Text);
                
                Rectangle rectangle = new Rectangle(Width, Length);
                double CalculateArea = rectangle.CalculateArea();
                double CalculatePerimeter=rectangle.CalculatePerimeter();

                txtArea.Text = string.Format("{0:F2}", CalculateArea);
                txtPerimeter.Text = string.Format("{0:F2}", CalculatePerimeter);

                double Radius = Convert.ToDouble(txtRadius.Text);

                Circle circle = new Circle(Radius);
                double CalculateCircumArea = circle.CalculateArea();
                double CalculateCircumference = circle.CalculatePerimeter();

                txtCmj.Text = string.Format("{0:F2}", CalculateArea);
                txtCzc.Text = string.Format("{0:F2}", CalculateCircumference);

                if (!double.TryParse(txtWidth.Text, out double width) || !double.TryParse(txtLength.Text, out double length) || Width <= 0 || Length <= 0)
                {
                    throw new Exception("请输入矩形的正确长和宽！");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

           
            
        }

        private void GetValue(string str)
        {
            if (Width<=0||Left<=0)
            {
                throw new Exception("请输入正确的数字！");
            }
            
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}