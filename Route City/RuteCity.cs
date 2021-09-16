using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
{
    public class RuteCity
    {
        static int nodesCount = 10;



        static List<Node> nodes = new List<Node>();
        //static List<List<Node>> shortestPath = new List<List<Node>>();
        static List<Node> shortestPath = new List<Node>();

        static readonly string[] verticesName = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        //static bool[] visited = new bool[nodesCount];
        /// <summary>
        ///  Initialize all distances as INFINITE and Edges as not visited.
        ///  Complexity = O(n)
        /// </summary>
        static void InitializeDefulltValue()
        {
            for (int i = 0; i < verticesName.Length; i++)
            {
                //var neighbors = new List<Node>();
                var node = new Node(verticesName[i], int.MaxValue, false);
                nodes.Add(node);
            }
        }

        /// <summary>
        /// Finds the shortest path.
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="startNode"></param>
        /// <param name="endNode"></param>
        public static void FindShortestPath(int[,] graph, int startNode, int endNode)
        {

            InitializeDefulltValue();
            SetStartNodeValue(startNode);





            foreach (var node in nodes)
            {

                //if (nodes.IndexOf(item) == endNode)
                //{

                var nodeIndex = MinDistance(nodes);


                foreach (var n in nodes)
                {
                    if (nodes.IndexOf(n) == nodeIndex)
                    {
                        n.Status = true;
                    }
                }
                // Update shortestPath value of the adjacent nodes of the
                // picked node.

                foreach (var item in nodes)
                {
                    var index = nodes.IndexOf(item);
                    //FindShortestPath(graph,index+1);


                    if (!nodes[index].Status && graph[nodeIndex, index] != 0 &&
                         nodes[nodeIndex].Cost != int.MaxValue &&
                         nodes[nodeIndex].Cost + graph[nodeIndex, index] < nodes[index].Cost)
                        nodes[index].Cost = nodes[nodeIndex].Cost + graph[nodeIndex, index];

                    //if (nodes.IndexOf(item) == endNode)
                    //{
                    //    break;
                    //}
                }


                // AddNeighbours(startNode);
            }


            PrintPath();


        }

        private static void AddNeighbours(int crenntNode)
        {
            var neighbors = new List<Node>();

            foreach (var node in nodes)
            {
                if (node.Cost != int.MaxValue && node.Cost != 0)
                {
                    shortestPath[crenntNode].Neighbours.Add(node);
                }
            }
        }

        /// <summary>
        /// Sets the start node to zero and marke it as visited.
        /// Complexity = O(n)
        /// </summary>
        /// <param name="startNode"></param>
        static void SetStartNodeValue(int startNode)
        {
            foreach (var node in nodes)
            {

                var nodeIndex = nodes.IndexOf(node);
                if (nodeIndex == startNode)
                {
                    node.Cost = 0;
                    node.Status = true;
                    shortestPath.Add(node);
                    break;
                }

            }
        }
        /// <summary>
        /// Finds min distance
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        static int MinDistance(List<Node> nodes)
        {

            int min = int.MaxValue;
            int min_index = -1;

            foreach (var node in nodes)
            {
                if (node.Status != true && node.Cost <= min)
                {
                    min = node.Cost;


                }
                else
                {
                    min_index = nodes.IndexOf(node);
                    //node.Status = true;
                    break;
                }

            }

            return min_index;
        }
        static void PrintPath()
        {
            foreach (var node in nodes)
            {
                Console.Write(node.Name + " \t\t " + node.Cost + "\n");
            }
        }
    }
}



//DIJKSTRA(Graf G, startnod s)
//       // Vi initierar alla noder i grafen.
//       // Billigaste vägen (avståndet) är oändligt
//       // och föregående nod är odefinierad.
//för i ∈ Noder(G) gör
//           avstånd[i] = OÄNDLIGT
//           föregångare[i] = NULL
//       // Avståndet till startnoden är 0.
//       avstånd[s] = 0
//       // Markera startnoden som avsökt.
//       Avsökt(s)
//       medan inte alla noder avsökta gör
//           // Finn den ej avsökta nod som har lägst nodpris
//           // tills alla är avsökta.
//           i = Minimum( ej avsökta noder )
//           för j ∈ närliggande(i) gör
//               // Undersök om det finns en billigare väg
//               // via nod i till närliggande noder.
//               om avstånd[j] > avstånd[i] + kostnad(i, j) gör
//                   avstånd[j] = avstånd[i] + kostnad(i, j)
//                   föregångare[j] = i
//           Avsökt(i)
