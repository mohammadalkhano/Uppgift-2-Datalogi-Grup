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
        static List<Node> shortestPath = new List<Node>();

        static readonly string[] verticesName = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        //static bool[] visited = new bool[nodesCount];
        /// <summary>
        ///  Initialize all distances as INFINITE and Edges as not visited.
        /// </summary>
        static void InitializeDefulltValue()
        {
            for (int i = 0; i < nodesCount; i++)
            {
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
        public static void FindShortestPath(int[,] graph, string startNodeName, string endNodename)
        {

            InitializeDefulltValue();
            //refactoring, Big O notation?           
            string name = startNodeName.ToUpper();
            string endNode = endNodename.ToUpper();
            foreach (var node in nodes)
            {
                //move it to new method there where you take input from the user.
                if (!string.IsNullOrEmpty(name) && string.Equals(name, node.Name))
                {
                    node.Cost = 0;
                    shortestPath.Add(node);
                }

            }



            foreach (var item in nodes)
            {
                while (!string.Equals(item.Name, endNode))
                {

                    var nodeIndex = minDistanc(nodes);

                    // Update shortestPath value of the adjacent nodes of the
                    // picked node.

                    for (int nodeCount = 0; nodeCount < nodes.Count; nodeCount++)
                
                        if (!nodes[nodeCount].Mode && graph[nodeIndex, nodeCount] != 0 &&
                             shortestPath[nodeIndex].Cost != int.MaxValue &&
                             shortestPath[nodeIndex].Cost + graph[nodeIndex, nodeCount] < shortestPath[nodeCount].Cost)
                            shortestPath[nodeCount].Cost = shortestPath[nodeIndex].Cost + graph[nodeIndex, nodeCount];
                }
                foreach (var node in shortestPath)
                {
                    Console.Write(node.Name + " \t\t " + node.Cost + "\n");
                }

            }


        }
        /// <summary>
        /// Finds min distance
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        static int minDistanc(List<Node> nodes)
        {
            // Initialize min value
            int min = int.MaxValue;
            int min_index = -1;

            foreach (var node in nodes)
            {
                if (node.Mode == false && node.Cost <= min)
                {
                    min = node.Cost;
                    min_index = nodes.IndexOf(node);

                }

            }

            return min_index;
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
