namespace ChessBoardAnalizer.Models
{
    public class Piece
    {
        public Piece(PieceColor pieceColor, PieceType pieceType, int file, int rank)
        {
            this.pieceColor = pieceColor;
            this.pieceType = pieceType;
            this.file = file;
            this.rank = rank;
        }

        public PieceColor pieceColor;
        public PieceType pieceType;
        public int file;
        public int rank;
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

    public enum PieceColor
    {
        White, Black
    }
}
