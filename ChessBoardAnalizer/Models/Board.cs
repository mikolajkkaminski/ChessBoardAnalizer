using System.Collections.Generic;

namespace ChessBoardAnalizer.Models
{
    public class Board
    {
        public Board()
        {
            Piece queen = new Piece(PieceColor.White, PieceType.Queen, 0, 0);
            Pieces.Add(queen);
            DistriburteSquareColors();
        }

        public List<Piece> Pieces { get; set; } = new();
        public Square[,] Squares { get; set; } = new Square[8, 8];

        private void DistriburteSquareColors()
        {
            int file = 0;
            int rank = 0;

            while (file <= 7 && rank <= 7)
            {
                Squares[file, rank] = new();
                Squares[file, rank].squareColor = 
                    (file % 2 == 0 && rank % 2 == 0) ||
                    (file % 2 == 1 && rank % 2 == 1)
                    ? SquareColor.Dark : SquareColor.Light;

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

    public class Square
    {
        public SquareColor squareColor { get; set; }
        public Piece? Occupation { get; set; }
    }

    public enum SquareColor {
        Light, Dark
    }
}
