namespace Tactics.Grid
{
    public struct GridPosition : IGridPosition
    {
        public IGridCoordinates GridCoordinates { get; }

        public GridPosition(IGridCoordinates coordinates)
        {
            GridCoordinates = coordinates;
        }

        public override string ToString()
        {
            return GridCoordinates.ToString();
        }
    }
}
