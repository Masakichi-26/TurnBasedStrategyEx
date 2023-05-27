using FluentAssertions;
using NUnit.Framework;
using Tactics.Grid;
using Tactics.Grid.Topology;
using UnityEngine;

namespace Tests.EditMode.Runtime.Grid.Topology
{
    public class SquareGridTests
    {
        public class GetWorldPositionMethod
        {
            [TestCase(1, 2, 3, 3f)]
            [TestCase(5, 4, 3, 4.5f)]
            [TestCase(0, 0, 0, 1f)]
            public void World_position_is_cellSize_times_as_large_as_grid_coordinates(int x, int y, int z, float cellSize)
            {
                var sut = new SquareGrid();
                var pos = new GridPosition(x, y, z);

                Vector3 result = sut.GetWorldPosition(pos, cellSize);

                result.x.Should().Be(x * cellSize);
                result.y.Should().Be(y * cellSize);
                result.z.Should().Be(z * cellSize);
            }
        }
    }
}
