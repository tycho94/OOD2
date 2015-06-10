using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogoFamis
{
    class Dijkstra
    {
        
        //public override List<Location> CalculateNext()
        //{
        //    List<Location> list;

        //    return list;
        //}

    }

    public class Node
    {
        string name;
        List<Edge> edges = new List<Edge>();
        Node previous;
        int weight = int.MaxValue;

        public string Name
        {
            get { return name; }
        }
        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
        public Node Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        public bool Visited { get; set; }

        public List<Edge> Edges
        {
            get { return edges; }
        }
        public IEnumerable<Node> GetNeighbours()
        {
            return edges.Select(ed => ed.Partners[0] == this ? ed.Partners[1] : ed.Partners[0]).ToList();
        }

        public Node(string name)
        {
            this.name = name;
        }
        public int GetWeightToPartner(Node partner)
        {
            return GetCorrespondingEdge(partner).Weight;
        }

        private Edge GetCorrespondingEdge(Node partner)
        {
            List<Edge> ret = Edges.Intersect(partner.Edges).ToList();
            return ret.Count == 0 ? null : ret[0];
        }

        private static Edge GetCorrespondingEdge(Node firstPartner, Node secPartner)
        {
            List<Edge> ret = firstPartner.Edges.Intersect(secPartner.Edges).ToList();
            return ret.Count == 0 ? null : ret[0];
        }
    }

    public class Edge
    {
        public int Weight { get; private set; }

        public Node[] Partners { get; private set; }

        private Edge(int val)
        {
            Weight = val;
            Partners = new Node[2];
        }

        public Edge(int val, Node st, Node end) : this(val)
        {
            Partners[0] = st;
            Partners[1] = end;
            st.Edges.Add(this);
            end.Edges.Add(this);
        }
    }
}
