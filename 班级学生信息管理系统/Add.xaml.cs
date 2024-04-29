using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 班级信息管理
{
    /// <summary>
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        public delegate void UpateListBoxDelegate(string studentInfo);
        public event UpateListBoxDelegate UpdateListBox;
         // 确定按钮的点击事件处理
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 获取输入的学院、姓名和学号
            string college = textBoxCollege.Text;
            string name = textBoxName.Text;
            string studentID = textBoxStudentID.Text;

            // 将信息拼接成一行文本
            string studentInfo = $"{college}\t{name}\t{studentID}";

            // 触发事件，将信息添加到ListBox中
            UpdateListBox?.Invoke(studentInfo);

            // 关闭窗口
            this.Close();
        }
        
      

    }
}
