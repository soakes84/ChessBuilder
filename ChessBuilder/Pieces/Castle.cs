using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Castle : Piece
    {
        public Castle()
        {
            Index = 'C';
        }

        public override List<Move> GetMoves()
        {
			var moves = new List<Move>();

            for (int col = X; col <= X + 7; col++)
            {
                moves.Add(new Move { X = col, Y = Y });
                moves.Add(new Move { X = col - 7, Y = Y });

                for (int row = Y; row <= 7; row++)
                {
                    moves.Add(new Move { X = X, Y = row });
                    moves.Add(new Move { X = X, Y = row - 7 });
                }
            }

			return moves;
        }
    }
}
