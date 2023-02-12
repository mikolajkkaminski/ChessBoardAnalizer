using ChessBoardAnalizer.Models;

namespace ChessBoardAnalizer.ViewModels
{
    public class ChessBoardViewModel: ViewModelBase
    {
        public Board board = new();
        public ChessBoardViewModel()
        {
            Piece Queen = new Piece(PieceType.Queen, 0, 0);
            board.pieces.Add(Queen);
        }

        public static string PieceNameToDisplay(PieceType piece) => piece switch
        {
            PieceType.Queen => "Qu",
            _ => ""
        };
    }
}
