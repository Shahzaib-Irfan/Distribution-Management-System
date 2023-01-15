using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gmaps
{
    public class PrimsAlgorithm
    {
        
        public int vertices;
        public int[,] graph;
        public string[] vertexName;
        public int[] parent;
        public PrimsAlgorithm(int[,] graph, string[] vertexName)
        {
            this.graph = graph;
            this.vertexName = vertexName;
            this.vertices = graph.GetLength(0);
            parent= new int[vertices];
        }

        public int minKey(int[] key, bool[] mstSet)
        {
            // Initialize min value
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < vertices; v++)
            {
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }

        // Function to print the constructed MST stored in parent[]
        

       
        public void primMST()
        {
            
            //parent =  new int[vertices];
            int[] key = new int[vertices];
            bool[] mstSet = new bool[vertices];


            for (int i = 0; i < vertices; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            
            key[0] = 0;     
            parent[0] = -1; 
            for (int count = 0; count < vertices - 1; count++)
            {
                
                int u = minKey(key, mstSet);
                mstSet[u] = true;

                for (int v = 0; v < vertices; v++)
                {  
                    if (graph[u, v] != 0 && mstSet[v] == false && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
                }
            }

            // print the constructed MST
            //printMST(parent, vertices, graph);
        }

        
    }
}
