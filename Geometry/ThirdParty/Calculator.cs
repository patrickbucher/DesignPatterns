using System;

namespace Geometry.ThirdParty
{
    public class Calculator
    {
        public static int GetArea(Rectangular rectangle)
        {
            return rectangle.GetWidth() * rectangle.GetHeight();
        }

        public static int GetPerimeter(Rectangular rectangle)
        {
            return 2 * rectangle.GetWidth() + 2 * rectangle.GetHeight();
        }

        public static double GetDiagonal(Rectangular rectangle)
        {
            return Math.Sqrt(
                Math.Pow(rectangle.GetHeight(), 2.0) + Math.Pow(rectangle.GetWidth(), 2.0)
            );
        }
    }
}
