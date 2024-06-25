namespace Geometry.ThirdParty
{
    public class Rectangle : Rectangular
    {
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private int width;
        private int height;

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public override string ToString()
        {
            return $"Rectangle({this.height}, {this.width})";
        }
    }
}
