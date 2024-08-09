namespace Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(8);
            graph.ConnectBoth(0, 2, 1);
            graph.ConnectBoth(0, 4, 2);
            graph.ConnectBoth(2, 6, 5);
            graph.ConnectBoth(4, 6, 4);
            graph.ConnectBoth(6, 1, 7);
            graph.ConnectBoth(6, 5, 8);
            graph.ConnectBoth(6, 7, 4);
            graph.ConnectBoth(1, 3, 5);
            graph.ConnectBoth(1, 5, 2);
            graph.ConnectBoth(3, 7, 6);

            Dijkstra(graph, 0, out bool[] visited, out int[] distance, out int[] parent);
            for (int i = 0; i < graph.graph.GetLength(0); i++)
            {
                Console.WriteLine($"{i}.{visited[i],8}{distance[i],8}{WhoParent(parent, i),8}");
            }
        }

        public static string WhoParent(int[] parent,int parents)
        {
            string temp = "";
            if (parents == -1)
                return temp;
            temp = $"{parents}";
            return WhoParent(parent, parent[parents])+ temp;
        }
        public static void Dijkstra(/*그래프, 시작 정점, 방문?, 부모노드, */Graph graph, int start, out bool[] visited, out int[] distance, out int[] parent)
        {
            //방문, 부모노드 초기값
            int size = graph.graph.GetLength(0);
            visited = new bool[size];
            parent = new int[size];
            distance = new int[size];
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                distance[i] = graph.INF;
                parent[i] = -1;
            }
            distance[start] = 0;
            // 모든 노드에서 한번씩 해야함
            for (int i = 0; i < size; i++)
            {
                int minIndex = -1;
                int minCost = graph.INF;
                //방문하지 않았으며, 가중치가 가장 낮은 노드 선정
                for (int j = 0; j < size; j++)
                {
                    if (visited[j] == false &&
                        distance[j] < minCost)
                    {
                        minIndex = j;
                        minCost = distance[j];
                    }
                }
                if (minIndex < 0) // 연결되어 있으면서 탐색한적이 없는 정점이 없었던 경우
                    break;
                visited[minIndex] = true;
                //만약 합한 가중치의 합이 기존 가중치의 합보다 작은 경우 가중치의 값을 지정해주고, 부모노드를 교체
                for (int j = 0; j < size; j++)
                {
                    if (distance[j] > distance[minIndex] + graph.graph[minIndex, j])
                    {
                        distance[j] = distance[minIndex] + graph.graph[minIndex, j];
                        parent[j] = minIndex;
                    }
                }
            }
            //반복
        }
    }
}
