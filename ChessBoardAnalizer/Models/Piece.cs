namespace ChessBoardAnalizer.Models
{
    public class Piece
    {
        public PieceType pieceType;
        public int file;
        public int rank;

        public Piece(PieceType pieceType, int file, int rank)
        {
            this.pieceType = pieceType;
            this.file = file;
            this.rank = rank;
        }
        public string name = "Queen";
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
