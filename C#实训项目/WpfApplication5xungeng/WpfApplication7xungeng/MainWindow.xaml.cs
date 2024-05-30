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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Eluxun;
using IObjectSafetyTLB;


namespace WpfApplication7xungeng
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            solid=new SOLID();
            solid.CommPort=5;
        }
        private SOLID solid;
         
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string serialNumber=solid.GetDivceSerialNumber();
            if (serialNumber == "-1")
            {
                MessageBox.Show("巡更设备未连接");
                return;
            }
            int count = solid.ReadDivceRecordWeb();
            if (count < 0)
            {
                MessageBox.Show("获取巡更记录失败");
            }
            if (count == 0)
            {
                txt1.Text = "无巡更记录";
                return;
            }
            txt1.Text = " ";
            for (int i = 0; i < count; i++)
            {
                string record = solid.ReadDateWeb(i);
                string xgMonth = record.Substring(4, 2);
                string xgDay = record.Substring(6, 2);
                string xgHour = record.Substring(8, 2);
                string xgMinute = record.Substring(10, 2);
                string xgSecond = record.Substring(12, 2);
                string xgCardNo = record.Substring(14);

                txt1.Text += string.Format("第{0}条记录为：人员卡号003001；时间:{1}-{2} {3}:{4}:{5}；地点卡号：{6}\r\n",
                    i + 1, xgMonth, xgDay, xgHour, xgMinute, xgSecond, xgCardNo);
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string serialNumber = solid.GetDivceSerialNumber();
            if (serialNumber == "-1")
            {
                MessageBox.Show("巡更设备未连接");
                return;
            }
            string ret= solid.DelDivceData();
            if (ret== "1")
            {
                MessageBox.Show("Success for Del");
                txt1.Text = "   ";
            }
            else
            {
                MessageBox.Show("Fail for Del");
                return;
            }
        }
    }
}
