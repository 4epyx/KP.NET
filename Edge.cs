using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Edge
    {
        String Name;
        Vertex vertexStart;
        Vertex vertexEnd;

        public Edge(String Name, Vertex vStart, Vertex vEnd)
        {
            this.Name = Name;
            this.vertexStart = vStart;
            this.vertexEnd = vEnd;
        }

        public Vertex vStart
        {
            get
            {
                return this.vertexStart;
            }
        }
        public Vertex vEnd
        {
            get
            {
                return this.vertexEnd;
            }
        }
    }
}
