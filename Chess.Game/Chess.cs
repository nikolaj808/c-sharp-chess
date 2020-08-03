using System;
using Chess.Engine;
using Chess.Engine.Pieces;

namespace Chess.Game
{
    class Chess
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            foreach (Piece piece in board.Pieces)
            {
                Console.WriteLine($"Piece type: {piece.ToString()} --- Piece position: ({piece.Position.X}, {piece.Position.Y})");
            }

            board.Pieces[0].Move(new Position(1, 3), board);

            // Rook moves not functional yet
            board.Pieces[8].CalculateMoves(board);
        }
    }
}
