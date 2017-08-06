using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Queen : Piece, IRenderable
    {
        public Queen()
        {
            Index = 'Q';
        }

        public override List<Move> GetMoves()
        {
            var moves = new List<Move>();

            return moves;
        }
    }
}
