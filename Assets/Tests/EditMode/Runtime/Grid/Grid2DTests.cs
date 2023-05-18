using FluentAssertions;
using NUnit.Framework;
using Tactics.Grid;
using UnityEngine;

public class Grid2DTests
{
    private class Grid2DConstructor
    {
        [Test]
        public void Grid2D_width_and_height_and_cell_size_are_same_as_constructor_parameters()
        {
            int width = 2;
            int height = 4;
            float cellSize = 1.5f;
            var grid = new Grid2D(width, height, cellSize);

            grid.Width.Should().Be(width);
            grid.Height.Should().Be(height);
            grid.CellSize.Should().Be(cellSize);
        }

        [Test]
        public void Grid2D_depth_is_0_regardless_of_constructor_parameter()
        {
            var grid = new Grid2D(1, 1, 1f);

            grid.Depth.Should().Be(0);
        }

        [Test]
        public void Grid2D_must_have_minimum_width_of_1()
        {
            int width = -1;
            var grid = new Grid2D(width, 10);

            grid.Width.Should().Be(1);
        }

        [Test]
        public void Grid2D_must_have_minimum_height_of_1()
        {
            int height = -1;
            var grid = new Grid2D(10, height);

            grid.Height.Should().Be(1);
        }

        [Test]
        public void Grid2D_has_default_cell_size_of_1()
        {
            var grid = new Grid2D(10, 10);

            grid.CellSize.Should().Be(1);
        }

        [Test]
        public void Grid2D_cell_size_is_positive_even_if_negative_value_is_passed_in()
        {
            float cellSize = -2f;
            var grid = new Grid2D(10, 10, cellSize);

            grid.CellSize.Should().Be(2);
        }
    }

    private class GetWorldPositionMethod
    {
        [TestCase(2f)]
        [TestCase(1.5f)]
        public void World_position_is_cellSize_times_as_large_as_grid_coordinates(float cellSize)
        {
            var grid = new Grid2D(10, 10, cellSize);
            int x = 1;
            int y = 3;

            var pos = grid.GetWorldPosition(x, y);

            pos.Should().Be(new Vector3(x * cellSize, y * cellSize, 0));
        }
    }
}
