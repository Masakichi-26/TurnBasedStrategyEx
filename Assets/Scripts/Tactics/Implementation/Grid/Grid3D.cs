using System;
using Tactics.Grid.Topology;
using UnityEngine;

namespace Tactics.Grid
{
    public class Grid3D : IGrid
    {
        public IGridTopology GridTopology { get; }
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }
        public float CellSize { get; }

        public Grid3D(IGridTopology gridTopology, int w, int d, int h, float cellSize = 0f)
        {
            GridTopology = gridTopology;
            Width = Math.Max(w, 1);
            Depth = Math.Max(d, 1);
            Height = Math.Max(h, 1);
            CellSize = cellSize == 0 ? 1 : Math.Abs(cellSize);

            DrawLine();
        }

        public Vector3 GetWorldPosition(IGridPosition pos)
        {
            return GridTopology.GetWorldPosition(pos, CellSize);
        }

        public IGridPosition GetGridPosition(Vector3 worldPosition)
        {
            return GridTopology.GetGridPosition(worldPosition, CellSize);
        }

        private void DrawLine()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Depth; y++)
                {
                    for (int z = 0; z < Height; z++)
                    {
                        var pos = GetWorldPosition(new GridPosition(x, y, z));
                        Debug.DrawLine(pos, pos + Vector3.right * .7f, Color.white, 1000);
                    }
                }
            }
        }
    }
}