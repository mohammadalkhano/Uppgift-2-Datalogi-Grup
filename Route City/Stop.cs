using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
{
    public class Stop
    {
        static void InitializeDefulltValue()
        {
            // Initialize all distances as
            // INFINITE and stpSet[] as false
            for (int i = 0; i < vertices; i++)
            {
                shortestPaht[i] = int.MaxValue;
                sptSet[i] = false;
            }
        }

        static char[] verticesName = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        int[,] adjecencyMatrix =
            {
                    {0,4,7,0,7,0,0,0,0,0 },
                    {4,0,3,12,0,0,0,5,0,0},
                    {7,3,0,0,0,0,4,0,12,0},
                    {0,12,0,0,0,0,0,7,3,0},
                    {7,0,0,0,0,3,5,0,0,0 },
                    {0,0, 0,0,3,0,5,0,0,0},
                    {0,0,4,0,5,5,0,8,13,8},
                    {0,5,0,7,0,0,8,0,0,9},
                    {0,0,12,3,0,0,13,0,0,7},
                    {0,0,0,0,0,0,8,9,7,0}
            };

        // The output array. dist[i] will hold the shortest distance from src to i


        // Number of vertices


        //static int vertices = 10;
        //static int vertices = Convert.ToChar(Console.ReadLine());
        static int vertices = int.Parse(Console.ReadLine());
        //char vertices = Convert.ToChar(vertices_int);

        static int[] shortestPaht = new int[vertices];
        // sptSet[i] will true if vertex
        // i is included in shortest path
        // tree or shortest distance from
        // src to i is finalized
        static bool[] sptSet = new bool[vertices];



        static int minDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue;
            int min_index = -1;

            for (int i = 0; i < vertices; i++)
                if (sptSet[i] == false && dist[i] <= min)
                {
                    min = dist[i];
                    min_index = i;
                }

            return min_index;
        }

        // A utility function to print
        // the constructed distance array
        static void printShortestPath(int[] dist, int n)
        {
            Console.Write("Stops	 Distance from "+ vertices +" to  A\n");
            for (int i = 0; i < vertices; i++)
                Console.Write(verticesName[i] + " \t\t " + dist[i] + "\n");
        }

        // Function that implements Dijkstra's
        // single source shortest path algorithm
        // for a graph represented using adjacency
        // matrix representation
        public static void dijkstra(int[,] graph, int src)
        {

            InitializeDefulltValue();
            // Distance of source vertex
            // from itself is always 0
            shortestPaht[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < vertices - 1; count++)
            {
                // Pick the minimum distance vertex
                // from the set of vertices not yet
                // processed. u is always equal to
                // src in first iteration.
                int u = minDistance(shortestPaht, sptSet);

                // Mark the picked vertex as processed
                sptSet[u] = true;

                // Update dist value of the adjacent
                // vertices of the picked vertex.
                for (int v = 0; v < vertices; v++)

                    // Update dist[v] only if is not in
                    // sptSet, there is an edge from u
                    // to v, and total weight of path
                    // from src to v through u is smaller
                    // than current value of dist[v]
                    if (!sptSet[v] && graph[u, v] != 0 &&
                        shortestPaht[u] != int.MaxValue && shortestPaht[u] + graph[u, v] < shortestPaht[v])
                        shortestPaht[v] = shortestPaht[u] + graph[u, v];
            }

            // print the constructed distance array
            printShortestPath(shortestPaht, vertices);
        }


    }

    // This code is contributed by ChitraNayal


}
