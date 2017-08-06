﻿using System;
using System.Collections.Generic;
using ChessBuilder.Pieces;

namespace ChessBuilder
{
    public class Board
    {
        public List<IRenderable> Renderables { get; set; }
        public List<Piece> Pieces { get; set; }

        public void Initialize()
        {
			Pieces = new List<Piece>();
			Renderables = new List<IRenderable>();

            var king = new King() { X = 4, Y = 0 };
            Pieces.Add(king);

            var queen = new Queen() { X = 3, Y = 0 };
            Pieces.Add(queen);

            var bishop = new Bishop() { X = 2, Y = 0 };
            Pieces.Add(bishop);

            var knight = new Knight() { X = 1, Y = 0 };
            Pieces.Add(knight);

            var pawn = new Pawn() { X = 7, Y = 1 };
            Pieces.Add(pawn);

            foreach (var piece in Pieces)
            {
                Renderables.Add(piece);
                piece.Visable = true;
                piece.GetMoves();
            }
        }
    }
}
