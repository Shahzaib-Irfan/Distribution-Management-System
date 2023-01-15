using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps
{
    public class DFS
    {

        public int vertices;
        public Dictionary<string, List<Tuple<string, int>>> adjList;

        public DFS(int vertices)
        {
            this.vertices = vertices;
            adjList = new Dictionary<string, List<Tuple<string, int>>>();
        }

        public void addEdge(string source, string destination, int weight)
        {
            if (!adjList.ContainsKey(source))
            {
                adjList.Add(source, new List<Tuple<string, int>>());
            }
            adjList[source].Add(Tuple.Create(destination, weight));
        }

        
    }
}
