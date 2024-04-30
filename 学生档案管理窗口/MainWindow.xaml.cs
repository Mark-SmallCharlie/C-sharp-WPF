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

namespace 学生档案管理系统
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
        //在cboXibu加入选项
        private void cboXibu_Loaded(object sender, RoutedEventArgs e)
        {
            cboXibu.Items.Add("计算机科学与技术学院");
            cboXibu.Items.Add("软件工程学院");
            cboXibu.Items.Add("机械工程学院");
            cboXibu.Items.Add("电气工程学院");
            cboXibu.Items.Add("经济管理学院");
            cboXibu.Items.Add("马克思主义学院");
            cboXibu.Items.Add("商务贸易学院");
            
        }
        //在cboBanji加入选项
        private void cboBanji_Loaded(object sender, RoutedEventArgs e)
        {
            cboBanji.Items.Add("软件工程1班");
            cboBanji.Items.Add("软件工程2班");
            cboBanji.Items.Add("软件工程3班");
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtXibu.Text = cboXibu.Text;
            txtBanji.Text = cboBanji.Text;
            txtname1.Text = txtname.Text;
            txtXingbie1.Text = txtXingbie.Text;
            txtShenfz.Text = "4405144684221568";
            txtHome.Text = "beijing";
            txtPhone.Text = "13812345678";
            txtJiankan.Text = "Good";
            if (rbtnAxiao.IsChecked == true)
            {
                txtXiaobu.Text = "A";
            }
            if (rbtnBxiao.IsChecked == true)
            {
                txtXiaobu.Text = "B";
            }
            if (rbtnBiye.IsChecked == true )
            {
                txtLeibie.Text = "毕业生";
            }
            if (rbtnZaidu.IsChecked == true)
            {
                txtLeibie .Text = "在读学生";
            }
            if(rbtnXiuxue.IsChecked == true)
            {
                txtLeibie.Text = "休学";
            }

            lstJulu.Items.Add(txtname.Text + "   " + txtXingbie.Text + "   " + txtShenfz.Text + "   " + txtHome.Text + "   " + txtPhone.Text + "   " + txtJiankan.Text + "   " + txtXiaobu.Text + "  " + txtLeibie.Text);

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstJulu.Items.Add("姓名 " + "  性别  " + "        身份证        " + "  家庭住址  " + "  联系电话  " + "  健康状况  " + "  学号  " + "  类别  " );
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}