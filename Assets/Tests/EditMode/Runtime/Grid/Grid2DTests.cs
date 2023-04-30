using NUnit.Framework;
using Tactics.Grid;

public class Grid2DTests
{
    public class Grid2DConstructor
    {
        [Test]
        public void Grid2D_width_depth_height_are_set_from_constructor()
        {
            var grid = new Grid2D(2, 4);

            Assert.That(grid.Width, Is.EqualTo(2));
            Assert.That(grid.Depth, Is.EqualTo(0));
            Assert.That(grid.Height, Is.EqualTo(4));
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
    }
}
