using System;
using System.Collections.Generic;
using System.Linq;

namespace TheMapProject
{
    public class RandomRoute : Calculation
    {
        private Route _route = new Route();
        public override Route ResultRoute { get { return _route; } set { _route = value; } }

        private Route _currentEveluateRoute = new Route();
        private List<Route> _alternativeRoutes = new List<Route>();
        private List<City> _visited = new List<City>();

        public override Route Calculate(City origin, City destination)
        {
            // initialize 
            Initialize(origin);

            while (_alternativeRoutes.Count!=0)
            {
                // get currentRoute randomly
                _currentEveluateRoute = GetRandomRoute(_alternativeRoutes);
                // get the last city of the currentRoute
                City lastCity = _currentEveluateRoute.Stations.Last();
                // get the neighbor of the city
                List<City> neighbors = lastCity.Connections.Select(con => con.City).ToList();
                // check the avalible city inside the neighbors (remove the parent city)
                var availableCities = GetAvailableCities(neighbors, _currentEveluateRoute);
                if (availableCities.Count != 0)
                {
                    // check if find the destination
                    bool foundDestination = findTheDestination(availableCities, destination);
                    // get all alternative route
                    SetAlternativeRoute(lastCity, availableCities);
                    if (foundDestination == false) continue;
                    // getRouteFrom alternative
                    ResultRoute = GetRouteFromAlternative(_alternativeRoutes, destination);
                    return ResultRoute;
                }
                _alternativeRoutes.Remove(_currentEveluateRoute);
            }
            return null;
        }

        private void Initialize(City origin)
        {
            ResultRoute.Stations.Clear();
            _alternativeRoutes.Clear();
            _currentEveluateRoute.Stations.Add(origin);
            _alternativeRoutes.Add(_currentEveluateRoute);
        }
        private Route GetRandomRoute(List<Route> alternativeRoute)
        {
            int max = alternativeRoute.Last().Stations.Count;
            var R = alternativeRoute.Where(r => r.Stations.Count == max).ToList();
            Random random = new Random();
            int number = random.Next(0, R.Count);
            Route returnRoute = R[number];
            return returnRoute;
        }
        private List<City> GetAvailableCities(IEnumerable<City> neighbors, Route currentRoute)
        {
            return neighbors.Where(c => !currentRoute.Stations.Contains(c)).ToList();
        }

        private bool findTheDestination(ICollection<City> availableCities, City destination)
        {
            if (availableCities.Any(city => city.X == destination.X && city.Y == destination.Y))
            {
                return true;
            }
            return false;
        }

        private void SetAlternativeRoute(City lastCity, IEnumerable<City> availableCities)
        {
            List<Route> routes = _alternativeRoutes.ToList();

            foreach (City r in availableCities)
            {
                foreach (Route rs in _alternativeRoutes)
                {
                    Route newRoute = new Route();
                    foreach (City c in rs.Stations)
                    {
                        newRoute.Stations.Add(c);
                    }
                    City _lastCity = newRoute.Stations.Last();
                    if (_lastCity != lastCity) continue;
                    newRoute.Stations.Add(r);
                    routes.Add(newRoute);
                }
            }

            _alternativeRoutes = routes;
        }
        private Route GetRouteFromAlternative(IEnumerable<Route> alternativeRoute, City destination)
        {
            return alternativeRoute.FirstOrDefault(a => a.Stations.Last().X == destination.X && a.Stations.Last().Y == destination.Y);
        }
    }
}
