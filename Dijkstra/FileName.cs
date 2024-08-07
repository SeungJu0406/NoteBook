using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Graph
    {
        public int[,] graph {  get; private set; }
        public int INF {  get; private set; }
        public Graph(int n)
        {
            INF = 999999;
            graph = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    graph[i, j] = INF;
                }
            }
        }
        public void Connect(int from, int to, int value)
        {
            graph[from, to] = value;
        }
        public void ConnectBoth(int a , int b, int value)
        {
            graph[a, b] = value;
            graph[b,a] = value;
        }
        public void DisConnect(int from, int to)
        {
            graph[from, to] = INF;
        }
        public bool IsConnect(int from , int to)
        {
            return graph[from, to] != INF ? true: false;
        }
    }
}
