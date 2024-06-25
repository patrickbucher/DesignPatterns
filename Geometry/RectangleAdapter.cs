using Geometry.ThirdParty;

namespace Geometry
{
    public class RectangleAdapter : Rectangular
    {
        public RectangleAdapter(Quadratic square)
        {
            this.square = square;
        }

        private Quadratic square;

        public int GetWidth()
        {
            return square.GetSide();
        }

        public int GetHeight()
        {
            return square.GetSide();
        }
    }
}
