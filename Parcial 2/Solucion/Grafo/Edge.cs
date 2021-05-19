using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Parcial_2.Grafo
{
    class Edge : IEquatable<Edge>
    {
        public int Weight { get; }
        public Vertex Start { get; }
        public Vertex End { get; }

        public Edge(int weight, Vertex start, Vertex end)
        {
            Weight = weight;
            Start = start;
            End = end;
        }

        public Edge Reverse()
        {
            return new Edge(Weight, End, Start);
        }

        public bool Equals(Edge e)
        {
            if (e == null)
            {
                return false;
            }
            if(Start == e.Start && End == e.End && Weight == e.Weight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
