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

namespace new_student2
{
    /// <summary>
    /// Editwindow.xaml 的交互逻辑
    /// </summary>
    public partial class Editwindow : Window
    {
        public Editwindow()
        {
            InitializeComponent();
        }

        private Student? _student;
        public Student student
        {
            get { return _student; }
            set
            {
                _student = value;
                if (_student != null)
                {
                    txtClass.Text = _student.Class;
                    txtId.Text = _student.Id;
                    txtName.Text = _student.Name;
                    txtGender.Text = _student.Gender;
                }
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (student == null)
            {
                _student = new Student();
            }
            student.Class = txtClass.Text;
            student.Id = txtId.Text;
            student.Name = txtName.Text;
            student.Gender = txtGender.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
