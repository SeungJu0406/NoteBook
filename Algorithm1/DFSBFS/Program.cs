namespace DFSBFS
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static void DFS(bool[,] graph, int vertex, bool[] visited, int[] parent)
        {
            int size = graph.GetLength(0);
            // 모든 visited와 parent에 기본값 
            visited = new bool[size];
            parent = new int[size];
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1;
            }
            // 자식 노드 함수 작성
            SearchNode(graph, vertex, visited, parent);
        }
        public static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parent)
        {
            // 현재 찾은 노드 입력
            visited[vertex] = true;
            // 해당 노드에서 자식 노드가 있을때 해당 함수 반복
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[vertex, i] == true &&  // 연결 되어있으며
                    visited[i] != true) // 방문한곳이 아닐때
                {
                    parent[i] = vertex;
                    SearchNode(graph, i, visited, parent);
                }
            }
        }

        public static void BFS(bool[,] graph, int vertex, bool[] visited, int[] parent)
        {
            // visited와 parent에 기본값 입력
            int size = graph.GetLength(0);
            visited = new bool[size];
            parent = new int[size];
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1;
            }
            // 큐 생성 큐에 초기값 넣기
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(vertex);
            visited[vertex] = true;
            // 큐의 값을 꺼낸 후 해당 값과 연결될 수 있는 분기점 차례로 큐에 넣기
            while (queue.Count > 0)
            {
                int next = queue.Dequeue();
                for (int i = 0; i < size; i++)
                {
                    if (graph[next, i] == true &&
                        visited[i] != true)
                    {
                        visited[i] = true;
                        parent[i] = next;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}