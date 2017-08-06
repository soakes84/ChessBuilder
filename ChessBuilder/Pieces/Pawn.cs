using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Pawn : Piece
    {
        public Pawn()
        {
            Index = 'P';
        }

        public override List<Move> GetMoves()
        {
			var moves = new List<Move>();

            moves.Add(new Move { X = X, Y = Y });
            moves.Add(new Move { X = X, Y = Y + 1 });

			return moves;
        }
    }
}
