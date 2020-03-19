using System;
using System.Collections.Generic;
using System.Text;

namespace Non_symmetricDependency.Algorithm.Models
{
    public interface INetwork
    {
        public int Size { get; }

        public bool AreNeighbours(int x, int y);

        public double GetWeightOfEdge(int x, int y);

        public double GetNeighboursCoeficient(int x, int neighbour, int y);

        public double GetNeighboursWeightSum(int node);

        public List<int> GetCommonNeighboursIndexes(int x, int y);

        public static bool IsSquareMatrix(double[][] matrix)
        {
            var colCount = matrix.Length;

            for (int i = 0; i < colCount; i++)
            {
                if (matrix[i].Length != colCount)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
