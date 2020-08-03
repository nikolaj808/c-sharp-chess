using System.Collections.Generic;

namespace Chess.Engine.Pieces
{
    public interface Piece
    {
        Position Position { get; set; }
        string Color { get; set; }
        List<Position> CalculateMoves(Board board);
        void Move(Position position, Board board);
    }
}