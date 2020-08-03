using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Chess.Engine.Pieces
{
    public class Pawn : Piece
    {
        private bool FirstMoveMade = false;
        public string Color { get; set; }
        public Position Position { get; set; }

        public Pawn(string color)
        {
            Color = color;
        }

        public List<Position> CalculateMoves(Board board)
        {
            List<Position> PossibleMoves = new List<Position>();
            bool canMove1 = false;
            bool canMove2 = !FirstMoveMade;
            bool canAttackLeft = false;
            bool canAttackRight = false;

            // Check if there's a place the
            foreach (Piece piece in board.Pieces)
            {
                if (Color is "White")
                {
                    if (piece.Position != (Position + new Position(0, 1)))
                        canMove1 = true;
                    if (piece.Position != (Position + new Position(0, 2)))
                        canMove2 = true;
                    if (piece.Position == (Position + new Position(-1, 1)))
                        canAttackLeft = true;
                    if (piece.Position == (Position + new Position(1, 1)))
                        canAttackRight = true;
                }
                else
                {
                    if (piece.Position != (Position + new Position(0, -1)))
                        canMove1 = true;
                    if (piece.Position != (Position + new Position(0, -2)))
                        canMove2 = true;
                    if (piece.Position == (Position + new Position(-1, -1)))
                        canAttackLeft = true;
                    if (piece.Position == (Position + new Position(1, -1)))
                        canAttackRight = true;
                }
            }

            if (canMove1)
            {
                if (Color is "White")
                {
                    PossibleMoves.Add(Position + new Position(0, 1));
                }
                else
                {
                    PossibleMoves.Add(Position + new Position(0, -1));
                }
            }

            if (canMove2)
            {
                if (Color is "White")
                {
                    PossibleMoves.Add(Position + new Position(0, 2));
                }
                else
                {
                    PossibleMoves.Add(Position + new Position(0, -2));
                }
            }

            if (canAttackLeft)
            {
                if (Color is "White")
                {
                    PossibleMoves.Add(Position + new Position(-1, 1));
                }
                else
                {
                    PossibleMoves.Add(Position + new Position(-1, -1));
                }
            }

            if (canAttackRight)
            {
                if (Color is "White")
                {
                    PossibleMoves.Add(Position + new Position(1, 1));
                }
                else
                {
                    PossibleMoves.Add(Position + new Position(1, -1));
                }
            }

            return PossibleMoves;
        }

        public void Move(Position position, Board board)
        {
            foreach (Position pos in CalculateMoves(board))
            {
                if (pos == position)
                {
                    Console.Write($"Moved {this.ToString()} from ({Position.X}, {Position.Y}) to ");
                    Position = pos;
                    Console.WriteLine($"({Position.X}, {Position.Y})");
                    return;
                }
            }
        }

        public override string ToString()
        {
            return $"{Color} Pawn";
        }
    }
}