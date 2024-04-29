using System.Runtime.CompilerServices;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace 班级信息管理
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //订阅AddWindow中的Update事件，当AddWindow关闭时，刷新班级列表
            //在MainWindow中订阅AddWindow的Update事件
            //Add add = new Add();
            //add.UpdateListBox += Add_UpdateListBox;
        }
        //private void Add_UpdateListBox(string studentInfo)
        //{
        //    //刷新班级列表
        //    lstClass.Items.Add(studentInfo);
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //从文本框中获取输入的班级信息，并添加到班级列表中
            string className = txtClass.Text.ToString();
            if (className != string.Empty)
            {
                lstClass.Items.Add(className);
            }
            //弹出添加班级窗口Add
            //Add add = new Add();
            //add.Owner = this;
            //add.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //add.Show();      

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //从班级列表中删除选中的班级信息
            int nIndex = lstClass.SelectedIndex;
            if (nIndex >= 0)
            {
                lstClass.Items.RemoveAt(nIndex);
            }
            MessageBox.Show("你删除了第" + (nIndex + 1) + "项班级信息！");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string nClass = txtClass.Text; // txtClass.Text 已经是 string 类型，无需调用 ToString()  

            int nIndex = -1;

            // 遍历 ListBox 的项来查找包含 nClass 的项  
            for (int i = 0; i < lstClass.Items.Count; i++)
            {
                if (nIndex >= 0 && nClass != string.Empty)
                {
                    nIndex = i;
                    break; // 找到后退出循环  
                }
            }

            // 如果找到了项，则设置其为选中状态  
            if (nIndex != -1)
            {
                lstClass.SelectedIndex = nIndex; // 设置 SelectedIndex 来选中项  
                                                 // 如果 SelectionMode 允许多选，并且你想要添加到 SelectedItems 集合中  
                                                 // lstClass.SelectedItems.Add(lstClass.Items[nIndex]);  
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //根据选中项的index,从班级列表中获取相应的班级信息
            int nIndex = lstClass.SelectedIndex;
            string nClass = txtClass.Text.ToString();
            if (nIndex >= 0 && nClass != string.Empty)
            {
                lstClass.Items[nIndex] = nClass;
                lstClass.Items.Insert(nIndex, true);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //显示List Box中的总数项
            txtCount.Text = lstClass.Items.Count.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //清除ListBox中的所有项
            lstClass.Items.Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] array = new string[] { "管理员", "学生", "教师" };
            cboUser.ItemsSource = array;
            //根据用户类型，设置按钮是否可用
            if (Convert.ToString(cboUser.SelectedItem) == "管理员")
            {
                _ = btnAdd.IsEnabled == true;
                _ = btnDelete.IsEnabled == true;
                _ = btnClear.IsEnabled == true;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //清空输入框
            txtClass.Text = "";
        }

        private void teacher_Checked(object sender, RoutedEventArgs e)
        {
            if (teacher.IsChecked == true)
            {
                MessageBox.Show("教师权限！");
                btnAdd.IsEnabled = true;
                btnDelete.IsEnabled = true;
                btnAll.IsEnabled = true;
                btnLookfor.IsEnabled = true;
                btnClear.IsEnabled = false;
                btnUpdate.IsEnabled = false;
            }
        }
        private void admin_Checked(object sender, RoutedEventArgs e)
        {
            if (admin.IsChecked == true)
            {
                MessageBox.Show("管理员权限！");
                btnAdd.IsEnabled = true;
                btnDelete.IsEnabled = true;
                btnAll.IsEnabled = true;
                btnLookfor.IsEnabled = true;
                btnClear.IsEnabled = true;
                btnUpdate.IsEnabled = true;
            }
        }
        private void student_Checked_1(object sender, RoutedEventArgs e)
        {
            if (student.IsChecked == true)
            {
                MessageBox.Show("学生权限！");
                btnAdd.IsEnabled = false;
                btnDelete.IsEnabled = false;
                btnClear.IsEnabled = false;
                btnUpdate.IsEnabled = false;

            }
        }

    }
}       

