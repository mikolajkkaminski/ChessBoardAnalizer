namespace ChessBoardAnalizer.Models
{
    public class ChessPiece
    {
        public PieceType pieceType;
    }
    public enum PieceType
    {
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }
}
