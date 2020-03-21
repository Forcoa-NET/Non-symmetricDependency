using Non_symmetricDependency.Algorithm;
using Non_symmetricDependency.Algorithm.Exceptions;
using Non_symmetricDependency.Algorithm.Models;
using Xunit;

namespace Non_symmetricDependency.UnitTests
{
    public class AlgorithmTests
    {
        public AlgorithmTests()
        {

        }

        [Fact]
        public void GetDependencyMatrix_BeforeExecution_ShouldThrow()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            var alg = new DependencyAlgorithm(network);

            Assert.Throws<AlgorithmNotExecuted>(() => alg.GetDependencyMatrix());
        }

        [Fact]
        public void GetDependencyMatrix_AfterExecution_ShouldReturnMatrixDameSizaAsInput()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            var alg = new DependencyAlgorithm(network);

            alg.Execute();

            Assert.Equal(3, alg.GetDependencyMatrix().Length);
        }

        [Fact]
        public void DependencyOf_ExistinIndexes_ShouldReturnDependency()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 0 },
                        new double[] { 1, 0, 1 },
                        new double[] { 0, 1, 0 }
                    };

            var network = new Network(matrix);

            var alg = new DependencyAlgorithm(network);

            Assert.Equal(1, alg.DependencyOf(0,1));
        }

        [Fact]
        public void DependencyOf_ExistinIndexes2_ShouldReturnDependency()
        {
            double[][] matrix =
                    {
                        new double[] { 0, 1, 1 },
                        new double[] { 1, 0, 1 },
                        new double[] { 1, 1, 0 }
                    };

            var network = new Network(matrix);

            var alg = new DependencyAlgorithm(network);

            Assert.Equal(0.75, alg.DependencyOf(0, 1));
        }
    }
}
