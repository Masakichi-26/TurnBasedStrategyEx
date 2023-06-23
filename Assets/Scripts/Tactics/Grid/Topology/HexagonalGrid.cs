using UnityEngine;

namespace Tactics.Grid.Topology
{
    public class HexagonalGrid : IGridTopology
    {
        private const float HORIZONTAL_OFFSET_MULTIPLIER = 0.5f;
        private const float VERTICAL_OFFSET_MULTIPLIER = 0.75f;

        public Vector3 GetWorldPosition(IGridPosition pos, float cellSize)
        {
            var xVector = new Vector3(pos.X, 0, 0) * cellSize;
            var yVector = new Vector3(0, pos.Y, 0) * cellSize;
            var zVector = new Vector3(0, 0, pos.Z) * cellSize * VERTICAL_OFFSET_MULTIPLIER;

            if (pos.Z % 2 == 1)
            {
                xVector += new Vector3(1, 0, 0) * cellSize * HORIZONTAL_OFFSET_MULTIPLIER;
            }

            return xVector + yVector + zVector;
        }

        // TODO
        public IGridPosition GetGridPosition(Vector3 worldPosition, float cellSize)
        {
            var x = Mathf.RoundToInt(worldPosition.x / cellSize);
            var y = Mathf.RoundToInt(worldPosition.y / cellSize);
            var z = Mathf.RoundToInt(worldPosition.z / cellSize);

            return new GridPosition(x, y, z);
        }
    }
}
