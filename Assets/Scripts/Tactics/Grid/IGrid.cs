using UnityEngine;

namespace Tactics.Grid
{
    public interface IGrid
    {
        // from left to right
        int Width { get; }
        // from front to back (3D)
        int Depth { get; }
        // from top to bottom
        int Height { get; }
        // size of cells (spaces/tiles) in Unity units
        float CellSize { get; }

        public Vector3 GetWorldPosition(int x, int y, int z);
    }
}
