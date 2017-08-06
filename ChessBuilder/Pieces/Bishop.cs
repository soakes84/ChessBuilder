using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Bishop : Piece, IRenderable
    {
        public Bishop()
        {
            Index = 'B';
        }

        public override List<Move> GetMoves()
        {
            var moves = new List<Move>();

            return moves;
        }
    }
}
