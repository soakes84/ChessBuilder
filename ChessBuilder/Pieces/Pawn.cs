using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Pawn : Piece, IRenderable
    {
        public Pawn()
        {
            Index = 'P';
        }

        public override List<Move> GetMoves()
        {
			var moves = new List<Move>();

			return moves;
        }
    }
}
