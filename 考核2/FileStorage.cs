using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace 考核2
{
    internal class FileStorage
    {

        //判断文件是否存在，不存在则创建
        public FileStorage(string path)        // 构造函数
        {
            file = new FileInfo(path);         // 创建文件对象
            // 如果文件不存在，则创建
            if (!file.Exists)
            {
                file.CreateText().Close();
            }
        }
        private FileInfo file;

        public void Add(string content)
        {
            StreamWriter sw = file.AppendText();
            sw.WriteLine(content);
            sw.Close();
        }
        public void open()
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = file.FullName,
                    UseShellExecute = true // 对于文件来说，通常应该为true  
                });
            }
            catch (Exception ex)
            {
                // 捕获异常并处理  
                MessageBox.Show("无法打开文件：" + ex.Message, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //System.Diagnostics.Process.Start(file.FullName);
        }
    }
}
