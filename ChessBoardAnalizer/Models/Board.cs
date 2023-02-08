using System.Collections.Generic;

namespace ChessBoardAnalizer.Models
{
    public class Board
    {
        public List<Piece> pieces = new();
        public Board()
        {
            Piece queen = new Piece(PieceType.Queen, 0, 0);
            pieces.Add(queen);
        }

    }
}
