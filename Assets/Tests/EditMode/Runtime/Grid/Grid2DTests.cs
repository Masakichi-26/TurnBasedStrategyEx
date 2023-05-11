using NUnit.Framework;
using Tactics.Grid;
using UnityEngine;

public class Grid2DTests
{
    public class Grid2DConstructor
    {
        [Test]
        public void Grid2D_width_depth_height_are_set_from_constructor()
        {
            var grid = new Grid2D(2, 4, 1.5f);

            Assert.That(grid.Width, Is.EqualTo(2));
            Assert.That(grid.Depth, Is.EqualTo(0));
            Assert.That(grid.Height, Is.EqualTo(4));
            Assert.That(grid.CellSize, Is.EqualTo(1.5f));
        }

        [Test]
        public void Grid2D_must_have_minimum_width_of_1()
        {
            var grid = new Grid2D(-1, 10);

            Assert.That(grid.Width, Is.EqualTo(1));
        }

        [Test]
        public void Grid2D_must_have_minimum_height_of_1()
        {
            var grid = new Grid2D(10, -1);

            Assert.That(grid.Height, Is.EqualTo(1));
        }

        [Test]
        public void Grid2D_has_default_cell_size_of_1()
        {
            var grid = new Grid2D(10, 10);

            Assert.That(grid.CellSize, Is.EqualTo(1));
        }

        [Test]
        public void Grid2D_cell_size_is_positive_even_if_negative_value_is_passed_in()
        {
            var grid = new Grid2D(10, 10, -2);

            Assert.That(grid.CellSize, Is.EqualTo(2));
        }
    }

    public class GetWorldPositionMethod
    {
        [Test]
        public void World_position_is_double_grid_coordinates_when_cell_size_is_2()
        {
            var grid = new Grid2D(10, 10, 2);

            var pos = grid.GetWorldPosition(1, 2);

            Assert.That(pos, Is.EqualTo(new Vector3(2, 4, 0)));
        }
    }
}
