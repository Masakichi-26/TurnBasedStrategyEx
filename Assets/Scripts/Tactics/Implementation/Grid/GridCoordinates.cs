namespace Tactics.Grid
{
    public struct GridCoordinates : IGridCoordinates
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public GridCoordinates(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"x: {X}; y: {Y}; z: {Z}";
        }
    }
}
