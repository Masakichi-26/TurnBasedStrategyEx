using FluentAssertions;
using Moq;
using NUnit.Framework;
using Tactics.Grid;
using Tactics.Grid.Topology;

public class Grid3DTests
{
    public class Grid3DConstructor : Grid3DTests
    {
        [Test]
        public void Grid3D_width_and_depth_and_height_and_cell_size_are_same_as_constructor_parameters()
        {
            int width = 2;
            int depth = 4;
            int height = 6;
            float cellSize = 0.5f;
            var sut = CreateGrid(width, depth, height, cellSize);

            sut.Width.Should().Be(width);
            sut.Depth.Should().Be(depth);
            sut.Height.Should().Be(height);
            sut.CellSize.Should().Be(cellSize);
        }

        [Test]
        public void Grid3D_must_have_minimum_width_of_1()
        {
            int width = -1;
            var sut = CreateGrid(width, 10, 10);

            sut.Width.Should().Be(1);
        }

        [Test]
        public void Grid3D_must_have_minimum_depth_of_1()
        {
            int depth = -1;
            var sut = CreateGrid(10, depth, 10);

            sut.Depth.Should().Be(1);
        }

        [Test]
        public void Grid3D_must_have_minimum_height_of_1()
        {
            int height = -1;
            var sut = CreateGrid(10, 10, height);

            sut.Height.Should().Be(1);
        }

        [Test]
        public void Grid3D_has_default_cell_size_of_1()
        {
            var sut = CreateGrid(10, 10, 10);

            sut.CellSize.Should().Be(1);
        }

        [Test]
        public void Grid3D_cell_size_is_positive_even_if_negative_value_is_passed_in()
        {
            float cellSize = -5;
            var sut = CreateGrid(10, 10, 10, cellSize);

            sut.CellSize.Should().Be(5);
        }
    }

    protected Grid3D CreateGrid(int width, int depth, int height, float cellSize = 0f)
    {
        var gridTopology = new Mock<IGridTopology>();
        return new Grid3D(gridTopology.Object, width, depth, height, cellSize);
    }
}
