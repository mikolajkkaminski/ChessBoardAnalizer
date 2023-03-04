using ChessBoardAnalizer.Models;

namespace ChessBoardAnalizer.ViewModels
{
    public class ChessBoardViewModel: ViewModelBase
    {
        public Board Board = new();
        public ChessBoardViewModel()
        {
            Piece Queen = new Piece(PieceColor.Black, PieceType.Queen, 0, 0);
            Board.Pieces.Add(Queen);
        }

        public static string PieceNameToDisplay(PieceType piece) => piece switch
        {
            PieceType.Queen => "Qu",
            _ => ""
        };
    }
}
