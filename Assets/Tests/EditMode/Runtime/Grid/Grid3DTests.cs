using NUnit.Framework;
using Tactics.Grid;

public class Grid3DTests
{
    public class Grid3DConstructor
    {
        [Test]
        public void Grid3D_width_depth_height_are_set_from_constructor()
        {
            var grid = new Grid3D(2, 4, 6);

            Assert.That(grid.Width, Is.EqualTo(2));
            Assert.That(grid.Depth, Is.EqualTo(4));
            Assert.That(grid.Height, Is.EqualTo(6));
        }

        [Test]
        public void Grid3D_must_have_minimum_width_of_1()
        {
            var grid = new Grid3D(-1, 10, 10);

            Assert.That(grid.Width, Is.EqualTo(1));
        }

        [Test]
        public void Grid3D_must_have_minimum_depth_of_1()
        {
            var grid = new Grid3D(10, -1, 10);

            Assert.That(grid.Depth, Is.EqualTo(1));
        }

        [Test]
        public void Grid3D_must_have_minimum_height_of_1()
        {
            var grid = new Grid3D(10, 10, -1);

            Assert.That(grid.Height, Is.EqualTo(1));
        }
    }
}
