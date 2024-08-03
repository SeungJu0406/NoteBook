using System.Numerics;

public class Program
{
    static void Main()
    {
        ListGraph graph = new ListGraph(8);
    }
}

public struct Vertex
{
    public string name;
}

public class ListGraph
{
    private List<int>[] graph;
    private Vertex[] vertexs;

    public int VertexCount => graph.Length;

    public ListGraph(int vertexCount)
    {
        vertexs = new Vertex[vertexCount];
        graph = new List<int>[vertexCount];
        for (int i = 0; i < vertexCount; i++)
        {
            graph[i] = new List<int>();
        }
    }

    public void Connect(int from, int to)
    {
        graph[from].Add(to);
    }

    public void DisConnect(int from, int to)
    {
        graph[from].Remove(to);
    }

    public bool IsConnect(int from, int to)
    {
        return graph[from].Contains(to);
    }

    public void SetVertex(int index, string name)
    {
        vertexs[index].name = name;
    }

    public Vertex GetVertex(int index)
    {
        return vertexs[index];
    }
}


public class Graph
{
    struct Edge
    {
        public int dest;
        public int weight;

        public Edge(int dest, int weight)
        {
            this.dest = dest;
            this.weight = weight;
        }
    }

    private List<Edge>[] graph;

    public Graph(int vertexCount)
    {
        graph = new List<Edge>[vertexCount];
        for (int i = 0; i < vertexCount; i++)
        {
            graph[i] = new List<Edge>();
        }
    }

    public void Connect(int from, int to, int weight)
    {
        Edge edge = new Edge(to, weight);
        graph[from].Add(edge);
    }

    public void DisConnect(int from, int to)
    {
        for (int i = 0; i < graph[from].Count; i++)
        {
            if (graph[from][i].dest == to)
            {
                graph[from].RemoveAt(i);
                return;
            }
        }
    }

    public int GetWeight(int from, int to)
    {
        for (int i = 0; i < graph[from].Count; i++)
        {
            if (graph[from][i].dest == to)
            {
                return graph[from][i].weight;
            }
        }

        Console.WriteLine("간선이 없음");
        return -1;
    }
}