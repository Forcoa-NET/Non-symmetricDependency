using Non_symmetricDependency.Algorithm.Exceptions;
using Non_symmetricDependency.Algorithm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Non_symmetricDependency.Algorithm.Models
{
    public class Network : INetwork
    {
        public int Size { get; }

        private readonly double[][] adjacencyMatrix;

        public Network(double[][] adjacencyMatrix)
        {
            if (adjacencyMatrix is null)
                throw new ArgumentNullException();

            if (!INetwork.IsSquareMatrix(adjacencyMatrix))
                throw new InvalidParametrException("Input is not square matrix");


            this.Size = adjacencyMatrix.Length;
            this.adjacencyMatrix = adjacencyMatrix;
        }

        public bool AreNeighbours(int x, int y)
        {
            if (x > Size || y > Size || x < 0 || y < 0)
                throw new IndexOutOfMatrixSpace("One of parametters is outside of matrix space.");

            return adjacencyMatrix[x][y] > 0;
        }

        public double GetWeightOfEdge(int x, int y)
        {
            if (x > Size || y > Size || x < 0 || y < 0)
                throw new IndexOutOfMatrixSpace("One of parametters is outside of matrix space.");

            return adjacencyMatrix[x][y];
        }

        public double GetNeighboursCoeficient(int x, int commonNeighbour, int y)
        {
            double divident = adjacencyMatrix[commonNeighbour][y];
            double divisor = adjacencyMatrix[x][commonNeighbour] + adjacencyMatrix[commonNeighbour][y];

            return divident / divisor;
        }

        public double GetNeighboursWeightSum(int node)
        {
            double[] adjanceMatrixRow = adjacencyMatrix[node];
            double weightsSum = 0;

            for (var i = 0; i < adjanceMatrixRow.Length; i++)
            {
                weightsSum += adjanceMatrixRow[i];
            }

            return weightsSum;
        }

        public List<int> GetCommonNeighboursIndexes(int x, int y)
        {
            List<int> CommonNeighbours = new List<int>();

            for (int i = 0; i < Size; i++)
            {
                if (adjacencyMatrix[x][i] > 0 && adjacencyMatrix[y][i] > 0)
                    CommonNeighbours.Add(i);

            }

            return CommonNeighbours;
        }
    }
}
