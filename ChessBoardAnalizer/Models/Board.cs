using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace ChessBoardAnalizer.Models
{
    public class Board
    {
        public Board()
        {
            Piece queen = new Piece(PieceType.Queen, 0, 0);
            pieces.Add(queen);
            AddSquaresToBoard();
        }

        public List<Piece> pieces { get; set; } = new();
        public Square[,] squares { get; set; } = new Square[8, 8];

        private void AddSquaresToBoard()
        {
            int file = 0;
            int rank = 0;

            while (file <= 7 && rank <= 7)
            {
                squares[file, rank] = new();
                squares[file, rank].WhiteOrBlack = 
                    (file % 2 == 0 && rank % 2 == 0) ||
                    (file % 2 == 1 && rank % 2 == 1)
                    ? true : false;

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
        public bool WhiteOrBlack { get; set; }
        public Piece? Occupation { get; set; }
    }
}
