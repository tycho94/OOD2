﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TheMapProject
{
    public class DijkstraRoute : Calculation
    {
        Map _m;
        private Route _route = new Route();
        public override Route ResultRoute { get { return _route; } set { _route = value; } }
        private List<Route> _alternativeRoutes = new List<Route>();
        List<Node> _graph;


        public override Route Calculate(City origin, City destination)
        {
            List<Node> node;
            List<City> Cities = new List<City>();
            Cities = _m.Cities;

            Node y = _graph.Find(x => x.Name == origin.Name);
            Node xl = _graph.Find(x => x.Name == destination.Name);
            node = FindShortestPathFromStartToFinish(y, xl);
          
            
            Route newRoute = new Route();
            foreach (City ycit in node.Select(n => Cities.Find(x => x.Name == n.Name)))
            {
                newRoute.Stations.Add(ycit);
            }
            return newRoute;
        }


        public DijkstraRoute(Map _mm)
        {
            List<City> Cities = new List<City>();
            Cities = _mm.Cities;
            _m = _mm;
            List<Node> node = Cities.Select(cit => new Node(cit.Name)).ToList();

            //Add every city to NODE
            foreach (City city in Cities)
            {
                Node m = node.Find(x => x.Name == city.Name);
                var con = city.GetConnections();

                //Add connections for the given city
                for (int i = 0; i <= city.Connections.Count - 1; i++)
                {
                    Node n = node.Find(x => x.Name == con.ElementAt(i).City.Name);
                    int distance = Convert.ToInt32(con.ElementAt(i).Length);
                    Edge edge = new Edge(distance, m, n);
                }
            }

            _graph = node;
        }
        private List<Node> ShortestPathMapFromStart(Node start)
        {
            start.Val = 0;
            start.Pre = start;

            while (GetUnvisited().Count != 0)
            {
                Node current = GetFirstUnvisitedNodeSortedByVal();
                current.Visited = true;

                List<Node> unvisitedNeighBours = current.GetNeighbours().Where(x => !x.Visited).ToList();
                foreach (Node unvisitedNode in unvisitedNeighBours)
                {
                    int sum = current.Val + current.GetKantenGewichtToPartner(unvisitedNode);
                    if (sum < unvisitedNode.Val)
                    {
                        unvisitedNode.Val = sum;
                        unvisitedNode.Pre = current;
                    }
                }
            }

            return GetVisited();
        }

        private List<Node> FindShortestPathFromStartToFinish(Node start, Node end)
        {
            ShortestPathMapFromStart(start);

            List<Node> path = new List<Node>();
            Node current = end;
            while (current != start)
            {
                path.Add(current);
                current = current.Pre;
            }

            path.Add(current);
            path.Reverse();

            return path;
        }
        private Node GetFirstUnvisitedNodeSortedByVal()
        {
            return GetUnvisitedSortByVal()[0];
        }
        private List<Node> GetUnvisitedSortByVal()
        {
            return _graph.Where(x => !x.Visited).OrderBy(x => x.Val).ToList();
        }
        private List<Node> GetUnvisited()
        {
            return _graph.Where(x => x.Visited == false).ToList();
        }
        private List<Node> GetVisited()
        {
            return _graph.Where(x => x.Visited).OrderBy(x => x.Name).ToList();
        }
    }
    public class Node
    {
        string _name;
        List<Edge> _edges = new List<Edge>();
        Node _pre;
        int _val = int.MaxValue;

        public string Name
        {
            get { return _name; }
        }
        public int Val
        {
            get { return _val; }
            set { _val = value; }
        }
        public Node Pre
        {
            get { return _pre; }
            set { _pre = value; }
        }

        public bool Visited { get; set; }

        public List<Edge> Edges
        {
            get { return _edges; }
        }
        public IEnumerable<Node> GetNeighbours()
        {
            return _edges.Select(ed => ed.Partners[0] == this ? ed.Partners[1] : ed.Partners[0]).ToList();
        }

        public Node(string name)
        {
            _name = name;
        }
        public int GetKantenGewichtToPartner(Node partner)
        {
            return GetCorrespondingEdge(partner).Value;
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
        public int Value { get; private set; }

        public Node[] Partners { get; private set; }

        private Edge(int value)
        {
            Value = value;
            Partners = new Node[2];
        }
        public Edge(int value, Node start, Node end)
            : this(value)
        {
            MakeConnection(start, end);
        }

        private void MakeConnection(Node start, Node end)
        {
            Partners[0] = start;
            Partners[1] = end;

            start.Edges.Add(this);
            end.Edges.Add(this);


        }
    }
}

