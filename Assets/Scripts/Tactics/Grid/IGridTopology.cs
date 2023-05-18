using UnityEngine;

namespace Tactics.Grid
{
    public interface IGridTopology
    {
        Vector3 GetWorldPosition(int x, int y, int z, float cellSize);
    }
}
