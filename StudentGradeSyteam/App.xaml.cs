using StudentGradeSystem;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudentGradeSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // 创建并显示Stu窗口
            //StuCtrl stuCtrl = new StuCtrl();
            //stuCtrl.Show();
        }
    }
}
