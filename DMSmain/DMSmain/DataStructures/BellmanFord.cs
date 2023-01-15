using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.DataStructures
{
    public class Edge
    {
        public int src, dest, weight;
        public int res = 0;

        public Edge()
        {
            src = dest = weight = 0;
        }
    }
    public class BellmanFord
    { 
        

        int V, E;
        Edge[] edge;

         
        BellmanFord(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edge[e];
            for (int i = 0; i < e; ++i)
                edge[i] = new Edge();
        } 
        public void BellmanFordEvaluation(int src)
        {
            int[] dist = new int[V];
            for (int i = 0; i < V; ++i)
                dist[i] = int.MaxValue;
            dist[src] = 0;
            
            for (int i = 1; i < V; ++i)
            {
                for (int j = 0; j < E; ++j)
                {
                    int u = edge[j].src;
                    int v = edge[j].dest;
                    int weight = edge[j].weight;
                    if (dist[u] != int.MaxValue &&
                        dist[u] + weight < dist[v])
                        dist[v] = dist[u] + weight;
                }
            } 
            for (int j = 0; j < E; ++j)
            {
                int u = edge[j].src;
                int v = edge[j].dest;
                int weight = edge[j].weight;
                if (dist[u] != int.MaxValue &&
                    dist[u] + weight < dist[v])
                    Console.Write("Graph contains negative weight cycle");
            }

            Console.Write("Vertex Distance from Source");
            for (int i = 0; i < V; ++i)
                Console.Write("\n" + i + "\t\t" + dist[i]);
        }
    }
}
