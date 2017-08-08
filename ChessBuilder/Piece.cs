using System;
using System.Collections.Generic;

namespace ChessBuilder
{
    public abstract class Piece : IRenderable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Index { get; set; }
        public bool Visible { get; set; }
        public abstract List<Move> GetMoves();
    }
}
