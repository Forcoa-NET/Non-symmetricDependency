namespace Non_symmetricDependency.Algorithm
{
    public struct Edge
    {
        public int NodeX { get; }
        public int NodeY { get; }
        public Edge(int x, int y)
        {
            this.NodeX = x;
            this.NodeY = y;
        }
    }
}
