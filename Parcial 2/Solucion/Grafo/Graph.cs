using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2.Grafo
{
    class Graph
    {
        public List<Vertex> Verts;
        public List<Edge> Edges;

        public Graph(List<Vertex> verts, List<Edge> edges)
        {
            Verts = verts;
            Edges = edges;
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }
        public void AddVertex(Vertex vert)
        {
            Verts.Add(vert);
        }

        public void UnvisitAll()
        {
            foreach(Vertex v in Verts)
            {
                v.isVisited = false;
            }
        }


    }
}
