using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class King : Piece
    {
        public King()
        {
            Index = 'K';
        }

        public override List<Move> GetMoves()
        {
            var moves = new List<Move>();

            for (int col = X; col <= X + 1; col++)
            {
                moves.Add(new Move {X = X + 1, Y = Y});
                moves.Add(new Move {X = X + 1, Y = Y + 1 });
                moves.Add(new Move { X = X + 1, Y = Y - 1 });
                moves.Add(new Move { X = X - 1, Y = Y });
                moves.Add(new Move { X = X - 1, Y = Y + 1 });
                moves.Add(new Move { X = X - 1, Y = Y - 1 });
                moves.Add(new Move { X = X, Y = Y - 1 });
                moves.Add(new Move { X = X, Y = Y + 1 });
            }

            return moves;
        }
    }
}
