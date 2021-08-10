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
        public ArchiveWrapper wrap;
        Grid grid;
        public MainWindow()
        {            
            InitializeComponent();
            SelectFile.Visibility = Visibility.Hidden;
            SelectArchive.Visibility = Visibility.Hidden;
            Add.Visibility = Visibility.Hidden;
            ArchiveSize.Visibility = Visibility.Hidden;
            FileSize.Visibility = Visibility.Hidden;
            grid = new Grid();
            wrap = new ArchiveWrapper();
        }

        private void SingleFile_Click(object sender, RoutedEventArgs e)
        {
            wrap.writeArchiveSingle();
        }

        private void Directory_Click(object sender, RoutedEventArgs e)
        {
            wrap.writeArchiveDirectory();
        }

        private void AddFile_Click(object sender, RoutedEventArgs e)
        {
            remove();
            SelectArchive.Visibility = Visibility.Visible;
            SelectFile.Visibility = Visibility.Visible;
            Add.Visibility = Visibility.Visible;
        }

        private void Extract_Click(object sender, RoutedEventArgs e)
        {
            wrap.extractArchive();
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            remove();
            ArchiveSize.Visibility = Visibility.Visible;
            FileSize.Visibility = Visibility.Visible;
        }

        private void File_Click(object sender, RoutedEventArgs e)
        {
            wrap.selectFile();
        }

        private void Dir_Click(object sender, RoutedEventArgs e)
        {
            wrap.selectArchive();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            wrap.addFileInArchive();
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

        private void remove()
        {
            grid.Children.Remove(Directory);
            grid.Children.Remove(SingleFile);
            grid.Children.Remove(AddFile);
            grid.Children.Remove(Draw);
            grid.Children.Remove(Extract);

            Directory.Visibility = Visibility.Hidden;
            SingleFile.Visibility = Visibility.Hidden;
            AddFile.Visibility = Visibility.Hidden;
            Draw.Visibility = Visibility.Hidden;
            Extract.Visibility = Visibility.Hidden;
        }
    }
}
