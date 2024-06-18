using System.Formats.Asn1;
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
using System.Xml.Linq;

namespace student名单
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            liview.ItemsSource = students;
        }

        private List<Student> students = new List<Student>();
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //Student stu = new Student();
            //stu.Class = "321";
            //stu.ID = "123";
            //stu.Name = "231";
            //stu.Gender = "213";
            //students.Add(stu);
            //liview.Items.Refresh();
            EditWindow edit = new EditWindow();
            edit.ShowDialog();
            if (edit.student != null)
            {
                students.Add(edit.student);
                liview.Items.Refresh();
            }

        }

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}