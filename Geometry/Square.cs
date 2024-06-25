namespace Geometry
{
    public class Square : Quadratic
    {
        public Square(int side)
        {
            this.side = side;
        }

        private int side;

        public int GetSide()
        {
            return this.side;
        }

        public override string ToString()
        {
            return $"Square({this.side})";
        }
    }
}
