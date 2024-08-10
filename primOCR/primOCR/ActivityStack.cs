using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primOCR
{
    
    internal class ActivityStack
    { 
        public List<Vertex> vertices = new List<Vertex>();
        public Boolean edgeConnected;
        public Boolean newVertix;
        int top=0;
        public ActivityStack() { 
            edgeConnected = false;
            newVertix = false;
        }
        public void push(Vertex v)
        {
            vertices.Add(v);
        }
        public void undo(Graph g)
        {
            g.RemoveVertex(g.GetLast());
        }
   
    }
}
