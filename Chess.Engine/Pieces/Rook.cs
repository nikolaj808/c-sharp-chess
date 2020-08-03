using System;
using System.Collections.Generic;

namespace Chess.Engine.Pieces
{
    public class Rook : Piece
    {
        public Position Position { get; set; }
        public string Color { get; set; }

        public Rook(string color)
        {
            Color = color;
        }

        public List<Position> CalculateMoves(Board board)
        {
            List<Position> PossibleMoves = new List<Position>();
            int StepsNorth = 0;
            int StepsEast = 0;
            int StepsSouth = 0;
            int StepsWest = 0;

            foreach (Piece piece in board.Pieces)
            {
                // Steps north
                for (int i = Position.Y + 1; i < 8; i++)
                {
                    if (piece.Position != (new Position(Position.X, i)))
                    {
                        StepsNorth++;
                    }
                }

                // Steps east
                for (int i = Position.X + 1; i < 8; i++)
                {
                    if (piece.Position != (new Position(i, Position.Y)))
                    {
                        StepsEast++;
                    }
                }

                // Steps south
                for (int i = Position.Y - 1; i > 0; i++)
                {
                    if (piece.Position != (new Position(Position.X, i)))
                    {
                        StepsSouth++;
                    }
                }

                // Steps west
                for (int i = Position.X - 1; i > 0; i++)
                {
                    if (piece.Position != (new Position(i, Position.Y)))
                    {
                        StepsWest++;
                    }
                }
            }

            Console.WriteLine($"{StepsNorth} {StepsEast} {StepsSouth} {StepsWest}");

            return null;
        }

        public void Move(Position position, Board board)
        {
            throw new System.NotImplementedException();
        }
    }
}