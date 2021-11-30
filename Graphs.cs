using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public static class Graphs
    {
        public static Graph G1()
        {
            List<Vertex> V = new List<Vertex>() { new Vertex("A"), new Vertex("B"), 
                new Vertex("C"), new Vertex("D"), 
                new Vertex("E"), new Vertex("F"), 
                        new Vertex("G") };
            List<Edge> E = new List<Edge>() { new Edge("1", V[0], V[1]), new Edge("2", V[1], V[2]),
                new Edge("3", V[2], V[3]), new Edge("4", V[3], V[4]),
                new Edge("5", V[3], V[5]), new Edge("6", V[5], V[2]),
                new Edge("7", V[5], V[6]), new Edge("8", V[6], V[0])};
            return new Graph(V, E);
        }
    }
}
