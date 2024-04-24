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

namespace 类方式矩形计算
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
                double length= GetValue(txtlong1.Text);
                
                rec rec =  new rec(Width,length);

                double area = rec.Area;
                txtmj.Text = string.Format("{0;F2}", rec.Area);
                txtzc.Text = string.Format("{0;F2}", rec.Zc);

            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }

        }

        private double GetValue(string str)
        { 
            if(str=="")
            {
                throw new Exception("输入不能为空！");
            }
            try
            {
                return Convert.ToDouble(str);            
            }
            catch 
            {
                throw new Exception("输入必须是数字！");
            }
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