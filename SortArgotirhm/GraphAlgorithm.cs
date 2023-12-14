using System;
using System.Collections.Generic;

namespace BasicAlgorithm
{
    using System;
    using System.Collections.Generic;

    public class Graph
    {
        private int V; // 그래프의 정점 개수
        private List<int>[] adj; // 인접 리스트


        public static void MakeGraph()
        {

            Graph graph = new Graph(6);

            Console.WriteLine();
            Console.WriteLine("GRAPH : 정점(vretax)과 간선(edge)으로 이루어진 구조");
            Console.WriteLine("방향 그래프(Directed Graph)와 무방향 그래프(UnDirected Graph)로 나뉨");
            Console.WriteLine("가중치 그래프(Weighted Graph)는 간선에 가중치가 있음");
            Console.WriteLine();

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 5);
            graph.AddEdge(4, 5);

            Console.WriteLine("DFS는 루트에서 시작하여 가능한 깊이 들어가서 노드를 탐색하고");
            Console.WriteLine("더는 들어갈 공간이 없으면 다시 돌아오는 탐색방식");
            Console.WriteLine("DFS traversal:");
            graph.DFS(0);
            Console.WriteLine();

            Console.WriteLine("BFS는 루트에서 시작하여 가까운 노드들을 먼저 탐색하고");
            Console.WriteLine("그 이후 다음 레벨의 노드들을 탐색하는 방식");
            Console.WriteLine("BFS traversal:");
            graph.BFS(0);
            Console.WriteLine();

        }


        public Graph(int v)
        {
            V = v;
            adj = new List<int>[V];
            for (int i = 0; i < V; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        public void DFS(int v)
        {
            bool[] visited = new bool[V];
            DFSUtil(v, visited);
        }

        private void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write($"{v} ");

            foreach (int n in adj[v])
            {
                if (!visited[n])
                {
                    DFSUtil(n, visited);
                }
            }
        }

        public void BFS(int v)
        {
            bool[] visited = new bool[V];
            Queue<int> queue = new Queue<int>();

            visited[v] = true;
            queue.Enqueue(v);

            while (queue.Count > 0)
            {
                int n = queue.Dequeue();
                Console.Write($"{n} ");

                foreach (int m in adj[n])
                {
                    if (!visited[m])
                    {
                        visited[m] = true;
                        queue.Enqueue(m);
                    }
                }
            }
        }
    }

}