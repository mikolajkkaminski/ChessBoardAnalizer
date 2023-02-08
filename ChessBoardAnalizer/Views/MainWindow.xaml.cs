using ChessBoardAnalizer.ViewModels;
using System.Windows;

namespace ChessBoardAnalizer.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ChessBoardViewModel chessBoard;
        public MainWindow()
        {
            InitializeComponent();
            chessBoard = new();
        }
    }
}
