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

        public double GetCommonNeighboursWeight(int x, int neighbour);

        public double GetNeighboursCoeficient(int x, int neighbour, int y);

        public double GetNeighboursWeightSum(int node);

        public List<int> GetCommonNeighboursIndexes(int x, int y);
    }
}
