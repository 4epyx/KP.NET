using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Vertex
    {
        String Name;
        bool wasTraversed;
        public Vertex(String name)
        {
            this.Name = name;
            this.wasTraversed = false;
        }

        public String getName()
        {
            return this.Name;
        }

        public bool Travers
        {
            get
            {
                return this.wasTraversed;
            }
            set
            {
                this.wasTraversed = value;
            }
        }
    }
}
