using ChessBoardAnalizer.ViewModels;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ChessBoardAnalizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ChessBoardViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new();
            InitializeGrid();
            //TestComponetReusability();
        }

        private void TestComponetReusability()
        {
            Grid grid = new Grid();

            foreach (var i in Enumerable.Range(0, 8))
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            Content = grid;
        }

        private void InitializeGrid()
        {
            Grid grid = new Grid();

            foreach (var i in Enumerable.Range(0, 8))
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            //var white = new Rectangle { Fill = new SolidColorBrush(Colors.Azure) };

            //Grid.SetColumn(white, 0);
            //Grid.SetRow(white, 0);
            //grid.Children.Add(white);

            //var black = new Rectangle { Fill = new SolidColorBrush(Colors.Azure) };

            //Grid.SetColumn(black, 0);
            //Grid.SetRow(black, 0);
            //grid.Children.Add(black);

            int file = 0;
            int rank = 0;
            var white = new SolidColorBrush(Colors.Azure);
            var black = new SolidColorBrush(Colors.LightSlateGray);

            while (file <= 7 && rank <= 7)
            {
                Rectangle square = (file % 2 == 0 && rank % 2 == 0) ||
                                   (file % 2 == 1 && rank % 2 == 1)
                                   ? new Rectangle { Fill = white }
                                   : new Rectangle { Fill = black };

                Grid.SetColumn(square, file);
                Grid.SetRow(square, rank);
                grid.Children.Add(square);
                if (file == 7)
                {
                    file = 0;
                    rank += 1;
                }
                else
                {
                    file++;
                }
            }
            Content = grid;
        }
    }
}
