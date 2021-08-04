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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ArchiveCLR;

namespace ArchiveWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string str;
        public string path;
        public string outname;
        public List<string> argv;
        public ArchiveWrapper wrap;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SingleFile_Click(object sender, RoutedEventArgs e)
        {
            wrap.writeArchiveSingle(str, path, argv, outname);
        }

        private void Directory_Click(object sender, RoutedEventArgs e)
        {
            wrap.writeArchiveDirectory(str, path, argv, outname);
        }
    }
}
