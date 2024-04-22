namespace ShapeIdentifier
{
    public interface ITriangle
    {
        bool IsValidBySides(float a, float b, float c);
        bool IsEquilateral(float a, float b, float c);
        bool IsIsosceles(float a, float b, float c);
        bool IsScalene(float a, float b, float c);
        TriangleType GetTypeBySides(float a, float b, float c);
    }
}
