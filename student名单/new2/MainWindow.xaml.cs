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

namespace new_student2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            storage.Load(students);
            lvList.ItemsSource = students;
        }

        private List<Student> students = new List<Student>();
        private FileStorage storage =
            new FileStorage(@"D:\students.txt");

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Editwindow edit = new Editwindow();
            edit.ShowDialog();
            if (edit.student != null)
            {
                students.Add(edit.student);
                lvList.Items.Refresh();
                storage.Add(edit.student);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Student stu = (Student)lvList.SelectedItem;
            Editwindow edit = new Editwindow();
            edit.student = stu;
            edit.ShowDialog();
            lvList.Items.Refresh();
            storage.Save(students);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Student stu = (Student)lvList.SelectedItem;
            students.Remove(stu);
            lvList.Items.Refresh();
            storage.Save(students);
        }

        private void lvList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvList.SelectedItem == null)
            {
                btnEdit.IsEnabled = false;
                btnDelete.IsEnabled = false;
            }
            else
            {
                btnEdit.IsEnabled = true;
                btnDelete.IsEnabled = true;
            }
        }
    }
}