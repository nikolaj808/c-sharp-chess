namespace Chess.Engine
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Position operator +(Position Pos1, Position Pos2)
        {
            Position Pos3 = new Position(0, 0);
            Pos3.X = Pos1.X + Pos2.X;
            Pos3.Y = Pos1.Y + Pos2.Y;
            return Pos3;
        }

        public static bool operator ==(Position Pos1, Position Pos2)
        {
            return (Pos1.X == Pos2.X && Pos1.Y == Pos2.Y);
        }

        public static bool operator !=(Position Pos1, Position Pos2)
        {
            return (Pos1.X != Pos2.X || Pos1.Y != Pos2.Y);
        }
    }
}