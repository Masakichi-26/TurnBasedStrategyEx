using UnityEngine;

namespace Tactics.Grid.Topology
{
    public class SquareGrid : IGridTopology
    {
        public Vector3 GetWorldPosition(IGridCoordinates pos, float cellSize)
        {
            return new Vector3(pos.X, pos.Y, pos.Z) * cellSize;
        }

        public IGridCoordinates GetGridPosition(Vector3 worldPosition, float cellSize)
        {
            var x = Mathf.RoundToInt(worldPosition.x / cellSize);
            var y = Mathf.RoundToInt(worldPosition.y / cellSize);
            var z = Mathf.RoundToInt(worldPosition.z / cellSize);

            return new GridCoordinates(x, y, z);
        }
    }
}
