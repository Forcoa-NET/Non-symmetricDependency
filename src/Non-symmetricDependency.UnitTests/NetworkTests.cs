using Non_symmetricDependency.Algorithm.Exceptions;
using Non_symmetricDependency.Algorithm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Non_symmetricDependency.UnitTests
{
    public class NetworkTests
    {

        public NetworkTests()
        {

        }

        [Fact]
        public void Network_NullParameter_ShouldThrow()
        {
            Assert.Throws<ArgumentNullException>(() => new Network(null));
        }

        [Fact]
        public void Network_NonSymetricMatrix_ShouldThrow()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                    };

            Assert.Throws<InvalidParametrException>(() => new Network(matrix));
        }

        [Fact]
        public void Network_ValidMatrix_ShouldSetSize()
        {
            double[][] matrix =  
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.Equal(3, network.Size);
        }

        [Fact]
        public void AreNeighbours_Neighbours_ShouldReturnTrue()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.True(network.AreNeighbours(0,1));
        }

        [Fact]
        public void AreNeighbours_NotNeighbours_ShouldReturnFalse()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.False(network.AreNeighbours(0, 2));
        }

        [Fact]
        public void AreNeighbours_IndexOutOfRange_ShouldThrow()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.Throws<IndexOutOfMatrixSpace>(() => network.AreNeighbours(0, 5));
        }

        [Fact]
        public void AreNeighbours_NegativeIndexOutOfRange_ShouldThrow()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.Throws<IndexOutOfMatrixSpace>(() => network.AreNeighbours(-1, 2));
        }

        [Fact]
        public void GetWeightOfEdge_ExistingEdge_ShouldReturnWeight()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.Equal(1, network.GetWeightOfEdge(0, 1));
        }

        [Fact]
        public void GetWeightOfEdge_NonExistingEdge_ShouldReturnZero()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            Assert.Equal(0, network.GetWeightOfEdge(0, 2));
        }
    }
}
