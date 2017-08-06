using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Knight : Piece, IRenderable
    {
        public Knight()
        {
            Index = 'N';
        }

        public override List<Move> GetMoves()
        {
			var moves = new List<Move>();

			return moves;
		}
    }
}
