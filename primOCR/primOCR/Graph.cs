using primOCR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

class Graph
{
    public List<Tuple<string, string, int>> RemovedEdges { get; private set; }
    public List<Vertex> vertices;
    public int totalweight;
    public Graph()
    {

        vertices = new List<Vertex>();
        RemovedEdges = new List<Tuple<string, string, int>>();
    }

    public void AddVertex(Vertex vertex)
    {
        vertices.Add(vertex);
    }

    public Vertex GetVertex(string name)
    {
        return vertices.FirstOrDefault(v => v.Name == name);
    }
    public Vertex GetLast()
    {
        return vertices.Last();
    }
    
    public void DisplayGraph(Form1 form)
    {
        string message = "";
        foreach (var vertex in vertices)
        {
            message += $"Vertex: {vertex.Name}\n";
            message += "Edges:\n";
            foreach (var edge in vertex.Edges)
            {
                message += $"   Connected to {edge.Key.Name} with weight {edge.Value}\n";
            }
            message += "\n";
        }
        form.updateConnections(message);
    }
    public void RemoveVertex(Vertex vertex)
    {
        vertices.Remove(vertex);
        foreach (var v in vertices)
        {
            v.RemoveEdge(vertex);
        }
    }
    public List<Tuple<string, string, int>> CalculateMSTUsingPrim()
    {
       
        List<Tuple<string, string, int>> minimumSpanningTree = new List<Tuple<string, string, int>>();
        HashSet<string> visited = new HashSet<string>();
        Dictionary<string, string> parent = new Dictionary<string, string>();

        if (vertices.Count == 0)
            return minimumSpanningTree;

        string startVertex = vertices[0].Name; 
        visited.Add(startVertex);
        parent[startVertex] = null;

        while (visited.Count < vertices.Count)
        {
            int minWeight = int.MaxValue;
            string minFrom = null;
            string minTo = null;

            foreach (var vertex in vertices)
            {
                if (visited.Contains(vertex.Name))
                {
                    foreach (var edge in vertex.Edges)
                    {
                        if (!visited.Contains(edge.Key.Name) && edge.Value < minWeight)
                        {
                            minWeight = edge.Value;
                            minFrom = vertex.Name;
                            minTo = edge.Key.Name;
                        }
                    }
                }
            }

            if (minTo != null)
            {
                visited.Add(minTo);
                minimumSpanningTree.Add(Tuple.Create(minFrom, minTo, minWeight));
                parent[minTo] = minFrom;
                totalweight += minWeight;
            }
            else
            {
                RemovedEdges.Add(Tuple.Create(minFrom, minTo, minWeight));
            }
        }

        return minimumSpanningTree;
    }
    
}