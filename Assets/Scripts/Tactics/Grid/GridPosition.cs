namespace Tactics.Grid
{
    public struct GridPosition : IGridPosition
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public GridPosition(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
