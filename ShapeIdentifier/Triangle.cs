namespace ShapeIdentifier
{
    public static class Triangle
    {
        public static TriangleType GetTypeBySides(decimal a, decimal b, decimal c)
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

        public static bool IsEquilateral(decimal a, decimal b, decimal c)
        {
            return a == b && a == c && b == c;
        }

        public static bool IsIsosceles(decimal a, decimal b, decimal c)
        {
            return a == b || a == c || b == c;
        }

        public static bool IsScalene(decimal a, decimal b, decimal c)
        {
            return a != b && a != c && b != c;
        }

        public static bool IsValidBySides(decimal a, decimal b, decimal c)
        {
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }
    }
}
