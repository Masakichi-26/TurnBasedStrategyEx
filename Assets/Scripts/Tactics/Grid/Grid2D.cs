using System;
using UnityEngine;

namespace Tactics.Grid
{
    public class Grid2D : IGrid
    {
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }

        public Grid2D(int w, int h)
        {
            Width = Math.Max(w, 1);
            Depth = 0;
            Height = Math.Max(h, 1);

            DrawLine();
        }

        public Vector3 GetWorldPosition(int x, int y, int z = 0)
        {
            return new Vector3(x, y, 0);
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
