using StudentGradeSystem;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
//using System.Windows.Forms;


namespace StudentGradeSyteam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromMilliseconds(50); // 设置间隔时间
            //timer.Tick += time_tick; // 计时器事件
            //timer.Start(); // 启动计时器
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //登录按钮事件
        private void logic_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                MessageBox.Show("登录成功！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                login();
            }

        }
        private  bool login()
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || comboBox.Text == "")
            {
                MessageBox.Show("请填写完整信息！", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            if(comboBox.Text=="学生")
            {
                string sql = "select *from 学生表 where Id ='" + txtusername.Text + "'and Password='" + txtpassword.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                
                if (dr.Read())
                {

                    string sID = dr["Id"].ToString();
                    StuCtrl stuCtrl = new StuCtrl();
                    stuCtrl.Show();
                    this.Hide();
                    return true;
                    //this.Close();
                }
                else 
                {
                    return false;
                }
            }
            if (comboBox.Text == "教师")
            {
                string sql = "select *from 教师表 where Id ='" + txtusername.Text + "'and Password='" + txtpassword.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    ROOT root = new ROOT();
                    root.Show();
                    this.Hide();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (comboBox.Text == "管理员")
            { 
                if(txtusername.Text=="admin" && txtpassword.Text=="admin")
                {
                    
                    ROOT root = new ROOT();
                    root.Show();
                    this.Hide();
                    return true;
                    //this.Close();
                }
                string sql = "select *from 教师表 where Id ='" + txtusername.Text + "'and Password='" + txtpassword.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    ROOT root = new ROOT();
                    root.Show();
                    this.Hide();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //取消按钮事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            comboBox.Text = "";
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
