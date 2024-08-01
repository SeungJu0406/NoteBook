namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>[] graph = new List<int>[4];
            for (int i = 0; i < graph.Length; i++) 
            {
                graph[i]=new List<int>();
            }
            graph[0].Add(1);
            graph[0].Add(3);
            graph[1].Add(2);
            graph[2].Add(3);
            graph[3].Add(4);
        }
    }
}
