using UnityEngine;

namespace Tactics.Grid.Topology
{
    public interface IGridTopology
    {
        Vector3 GetWorldPosition(IGridCoordinates pos, float cellSize);
        IGridCoordinates GetGridPosition(Vector3 worldPosition, float cellSize);
    }
}
