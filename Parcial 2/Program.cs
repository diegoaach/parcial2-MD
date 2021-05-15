using System;
using System.Collections.Generic;
using QuikGraph;
using QuikGraph.Algorithms;


namespace Parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            var res = new List<string>();
            while (t > 0)
            {
                var graph = new UndirectedGraph<string,TaggedUndirectedEdge<string,int>>();
                String[] ini = Console.ReadLine().Split();
                String source = ini[0];
                String target = ini[1];
                graph.AddVertex(source);
                graph.AddVertex(target);
                for(int i=0;i<t;i++)
                {
                    String[] newVer = Console.ReadLine().Split();
                    int edgeC = newVer[2].Length;
                    for (int c=0;c<2;c++)
                    {
                        if(!graph.ContainsVertex(newVer[c]))
                        {
                            graph.AddVertex(newVer[c]);   
                        }
                    }
                    var edge = new TaggedUndirectedEdge<string, int>(newVer[0], newVer[1], edgeC);
                    graph.AddEdge(edge);
                }              
                Func<TaggedUndirectedEdge< string,int >, double> edgeCost = edge => 1;
                TryFunc<String, IEnumerable<TaggedUndirectedEdge< string,int >>> tryGetPaths = graph.ShortestPathsDijkstra(edgeCost, source);

                if (tryGetPaths(target, out IEnumerable<TaggedUndirectedEdge< string,int >> path))
                {
                    foreach(TaggedUndirectedEdge<string, int> edge in path)
                    {
                        Console.WriteLine(edge);
                    }
                }

            }
        }
    }
}
