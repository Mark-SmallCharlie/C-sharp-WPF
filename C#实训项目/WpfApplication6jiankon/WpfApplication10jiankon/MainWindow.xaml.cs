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
using IPCameraDll;
using System.Web;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Threading;


namespace WpfApplication10jiankon
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IpCamera = new IpCameraHelper("192.168.1.108:6611", "admin","admin");
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(60);
            timer.Tick += timer_Tick;           
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            BitmapImage Bitmap = new BitmapImage();

            HttpWebResponse MyHttpWebResponse = IpCamera.ImageGetHttpResponse(5000);
            if (MyHttpWebResponse.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Fail for Picture");
                return;
            }
            Stream receiveStream = MyHttpWebResponse.GetResponseStream();

            Bitmap.BeginInit();
            Bitmap.StreamSource = receiveStream;
            Bitmap.EndInit();

            img1.Source = Bitmap;

            IpCameraHelper.DispatcherHelper.DoEvents();

            Thread.Sleep(30);

            MyHttpWebResponse.Close();
        }
        private IpCameraHelper IpCamera;
        private DispatcherTimer timer;
        private bool started;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (started)
            {
                MessageBox.Show("Opeaning");
                return;
            }
            timer.Start();
            started = true;     
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IpCamera.TakePhotos(@"F:\666\Snap.jpg");
        }

        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            IpCamera.PanDown();
        }

        private void Image_MouseUp_2(object sender, MouseButtonEventArgs e)
        {
            IpCamera.PanLeft();
        }

        private void Image_MouseUp_3(object sender, MouseButtonEventArgs e)
        {
            IpCamera.PanUp();
        }

        private void Image_MouseUp_4(object sender, MouseButtonEventArgs e)
        {
            IpCamera.PanRight();
        }

    }
}
