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

            int c = 5;
            Route_City.RuteCity.Dijkstra(graph, c, 2);
            Console.Read();
        }

    }
}
