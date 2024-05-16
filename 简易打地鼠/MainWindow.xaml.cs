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
using System.Windows.Threading;

namespace 打地鼠
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timeTimer.Interval=TimeSpan.FromSeconds(60);
            timeTimer.Tick += TimeTimer_Tick;

            showTimer.Interval = TimeSpan.FromSeconds(1);
            showTimer.Tick += ShowImage;
           
            images[0] = m1;
            images[1] = m2;
            images[2] = m3;
            images[3] = m4;
            images[4] = m5;
            images[5] = m6;
            images[6] = m7;
            images[7] = m8;
            images[8] = m9;
        
        }

        private DispatcherTimer timeTimer = new DispatcherTimer();
        private int time=0;
        private DispatcherTimer showTimer=new DispatcherTimer();
        private Image[] images =new Image[9];
        private int lastImage = -1;
        private int score = 0;
        private int miss = 0;



        private void ShowImage(object? sender, EventArgs e)
        {
            Random rnd =new Random();
            int x=rnd.Next(0, 9);
            images[x].Visibility = Visibility.Visible;
            if(lastImage!=-1)
            {
                if(images[lastImage].Visibility==Visibility.Visible)
                {
                    miss++;
                    labMiss.Content = miss.ToString();
                }
                images[lastImage].Visibility = Visibility.Hidden;
            }
            lastImage = x;
        }
        private void TimeTimer_Tick(object ?sender, EventArgs e)
        {
            time--;
            labTime.Content = time;
            if (time == 0)
            {
                timeTimer.Stop();
                showTimer.Stop();
                MessageBox.Show("Game Over!");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var image in images)
            {
                image.Visibility = Visibility.Hidden;
            }
            labScore.Content = "0";
            labMiss.Content = "0";
            time = 10;
            timeTimer.Start();
            showTimer.Start();            
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            img.Visibility = Visibility.Hidden;
            score++;
            labScore.Content = score.ToString();
        }
    }
}