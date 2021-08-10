using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace ArchiveWPF
{
    /// <summary>
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ArchiveCLR.ArchiveWrapper wrap;

        public string path;
        public float asdd;
        public int ddd;
        public string zzz;
        public ThirdWindow()
        {
            InitializeComponent();
            wrap = new ArchiveCLR.ArchiveWrapper();
        }

        private void ArchiveSize_Click(object sender, RoutedEventArgs e)
        {
            wrap.DoArchiveParam();
            FourthWindow win4 = new FourthWindow(wrap);
            win4.ShowDialog();
        }

        private void FileSize_Click(object sender, RoutedEventArgs e)
        {
            wrap.DoFileParam();
            FourthWindow win4 = new FourthWindow(wrap);
            win4.ShowDialog();

        }
    }
}
