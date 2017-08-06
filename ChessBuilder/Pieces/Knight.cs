using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Knight : Piece
    {
        public Knight()
        {
            Index = 'N';
        }

        public override List<Move> GetMoves()
        {
			var moves = new List<Move>();

            moves.Add(new Move { X = X, Y = Y });
            moves.Add(new Move { X = X + 2, Y = Y - 1 });
            moves.Add(new Move { X = X + 2, Y = Y + 1 });
            moves.Add(new Move { X = X - 1, Y = Y + 2 });
            moves.Add(new Move { X = X - 1, Y = Y - 2 });
            moves.Add(new Move { X = X - 2, Y = Y + 1 });
            moves.Add(new Move { X = X - 2, Y = Y - 1 });
            moves.Add(new Move { X = X + 1, Y = Y + 2 });
            moves.Add(new Move { X = X + 1, Y = Y - 2 });

			return moves;
		}
    }
}
