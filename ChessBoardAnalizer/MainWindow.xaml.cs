using ChessBoardAnalizer.Components;
using ChessBoardAnalizer.Models;
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
        private ChessBoardViewModel viewModel = new();
        //private Grid panel = new();
        public MainWindow()
        {
            InitializeComponent();
            Drawing();
        }

        private void Drawing() {
            InitializeGrid();
            DrawBoard();
            PiecesStartGamePositions();
        }

        private void PiecesStartGamePositions()
        {
            DrawPiece(PieceColor.White, PieceType.Queen, 3, 6);
            DrawPiece(PieceColor.White, PieceType.King, 7, 4);
            DrawPiece(PieceColor.Black, PieceType.Knight, 2, 4);
            DrawPiece(PieceColor.White, PieceType.Rook, 2, 4);
            DrawPiece(PieceColor.Black, PieceType.Bishop, 1, 3);
            DrawPiece(PieceColor.White, PieceType.Pawn, 1, 7);
            DrawPiece(PieceColor.Black, PieceType.Pawn, 2, 7);

        }

        private void DrawPiece(PieceColor pieceColor, PieceType pieceType, int rank, int file)
        {
            var piece = new PieceView(pieceColor, pieceType);
            Grid.SetColumn(piece, file);
            Grid.SetRow(piece, rank);
            board.Children.Add(piece);
        }

        private void InitializeGrid()
        {   
            foreach (var i in Enumerable.Range(0, 8))
            {
                board.RowDefinitions.Add(new RowDefinition());
                board.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }
        
        private void DrawBoard()
        {
            var lightSquareColor = new SolidColorBrush(Colors.Azure);
            var darkSquareColor = new SolidColorBrush(Colors.LightSlateGray);
            for (int rank = 0; rank < viewModel.Board.Squares.GetLength(0); rank++)
            {
                for (int file = 0; file < viewModel.Board.Squares.GetLength(1); file++)
                {
                    Rectangle square = new();
                    RenderOptions.SetBitmapScalingMode(square, BitmapScalingMode.HighQuality);
                    //square.Fill = viewModel.Board.Squares[rank, file].LightOrDark ? lightSquareColor : darkSquareColor;
                    square.Fill = viewModel.Board.Squares[rank, file].squareColor == SquareColor.Light ? darkSquareColor : lightSquareColor;
                    Grid.SetRow(square, rank);
                    Grid.SetColumn(square, file);
                    board.Children.Add(square);
                }
            }
        }
    }
}
