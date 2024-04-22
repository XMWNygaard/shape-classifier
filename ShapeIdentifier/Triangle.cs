namespace ShapeIdentifier
{
    public class Triangle : ITriangle
    {
        public TriangleType GetTypeBySides(float a, float b, float c)
        {
            if (IsValidBySides(a, b, c))
            {
                if (IsEquilateral(a, b, c))
                {
                    return TriangleType.Equilateral;
                }

                if (IsIsosceles(a, b, c))
                {
                    return TriangleType.Isosceles;
                }

                if (IsScalene(a, b, c))
                {
                    return TriangleType.Scalene;
                }
            }

            return TriangleType.Degenerate;
        }

        public bool IsEquilateral(float a, float b, float c)
        {
            return a == b && a == c && b == c;
        }

        public bool IsIsosceles(float a, float b, float c)
        {
            return a == b || a == c || b == c;
        }

        public bool IsScalene(float a, float b, float c)
        {
            return a != b && a != c && b != c;
        }

        public bool IsValidBySides(float a, float b, float c)
        {
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }
    }
}
