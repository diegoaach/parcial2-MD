using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2.Grafo
{
    class Vertex: IEquatable<Vertex>
    {
        public List<Vertex> Neigh;
        public List<Edge> Edges;
        public String Name; 
        public Boolean isVisited;

        public Vertex(String name)
        {
            this.Name = name;
            isVisited = false;
        }
        public bool Equals(Vertex v) 
        {
            if (v == null)
            {
                return false;
            }
            if(Name == v.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }

        public void AddNeighbor(Vertex neighbor)
        {
            Neigh.Add(neighbor);
        }






    }
}
