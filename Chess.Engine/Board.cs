using System.Collections.Generic;
using Chess.Engine.Pieces;

namespace Chess.Engine
{
    public class Board
    {
        public List<Piece> Pieces { get; set; } = new List<Piece>();

        public Board()
        {
            InitializeWhiteSide();
            InitializeBlackSide();
        }

        private void InitializeWhiteSide()
        {
            InitializePawns("White");
            InitializeRooks("White");
        }

        private void InitializeBlackSide()
        {

        }

        private void InitializePawns(string color)
        {
            if (color is "White")
            {
                Position initPosition = new Position(1, 2);
                for (int i = 0; i < 8; i++)
                {
                    Pawn pawn = new Pawn(color);
                    pawn.Position = initPosition + new Position(i, 0);
                    Pieces.Add(pawn);
                }
            }
            else
            {
                Position initPosition = new Position(1, 7);
                for (int i = 0; i < 8; i++)
                {
                    Pawn pawn = new Pawn(color);
                    pawn.Position = initPosition + new Position(i, 0);
                    Pieces.Add(pawn);
                }
            }
        }

        private void InitializeRooks(string color)
        {
            if (color is "White")
            {
                Rook rook1 = new Rook(color);
                Rook rook2 = new Rook(color);
                rook1.Position = new Position(1, 1);
                rook2.Position = new Position(8, 1);
                Pieces.Add(rook1);
                Pieces.Add(rook2);
            }
            else
            {
                Rook rook1 = new Rook(color);
                Rook rook2 = new Rook(color);
                rook1.Position = new Position(1, 8);
                rook2.Position = new Position(8, 8);
                Pieces.Add(rook1);
                Pieces.Add(rook2);
            }
        }
    }
}