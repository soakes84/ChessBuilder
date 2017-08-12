using System;
using System.Collections.Generic;
using ChessBuilder.Pieces;

namespace ChessBuilder
{
    public class Board
    {
        public List<IRenderable> Renderables { get; set; }
        public List<Piece> Pieces { get; set; }

        public Board()
        {
            Pieces = new List<Piece>();
            Renderables = new List<IRenderable>();
        }

        public void Initialize()
        {
			Pieces = new List<Piece>();
			Renderables = new List<IRenderable>();

            var king = new King() { X = 4, Y = 0 };
            Pieces.Add(king);

            var queen = new Queen() { X = 3, Y = 0 };
            Pieces.Add(queen);

            var bishop1 = new Bishop() { X = 2, Y = 0 };
            Pieces.Add(bishop1);

			var bishop2 = new Bishop() { X = 5, Y = 0 };
			Pieces.Add(bishop2);

            var knight1 = new Knight() { X = 1, Y = 0 };
            Pieces.Add(knight1);

			var knight2 = new Knight() { X = 6, Y = 0 };
			Pieces.Add(knight2);

            var castle1 = new Castle { X = 0, Y = 0 };
            Pieces.Add(castle1);

			var castle2 = new Castle { X = 7, Y = 0 };
			Pieces.Add(castle2);

            var pawn1 = new Pawn() { X = 7, Y = 1 };
            Pieces.Add(pawn1);

			var pawn2 = new Pawn() { X = 6, Y = 1 };
			Pieces.Add(pawn2);

			var pawn3 = new Pawn() { X = 5, Y = 1 };
			Pieces.Add(pawn3);

			var pawn4 = new Pawn() { X = 4, Y = 1 };
			Pieces.Add(pawn4);

			var pawn5 = new Pawn() { X = 3, Y = 1 };
			Pieces.Add(pawn5);
           
			var pawn6 = new Pawn() { X = 2, Y = 1 };
			Pieces.Add(pawn6);

			var pawn7 = new Pawn() { X = 1, Y = 1 };
			Pieces.Add(pawn7);

			var pawn8 = new Pawn() { X = 0, Y = 1 };
			Pieces.Add(pawn8);

            foreach (var piece in Pieces)
            {
                Renderables.Add(piece);
                piece.Visible = true;
                piece.GetMoves();
            }
        }
    }
}
