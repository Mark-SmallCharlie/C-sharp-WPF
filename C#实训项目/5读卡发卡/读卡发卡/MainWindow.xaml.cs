
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
using MWRDemoDll;

namespace 读卡发卡
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
            ResultMessage ret = MifareRFEYE.Instance.Search();
            if(ret.Result!=Result.Success)
            {
                MessageBox.Show(ret.OutInfo);
                return;
            }
            lab1.Content = ret.Model;
            MWRDemoDll.MifareRFEYE.Instance.Auth();
            ResultMessage data = MifareRFEYE.Instance.Read();
            if (data.Result == Result.Success)
            {
                MessageBox.Show(ret.OutInfo);
                return;
            }
            string mes = Encoding.Default.GetString((byte[])data.Model);
            txt1.Text = mes;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResultMessage ret = MifareRFEYE.Instance.Search();
            if (ret.Result != Result.Success)
            {
                MessageBox.Show(ret.OutInfo);
                return;
            }
            lab1.Content = ret.Model;
            MWRDemoDll.MifareRFEYE.Instance.Auth();
            string databuff = txt1.Text;
            if (databuff.Length > 16)
            {
                MessageBox.Show("数据长度不能超过16字节！当前数据长度为：{databuff.Length}字节。");
                return;
            }
            databuff = databuff.PadRight(16);
            byte[] data = Encoding.Default.GetBytes(databuff);
            ResultMessage msg=MWRDemoDll.MifareRFEYE.Instance.Write(CardDataKind.CardID,data);
            if (msg.Result != Result.Success)
            {
                MessageBox.Show("写入成功！");
            }
            else
            {
                MessageBox.Show(msg.OutInfo);
            }
        }
    }
}