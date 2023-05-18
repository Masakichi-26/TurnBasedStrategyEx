using System;
using UnityEngine;

namespace Tactics.Grid
{
    public class Grid2D : IGrid
    {
        public IGridTopology GridTopology;
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }
        public float CellSize { get; }

        public Grid2D(IGridTopology gridTopology, int w, int h, float cellSize = 0f)
        {
            GridTopology = gridTopology;
            Width = Math.Max(w, 1);
            Depth = 0;
            Height = Math.Max(h, 1);
            CellSize = cellSize == 0 ? 1 : Math.Abs(cellSize);

            DrawLine();
        }

        public Vector3 GetWorldPosition(int x, int y, int z = 0)
        {
            return GridTopology.GetWorldPosition(x, y, 0, CellSize);
        }

        private void DrawLine()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var pos = GetWorldPosition(x, y);
                    Debug.DrawLine(pos, pos + Vector3.right * .7f, Color.white, 1000);
                }
            }
        }
    }
}
