using System;
using UnityEngine;

namespace Tactics.Grid
{
    public class Grid3D : IGrid
    {
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }
        public float CellSize { get; }

        public Grid3D(int w, int d, int h, float cellSize = 0f)
        {
            Width = Math.Max(w, 1);
            Depth = Math.Max(d, 1);
            Height = Math.Max(h, 1);
            CellSize = cellSize == 0 ? 1 : Math.Abs(cellSize);

            DrawLine();
        }

        public Vector3 GetWorldPosition(int x, int y, int z = 0)
        {
            return new Vector3(x, y, z) * CellSize;
        }

        private void DrawLine()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Depth; y++)
                {
                    for (int z = 0; z < Height; z++)
                    {
                        var pos = GetWorldPosition(x, y, z);
                        Debug.DrawLine(pos, pos + Vector3.right * .7f, Color.white, 1000);
                    }
                }
            }
        }
    }
}
