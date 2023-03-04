using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ChessBoardAnalizer.Models;

namespace ChessBoardAnalizer.Components
{
    /// <summary>
    /// Interaction logic for PieceView.xaml
    /// </summary>
    public partial class PieceView : UserControl
    {

        public PieceView(PieceColor pieceColor = PieceColor.White, PieceType pieceType = PieceType.King) 
        {
            Path = $"pack://application:,,,/ChessBoardAnalizer;component/Assets/ChessPieces{pieceColor.ToString()}/{pieceType.ToString()}.png";
            InitializeComponent();
        }



        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(string), typeof(PieceView),
            new PropertyMetadata("pack://application:,,,/ChessBoardAnalizer;component/Assets/ChessPiecesWhite/Knight.png"));
        //new PropertyMetadata(String.Empty));
    }
}
