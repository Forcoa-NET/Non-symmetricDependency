using Non_symmetricDependency.Algorithm.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Non_symmetricDependency.Algorithm
{
    public class DependencyAlgorithm 
    {
        private double[][] DependencyMatrix;

        private readonly INetwork network;

        public DependencyAlgorithm(INetwork network)
        {
            this.network = network;
            DependencyMatrix = new double[network.Size][];
        }

        public double[][] GetDependencyMatrix()
        {
            return DependencyMatrix;
        }

        private void CalculateDependency(Edge m)
        {
            DependencyMatrix[m.NodeX][m.NodeY] = DependencyOf(m.NodeX, m.NodeY);
        }

        public double DependencyOf(int x, int y)
        {
            double divident = network.GetWeightOfEdge(x,y) + GetCommonNeighboutsWeightsTimesCoef(x, y);
            double divisor = network.GetNeighboursWeightSum(x);

            return divident / divisor;
        }

        private double GetCommonNeighboutsWeightsTimesCoef(int x, int y)
        {
            double WeightsTimesCoef = 0;
            List<int> commonNeighbours = network.GetCommonNeighboursIndexes(x, y);

            foreach (int neighbour in commonNeighbours)
            {
                WeightsTimesCoef += (network.GetCommonNeighboursWeight(x, neighbour) * network.GetNeighboursCoeficient(x, neighbour, y));
            }

            return WeightsTimesCoef;
        }

        public void Execute()
        {
            Parallel.For(0, network.Size, i => {
                for (int j = 0; j < network.Size; ++j)
                {
                    if (network.AreNeighbours(i, j))
                    {
                        CalculateDependency(new Edge(i, j));
                    }
                }
            });
        }
    }
}
