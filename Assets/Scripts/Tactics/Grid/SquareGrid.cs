using UnityEngine;

namespace Tactics.Grid
{
    public class SquareGrid : IGridTopology
    {
        public Vector3 GetWorldPosition(int x, int y, int z, float cellSize)
        {
            return new Vector3(x, y, z) * cellSize;
        }
    }
}
