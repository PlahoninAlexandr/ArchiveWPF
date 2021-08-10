using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for FourthWindow.xaml
    /// </summary>
    public partial class FourthWindow : Window
    {
        public ArchiveCLR.ArchiveWrapper wrap;
        public string tmp;

        public FourthWindow(ArchiveCLR.ArchiveWrapper obj)
        {
            wrap = obj;
            InitializeComponent();
            Draw();
        }

        Random random = new Random();
        public void Draw()
        {
            for (int i = 0; i < wrap.num; ++i) tmp += wrap.name[i] + ",";

            string[] aLabels = tmp.Split(',');
            _createLabels(myGrid, aLabels);
            tmp = "";

            for (int i = 0; i < wrap.num; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                myGrid.ColumnDefinitions.Add(colDef);

                for(int j = 0; j < 3; j++)
                {
                    RowDefinition rowDef = new RowDefinition();
                    myGrid.RowDefinitions.Add(rowDef);
                }

                Color color = i % 2 == 0 ? Colors.Red : Colors.Blue;
                wrap.height[i] += 1;
                _placeSingleColorColumn(myGrid, color, wrap.height[i], i, 13);
            }
            
            for (int i = 0; i < wrap.num; ++i) tmp += wrap.size[i] + ",";

            aLabels = tmp.Split(',');
            _createLabels(myGrid, aLabels);
        }

        private void _placeSingleColorColumn(Grid grid, Color color, int height, int colNum, int maxHeight)
        {
            Brush brush = new SolidColorBrush(color);

            Rectangle rect = new Rectangle();
            rect.Fill = brush;
            Grid.SetColumn(rect, colNum);
            Grid.SetRow(rect, maxHeight - height);
            Grid.SetRowSpan(rect, height);

            grid.Children.Add(rect);
        }

        private void _createLabels(Grid grid, string[] labels)
        {
            RowDefinition rowDefnLabels = new RowDefinition();
            grid.RowDefinitions.Add(rowDefnLabels);

            for (int i = 0; i < labels.Length; i++)
            {
                TextBlock block = new TextBlock();
                block.Text = labels[i];
                block.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                Grid.SetColumn(block, i);
                Grid.SetRow(block, grid.RowDefinitions.Count);
                grid.Children.Add(block);
            }
        }
    }
}
