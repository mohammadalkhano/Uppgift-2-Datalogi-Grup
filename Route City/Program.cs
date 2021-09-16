using System;

namespace Route_City
{
    //The used source to represent the data and implement Dijkstra's algorithm is:
    //https://www.youtube.com/watch?v=09_LlHjoEiY&ab_channel=freeCodeCamp.org
    class Program
        {
        static void Main(string[] args)
        {
            int[,] graph =
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

            int a = 2, c = 5;
            Route_City.RuteCity.FindShortestPath(graph,0,2);
            Console.WriteLine("\t\t\t stop class \t\t\t");
            //Stop.dijkstra(graph,0);


            Console.Read();
		}
        // Driver Code
        //public static void Main1()
        //{
        //    /* Let us create the example
        // graph discussed above */
        //    int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
        //                            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
        //                            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
        //                            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
        //                            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
        //                            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
        //                            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
        //                            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
        //                            { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
        //    GFG t = new GFG();
        //    t.dijkstra(graph, 0);
        //}
        }
    }
