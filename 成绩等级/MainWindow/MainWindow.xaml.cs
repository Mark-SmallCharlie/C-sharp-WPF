using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
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

namespace 成绩等次
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dj = "";
            string strchengji;
            strchengji = txtcj.Text;
            if (Convert.ToInt32(txtcj.Text) < 0 || Convert.ToInt32(txtcj.Text) > 100)
            {
                dj = "erroe!";
            }
            else if (90 <= Convert.ToInt32(txtcj.Text) && Convert.ToInt32(txtcj.Text) <= 100)
            {
                dj = "优秀";
            }
            else if (Convert.ToInt32(txtcj.Text) >= 80 && Convert.ToInt32(txtcj.Text) < 90)
            {
                dj = "良好";
                txtdj.Text = dj;
            }
            else if (Convert.ToInt32(txtcj.Text) >= 70 && Convert.ToInt32(txtcj.Text) < 80)
            {
                dj = "中等";
                txtdj.Text = dj;
            }
            else if (Convert.ToInt32(txtcj.Text) >= 60 && Convert.ToInt32(txtcj.Text) < 70)
            {
                dj = "及格";

            }
            else
            {
                dj = "不及格";

            }
            txtdj.Text = dj;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string grade = txtgrade.Text;
            string fens = "";
            switch (grade)
            {
                case "优秀":
                    fens = "90-100";
                    break;
                case "A":
                    fens = "90-100";
                    break;

                case "良好":
                    fens = "80-90";
                    break;
                case "B":
                    fens = "80-90";
                    break;
               
                case "中等":
                    fens = "70-80";
                    break;
                case "C":
                    fens = "70-80";
                    break;
                
                case "及格":
                    fens = "60-70";
                    break;
                case "D":
                    fens = "60-70";
                    break;
                
                case "不及格":
                    fens = "0-60";
                    break;
                case "E":
                    fens = "0-60";
                    break;
                default:
                    fens = "错误的等次！";
                    break;
            }
            txtfens.Text = fens;
            
        }

        
    }
}


