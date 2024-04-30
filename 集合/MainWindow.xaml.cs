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

namespace 集合
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
        private List<int> list = new List<int>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(123);
            list.Add(432);
            list.Add(231);
            list.Add(456);

            ShowListContent();
        }
        private void ShowListContent()
        {
            txtResult.Text = "";
            foreach (object item in list)
            {
                txtResult.Text += item.ToString() +"\n";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list.Insert(1, 6);

            ShowListContent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list.Add(5);

            ShowListContent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            list.Remove(6);
            ShowListContent();
        }
    }
}