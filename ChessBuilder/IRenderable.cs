using System;
namespace ChessBuilder
{
    public interface IRenderable
    {
        int X { get; set; }
        int Y { get; set; }
        bool Visible { get; set; }
        char Index { get; set; }
    }
}
