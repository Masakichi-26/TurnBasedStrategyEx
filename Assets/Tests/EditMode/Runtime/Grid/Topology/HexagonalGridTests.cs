using FluentAssertions;
using NUnit.Framework;
using Tactics.Grid;
using Tactics.Grid.Topology;
using UnityEngine;

namespace Tests.EditMode.Runtime.Grid.Topology
{
    public class HorizontalGridTests
    {
        public class GetWorldPositionMethod
        {
            [Theory]
            [TestCase(2, 1f)]
            [TestCase(4, 2.5f)]
            [TestCase(0, 3f)]
            public void World_position_is_cellSize_times_constant_as_large_as_grid_coordinates_for_x_coordinates_with_even_z(int x, float cellSize)
            {
                var sut = new HexagonalGrid();
                var pos = new GridPosition(x, 0, 0);

                Vector3 result = sut.GetWorldPosition(pos, cellSize);

                result.x.Should().Be(x * cellSize);
            }

            [Theory]
            [TestCase(1, 2f, 3f)]
            [TestCase(2, 1.5f, 3.75f)]
            [TestCase(0, 3f, 1.5f)]
            public void World_position_is_cellSize_times_constant_as_large_as_grid_coordinates_for_x_coordinates_with_odd_z(int x, float cellSize, float expectedX)
            {
                var sut = new HexagonalGrid();
                var pos = new GridPosition(x, 0, 1);

                Vector3 result = sut.GetWorldPosition(pos, cellSize);

                result.x.Should().Be(expectedX);
            }

            [Theory]
            [TestCase(2, 3f)]
            [TestCase(5, 4.5f)]
            [TestCase(0, 1f)]
            public void World_position_is_cellSize_times_as_large_as_grid_coordinates_for_y_coordinates(int y, float cellSize)
            {
                var sut = new HexagonalGrid();
                var pos = new GridPosition(0, y, 0);

                Vector3 result = sut.GetWorldPosition(pos, cellSize);

                result.y.Should().Be(y * cellSize);
            }

            [Theory]
            [TestCase(1, 1f, 0.75f)]
            [TestCase(2, 2.5f, 3.75f)]
            [TestCase(0, 1f, 0f)]
            public void World_position_is_cellSize_times_constant_as_large_as_grid_coordinates_for_z_coordinates(int z, float cellSize, float expectedZ)
            {
                var sut = new HexagonalGrid();
                var pos = new GridPosition(0, 0, z);

                Vector3 result = sut.GetWorldPosition(pos, cellSize);

                result.z.Should().Be(expectedZ);
            }
        }
    }
}
