using System;
using Tactics.Grid.Topology;
using UnityEngine;

namespace Tactics.Grid
{
    public class Grid2D : IGrid
    {
        public IGridTopology GridTopology { get; }
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }
        public float CellSize { get; }

        private IGridPosition[,] gridPositionArray { get; }

        public Grid2D(IGridTopology gridTopology, int width, int height, float cellSize = 0f)
        {
            GridTopology = gridTopology;
            Width = Math.Max(width, 1);
            Depth = 0;
            Height = Math.Max(height, 1);
            CellSize = cellSize == 0 ? 1 : Math.Abs(cellSize);

            // DrawLine();
            gridPositionArray = new IGridPosition[Width, Height];

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var coordinates = new GridCoordinates(x, y, 0);
                    gridPositionArray[x, y] = new GridPosition(coordinates);
                    // var pos = GetWorldPosition(new GridCoordinates(x, y, 0));
                    // Debug.DrawLine(pos, pos + Vector3.right * .7f, Color.white, 1000);
                }
            }
        }

        public Vector3 GetWorldPosition(IGridCoordinates pos)
        {
            return GridTopology.GetWorldPosition(pos, CellSize);
        }
        
        public IGridCoordinates GetGridPosition(Vector3 worldPosition)
        {
            return GridTopology.GetGridPosition(worldPosition, CellSize);
        }

        public IGridPosition GetGridPosition(IGridCoordinates coordinates)
        {
            return gridPositionArray[coordinates.X, coordinates.Y];
        }

        private void DrawLine()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var pos = GetWorldPosition(new GridCoordinates(x, y, 0));
                    Debug.DrawLine(pos, pos + Vector3.right * .7f, Color.white, 1000);
                }
            }
        }

        public void CreateDebugObjects(Transform debugPrefab, Transform parent)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var coordinates = new GridCoordinates(x, y, 0);
                    Transform debugTransform = GameObject.Instantiate(debugPrefab, GetWorldPosition(coordinates), Quaternion.identity, parent);
                    var pos = debugTransform.transform.position;
                    debugTransform.transform.position = new Vector3(pos.x, pos.y, parent.transform.position.z);
                    GridDebugObject gridDebugObject = debugTransform.GetComponent<GridDebugObject>();
                    gridDebugObject.SetGridObject(GetGridPosition(coordinates));
                }
            }
        }
    }
}
