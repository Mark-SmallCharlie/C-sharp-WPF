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

            storage.Load(students);
            liview.ItemsSource = students;
        }

        private List<Student> students = new List<Student>();
        private FileStorage storage=
            new FileStorage(@"D:\\Users\\XKY\\Documents\\AA学习小组PPT等文件\\C# WPF\\student名单\\student名单\\students.txt");
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //Student stu = new Student();
            //stu.Class = "321";
            //stu.ID = "123";
            //stu.Name = "231";
            //stu.Gender = "213";
            //students.Add(stu);
            //liview.Items.Refresh();
            EditWindow edit = new EditWindow(); // 创建并显示编辑窗口
            bool? result=edit.ShowDialog();
            if (result == true && edit.student != null)       // 检查编辑窗口中的学生对象是否为空
            {
                students.Add(edit.student);// 将学生对象添加到学生列表中
                liview.Items.Refresh();   // 刷新列表视图
                storage.Add(edit.student);// 将学生对象添加到存储中
                storage.Add(edit.student);// 将学生对象添加到存储中
            }
            //students.Add(edit.student);
            //liview.Items.Refresh();
            //storage.Save(students);


        }

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            // 获取选中的学生对象
            Student stu = (Student)liview.SelectedItem;
            if (stu != null)
            {
                // 显示编辑窗口
                EditWindow edit = new EditWindow();
                // 将选中的学生对象传递给编辑窗口
                edit.student = stu;
                // 显示编辑窗口
                bool? result = edit.ShowDialog();
                // 如果编辑窗口返回了true，则更新学生列表和存储
                if (result == true)
                {
                    liview.Items.Refresh();
                    storage.Save(students);
                }
            }
        }
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            // 获取选中的学生对象
            Student stu = (Student)liview.SelectedItem;
            // 从学生列表中移除选中的学生
            if (stu != null)
            {
                students.Remove(stu);
                // 刷新列表视图
                liview.Items.Refresh();
                // 保存更新后的学生列表
                storage.Save(students);
            }
        }

        private void liview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 选中学生列表中的项时，启用编辑和删除按钮
            // 否则，禁用编辑和删除按钮
            //btnedit.IsEnabled = liview.SelectedItem != null;
            //btnDel.IsEnabled = liview.SelectedItem != null;
            if (liview.SelectedItem == null)
            {
                btnedit.IsEnabled = false;
                btnDel.IsEnabled = false;
            }
            else
            {
                btnedit.IsEnabled = true;
                btnDel.IsEnabled = true;
            }
        }

        
    }
}