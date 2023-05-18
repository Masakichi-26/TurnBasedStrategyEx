using FluentAssertions;
using Moq;
using NUnit.Framework;
using Tactics.Grid;
using UnityEngine;

public class Grid2DTests
{
    private class Grid2DConstructor : Grid2DTests
    {
        [Test]
        public void Grid2D_width_and_height_and_cell_size_are_same_as_constructor_parameters()
        {
            int width = 2;
            int height = 4;
            float cellSize = 1.5f;
            var sut = CreateGrid(width, height, cellSize);

            sut.Width.Should().Be(width);
            sut.Height.Should().Be(height);
            sut.CellSize.Should().Be(cellSize);
        }

        [Test]
        public void Grid2D_depth_is_0_regardless_of_constructor_parameter()
        {
            var sut = CreateGrid(1, 1, 1f);

            sut.Depth.Should().Be(0);
        }

        [Test]
        public void Grid2D_must_have_minimum_width_of_1()
        {
            int width = -1;
            var sut = CreateGrid(width, 10);

            sut.Width.Should().Be(1);
        }

        [Test]
        public void Grid2D_must_have_minimum_height_of_1()
        {
            int height = -1;
            var sut = CreateGrid(10, height);

            sut.Height.Should().Be(1);
        }

        [Test]
        public void Grid2D_has_default_cell_size_of_1()
        {
            var sut = CreateGrid(10, 10);

            sut.CellSize.Should().Be(1);
        }

        [Test]
        public void Grid2D_cell_size_is_positive_even_if_negative_value_is_passed_in()
        {
            float cellSize = -2f;
            var sut = CreateGrid(10, 10, cellSize);

            sut.CellSize.Should().Be(2);
        }
    }

    // private class GetWorldPositionMethod : Grid2DTests
    // {
    //     [TestCase(2f)]
    //     [TestCase(1.5f)]
    //     public void World_position_is_cellSize_times_as_large_as_grid_coordinates(float cellSize)
    //     {
    //         var grid = CreateGrid(10, 10, cellSize);
    //         int x = 1;
    //         int y = 3;

    //         var pos = grid.GetWorldPosition(x, y);

    //         pos.Should().Be(new Vector3(x * cellSize, y * cellSize, 0));
    //     }
    // }

    protected Grid2D CreateGrid(int width, int height, float cellSize = 0f)
    {
        var gridTopology = new Mock<IGridTopology>();
        return new Grid2D(gridTopology.Object, width, height, cellSize);
    }
}
