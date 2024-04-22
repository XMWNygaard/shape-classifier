namespace ShapeIdentifier
{
    public static class Triangle
    {
        public static TriangleType GetTypeBySides(double a, double b, double c)
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

        public static bool IsEquilateral(double a, double b, double c)
        {
            if (IsValidBySides(a, b, c))
            {
                return a == b && a == c && b == c;
            }

            return false;
        }

        public static bool IsIsosceles(double a, double b, double c)
        {
            if (IsValidBySides(a, b, c))
            {
                return a == b || a == c || b == c;
            }

            return false;

        }

        public static bool IsScalene(double a, double b, double c)
        {
            if (IsValidBySides(a, b, c))
            {
                return a != b && a != c && b != c;
            }

            return false;
        }

        public static bool IsValidBySides(double a, double b, double c)
        {
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }
    }
}
