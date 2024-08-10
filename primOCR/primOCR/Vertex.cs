using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vertex
{
    public string Name { get; }
    public Dictionary<Vertex, int> Edges { get; } 

    public Vertex(string name)
    {
        Name = name;
        Edges = new Dictionary<Vertex, int>();
    }

    public void AddEdge(Vertex vertex, int weight)
    {
        if (!Edges.ContainsKey(vertex) && vertex != this)
        {
            Edges[vertex] = weight;
            vertex.Edges[this] = weight;
        }
    }
    public void RemoveEdge(Vertex vertex)
    {
        if (Edges.ContainsKey(vertex))
        {
            Edges.Remove(vertex);
            vertex.Edges.Remove(this); 
        }
    }
}


