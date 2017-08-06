using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Castle : Piece, IRenderable
    {
        public Castle()
        {
            Index = 'C';
        }

        public override List<Move> GetMoves()
        {
			var moves = new List<Move>();

			return moves;
        }
    }
}
