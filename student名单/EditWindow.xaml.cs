using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace student名单
{
    /// <summary>
    /// EditWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private Student _student;
        public Student student
        {
            get { return _student; }
            set
            {
                _student = value;
                if (_student != null)
                {
                    txtClass.Text = _student.Class;
                    txtName.Text = _student.Name;
                    txtId.Text = _student.ID;
                    txtGender.Text = _student.Gender;
                }
                else
                {
                    txtClass.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtId.Text = string.Empty;
                    txtGender.Text = string.Empty;
                }
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if(student == null)
            {
                student = new Student();
            }
            student.Class=txtClass.Text;
            student.Name = txtName.Text;
            student.ID=txtId.Text;
            student.Gender = txtGender.Text;

            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

    }
}
