using System;
using System.Collections.Generic;

namespace ChessBuilder.Pieces
{
    public class Queen : Piece
    {
        public Queen()
        {
            Index = 'Q';
        }

        public override List<Move> GetMoves()
        {
            var moves = new List<Move>();

            for (int i = 0; i <= 7; i++)
            {
                moves.Add(new Move { X = X, Y = Y });
                moves.Add(new Move { X = X - i, Y = Y + i }); 
                moves.Add(new Move { X = X + i, Y = Y - i });
                moves.Add(new Move { X = X + i, Y = Y - 1 });
                moves.Add(new Move { X = X + i, Y = Y + i });
                moves.Add(new Move { X = X - i, Y = Y - i });
            }

            for (int col = X; col <= X + 7; col++)
            {
                moves.Add(new Move { X = col, Y = Y });
                moves.Add(new Move { X = col - 7, Y = Y });

                for (int row = Y; row <= Y + 7; row++)
                {
                    moves.Add(new Move { X = X, Y = row });
                    moves.Add(new Move { X = X, Y = row - 7 });
                }
            }

                return moves;
        }
    }
}
