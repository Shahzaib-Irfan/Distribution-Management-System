using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.DataStructures
{

    public class Dijkstra
    {
        public class AdjListNode
        {
            public int dest { get; set; }
            public int weight { get; set; }
            public AdjListNode next { get; set; }
        }

        public class AdjList
        {
            public AdjListNode head { get; set; }
        }

        public class Graph
        {
            public int V { get; set; }
            public AdjList[] array { get; set; }
        }

        public static AdjListNode newAdjListNode(int dest, int weight)
        {
            AdjListNode newNode = new AdjListNode();
            newNode.dest = dest;
            newNode.weight = weight;
            newNode.next = null;
            return newNode;
        }

        public static Graph createGraph(int V)
        {
            Graph graph = new Graph();
            graph.V = V;

            graph.array = new AdjList[V];

            for (int i = 0; i < V; ++i)
                graph.array[i].head = null;

            return graph;
        }

        public static void addEdge(Graph graph, int src, int dest, int weight)
        {
            AdjListNode newNode = newAdjListNode(dest, weight);
            newNode.next = graph.array[src].head;
            graph.array[src].head = newNode;

            newNode = newAdjListNode(src, weight);
            newNode.next = graph.array[dest].head;
            graph.array[dest].head = newNode;
        }

        public class MinHeapNode
        {
            public int v { get; set; }
            public int dist { get; set; }
        }

        public class MinHeap
        {
            public int size { get; set; }       
            public int capacity { get; set; }  
            public int[] pos { get; set; }     
            public MinHeapNode[] array { get; set; }  
        }

        public static MinHeapNode newMinHeapNode(int v, int dist)
        {
            MinHeapNode minHeapNode = new MinHeapNode();
            minHeapNode.v = v;
            minHeapNode.dist = dist;
            return minHeapNode;
        }

        public static MinHeap createMinHeap(int capacity)
        {
            MinHeap minHeap = new MinHeap();
            minHeap.pos = new int[capacity];
            minHeap.size = 0;
            minHeap.capacity = capacity;
            minHeap.array = new MinHeapNode[capacity];
            return minHeap;
        }
 
        public static void swapMinHeapNode(MinHeapNode[] a, int i, int j)
        {
            MinHeapNode temp = new MinHeapNode();
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static void minHeapify(MinHeap minHeap, int idx)
        {
            int smallest, left, right;
            smallest = idx;
            left = 2 * idx + 1;
            right = 2 * idx + 2;

            if (left < minHeap.size &&
                minHeap.array[left].dist < minHeap.array[smallest].dist)
                smallest = left;

            if (right < minHeap.size &&
                minHeap.array[right].dist < minHeap.array[smallest].dist)
                smallest = right;

            if (smallest != idx)
            {
                // The nodes to be swapped in min heap 
                MinHeapNode smallestNode = minHeap.array[smallest];
                MinHeapNode idxNode = minHeap.array[idx];

                // Swap positions 
                minHeap.pos[smallestNode.v] = idx;
                minHeap.pos[idxNode.v] = smallest;

                // Swap nodes 
                swapMinHeapNode(minHeap.array, smallest, idx);

                minHeapify(minHeap, smallest);
            }
        }

        public static bool isEmpty(MinHeap minHeap)
        {
            return minHeap.size == 0;
        }

        public static MinHeapNode extractMin(MinHeap minHeap)
        {
            if (isEmpty(minHeap))
                return null;

            MinHeapNode root = minHeap.array[0];

            MinHeapNode lastNode = minHeap.array[minHeap.size - 1];
            minHeap.array[0] = lastNode;
            minHeap.pos[root.v] = minHeap.size - 1;
            minHeap.pos[lastNode.v] = 0;


            --minHeap.size;
            minHeapify(minHeap, 0);

            return root;
        }

        // Function to decreasy dist value of a given vertex v. This function 
        // uses pos[] of min heap to get the current index of node in min heap 
        /*public static void decreaseKey(MinHeap minHeap, int v, int dist)
        {
            // Get the index of v in  heap array 
            int i = minHeap.pos[v];

            // Get the node and update its dist value 
            minHeap.array[i].dist = dist;

            // Travel up while the complete tree is not hepified. 
            // This is a O(Logn) loop 
            while (i > 0 && minHeap.array[i].dist < minHeap.array[(i - 1) / 2].dist)
            {
                // Swap this node with its parent 
                minHeap.pos[minHeap.array[i].v] = (i - 1) / 2;
                minHeap.pos[minHeap.array[(i - 1) / 2].v] = i;
                swapMinHeapNode(minHeap.array, i, (i - 1) / 2);

                // move to parent index 
                iI = (i - 1) / 2;
            }
        }*/

        // A utility function to check if a given vertex 
        // 'v' is in min heap or not 
        public static bool isInMinHeap(MinHeap minHeap, int v)
        {
            if (minHeap.pos[v] < minHeap.size)
                return true;
            return false;
        }

        public static void printArr(int[] dist, int n)
        {
            Console.Write("Vertex   Distance from Source\n");
            for (int i = 0; i < n; ++i)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }

        public static void dijkstra(Graph graph, int src)
        {
            int V = graph.V; 
            int[] dist = new int[V]; 

            MinHeap minHeap = createMinHeap(V);

            for (int v = 0; v < V; ++v)
            {
                dist[v] = int.MaxValue;
                minHeap.array[v] = newMinHeapNode(v, dist[v]);
                minHeap.pos[v] = v;
            }

            minHeap.array[src] = newMinHeapNode(src, dist[src]);
            minHeap.pos[src] = src;
            dist[src] = 0;
            //decreaseKey(minHeap, src, dist[src]);
            minHeap.size = V;
 
            while (!isEmpty(minHeap))
            {
                MinHeapNode minHeapNode = extractMin(minHeap);
                int u = minHeapNode.v; 
 
                AdjListNode pCrawl = graph.array[u].head;
                while (pCrawl != null)
                {
                    int v = pCrawl.dest;

                    if (isInMinHeap(minHeap, v) && dist[u] != int.MaxValue &&
                        pCrawl.weight + dist[u] < dist[v])
                    {
                        dist[v] = dist[u] + pCrawl.weight;

                        //decreaseKey(minHeap, v, dist[v]);
                    }
                    pCrawl = pCrawl.next;
                }
            }

            printArr(dist, V);
        }
    }
}
