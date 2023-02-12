using ChessBoardAnalizer.ViewModels;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
        private ChessBoardViewModel viewModel = new();
        private Grid grid = new();
        public MainWindow()
        {
            InitializeComponent();
            InitializeGrid();
            //PopulateGrid();
            //AddQueen();
            //CopyResource();
            CopyResource2();
            Content = grid;
        }

        private void CopyResource2()
        {
            var rect = (Rectangle)FindResource("BlackSquare");
            var newRect = new Rectangle();
            newRect.Fill = rect.Fill;

            Grid.SetColumn(newRect, 0);
            Grid.SetRow(newRect, 0);
            grid.Children.Add(newRect);
        }

        private void CopyResource()
        {
            var rect = (Rectangle)FindResource("WhiteSquare");
            Grid.SetColumn(rect, 0);
            Grid.SetRow(rect, 0);
            grid.Children.Add(rect);

            var newRectangle = new Rectangle();
            PropertyInfo[] properties = typeof(Rectangle).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.CanRead && property.CanWrite)
                {
                    property.SetValue(newRectangle, property.GetValue(rect));
                }
            }

            Grid.SetColumn(newRectangle, 1);
            Grid.SetRow(newRectangle, 0);
            grid.Children.Add(newRectangle);
        }

        private void AddQueen()
        {
            var label = new Label { Content = "Qu" };
            label.VerticalAlignment = VerticalAlignment.Center;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.BorderThickness = new Thickness(2);
            label.BorderBrush = Brushes.BlanchedAlmond;
            Grid.SetColumn(label, 4);
            Grid.SetRow(label, 0);
            grid.Children.Add(label);
        }

        private void InitializeGrid()
        {
            foreach (var i in Enumerable.Range(0, 8))
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }
        
        private void PopulateGrid()
        {
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
        }
    }
}
