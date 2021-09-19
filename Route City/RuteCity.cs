using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
    {
    public class RuteCity
        {
        static List<Node> nodes = new List<Node>();
        //static List<List<Node>> shortestPath = new List<List<Node>>();
        static List<Node> shortestPath = new List<Node>();
        static Stack myStack = new Stack();

        static readonly string[] verticesName = { "A","B","C","D","E","F","G","H","I","J" };
        //static bool[] visited = new bool[nodesCount];
        /// <summary>
        ///  Initialize all distances as INFINITE and Edges as not visited.
        ///  Complexity = O(n)
        /// </summary>

        static void InitializeDefulltValue()
            {
            //defulltValue();
            for (int i = 0; i < verticesName.Length; i++)
                {
                var neighbors = new List<Node>();
                var node = new Node(verticesName[i],int.MaxValue,false);
                nodes.Add(node);
                }
            }
        /// <summary>
        /// Finds the shortest path.
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="startNode"></param>
        /// <param name="endNode"></param>
        public static void Dijkstra(int[,] graph,int startNode,int endNode)
            {
            InitializeDefulltValue();
            SetStartNodeValue(startNode);
            foreach (var node in nodes)
                {
                var nodeIndex = MinDistance(nodes);
                if (nodes.IndexOf(node) == nodeIndex)
                    {
                    node.Status = true;
                    }
                // Update shortestPath value of the adjacent nodes of the
                // picked node.
                for (nodeIndex = 0; nodeIndex < nodes.Count; nodeIndex++)
                    {
                    foreach (var item in nodes)
                        {
                        var index = nodes.IndexOf(item);
                        //FindShortestPath(graph,index+1);

                        if (!nodes[index].Status && graph[nodeIndex,index] != 0 &&
                             nodes[nodeIndex].Cost != int.MaxValue &&
                             nodes[nodeIndex].Cost + graph[nodeIndex,index] < nodes[index].Cost)
                            nodes[index].Cost = nodes[nodeIndex].Cost + graph[nodeIndex,index];
                        }
                    }
                }
            PrintPath(endNode,startNode);
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
                    //shortestPath.Add(node);
                    //myStack.Push(node);
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
        static void PrintPath(int endNode,int startNode)            //Skriver ut start node och end node.
            {
            Console.WriteLine($"Från {nodes[startNode].Name} Till {nodes[endNode].Name} är snabbaste rutt {nodes[endNode].Cost} minuter.");
            }
        }
    }
