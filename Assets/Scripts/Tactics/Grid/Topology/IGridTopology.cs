using UnityEngine;

namespace Tactics.Grid.Topology
{
    public interface IGridTopology
    {
        Vector3 GetWorldPosition(IGridPosition pos, float cellSize);
        IGridPosition GetGridPosition(Vector3 worldPosition, float cellSize);
    }
}
