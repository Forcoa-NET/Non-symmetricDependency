using Non_symmetricDependency.Algorithm;
using Non_symmetricDependency.Algorithm.Exceptions;
using Xunit;

namespace Non_symmetricDependency.UnitTests
{
    public class EdgeTests
    {
        [Fact]
        public void Edge_PositiveNumbers_ShouldCreateInstance()
        {
            var edge = new Edge(1, 2);
            Assert.Equal(1, edge.NodeX);
            Assert.Equal(2, edge.NodeY);
        }

        [Fact]
        public void Edge_NegativeNumbers_ShouldCreateInstance()
        {
            Assert.Throws<InvalidParametrException>(() => new Edge(-1, 2));
        }
    }
}
