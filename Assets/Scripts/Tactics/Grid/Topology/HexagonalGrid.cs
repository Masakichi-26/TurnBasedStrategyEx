using UnityEngine;

namespace Tactics.Grid.Topology
{
    public class HexagonalGrid : IGridTopology
    {
        public Vector3 GetWorldPosition(IGridPosition pos, float cellSize)
        {
            return new Vector3(pos.X, pos.Y, pos.Z) * cellSize;
        }
    }
}
