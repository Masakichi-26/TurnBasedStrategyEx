using System;
using UnityEngine;

namespace Tactics.Grid
{
    public class Grid3D : IGrid
    {
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }

        public Grid3D(int w, int d, int h)
        {
            Width = Math.Max(w, 1);
            Depth = Math.Max(d, 1);
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
