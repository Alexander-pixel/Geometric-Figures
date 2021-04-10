namespace Geometric_Figure
{
    public interface IPolygon
    {
        int Height { get; }
        int Base { get; }
        int AngleBetweenBaseAndAdjacentSide { get; }
        int NumberOfSides { get; }

        int this[int index]
        {
            get;
            set;
        }
    }
}