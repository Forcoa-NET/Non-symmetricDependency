using Non_symmetricDependency.Algorithm.Exceptions;

namespace Non_symmetricDependency.Algorithm
{
    public struct Edge
    {
        public int NodeX { get; }
        public int NodeY { get; }
        public Edge(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new InvalidParametrException("One of parameter is a negative number.");

            this.NodeX = x;
            this.NodeY = y;
        }
    }
}
