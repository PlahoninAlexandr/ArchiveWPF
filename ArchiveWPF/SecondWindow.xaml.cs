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

namespace ArchiveWPF
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public ArchiveCLR.ArchiveWrapper wrap;
        public SecondWindow()
        {
            InitializeComponent();
            wrap = new ArchiveCLR.ArchiveWrapper();
        }

        private void SingleFile_Click(object sender, RoutedEventArgs e)
        {
            wrap.selectFile();
        }

        private void AddFile_Click(object sender, RoutedEventArgs e)
        {
            wrap.selectArchive();
        }

        private void Directory_Click(object sender, RoutedEventArgs e)
        {
            wrap.addFileInArchive();
        }
    }
}
