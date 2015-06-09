using System.Collections.Generic;
using System.Linq;

namespace TheMapProject
{
    public class LeastStopRoute : Calculation
    {
        private Route _route = new Route();
        public override Route ResultRoute { get { return _route; } set { _route = value; } }

        private List<Route> _alternativeRoutes = new List<Route>();
        private List<City> _currentLevelQueue = new List<City>();
        private List<City> _nextLevelQueue = new List<City>();
        private List<City> _visitedCities = new List<City>();
        private City _currentCity;

        public override Route Calculate(City origin, City destination)
        {
            InitalList(origin);
            while (_nextLevelQueue.Count != 0 || _currentLevelQueue.Count != 0)
            {
                // if current level route is null start a next city in route
                // and set the next level route to current level route
                if (_currentLevelQueue.Count == 0)
                {
                    _currentLevelQueue.AddRange(_nextLevelQueue);
                    _nextLevelQueue.Clear();
                }
                _currentCity = _currentLevelQueue.First();

                //get all the neighbours of the current city
                var neighbours = GetNeighbours(_currentCity);
                //Get not appeared cities from the neighours
                neighbours = GetNotAppearedCities(neighbours);
                if (neighbours.Count != 0)
                {
                    // try to find if the neighbours include the destination
                    bool founddestination = FindDestination(destination, neighbours);
                    SetAlternativeRoute(_currentCity, neighbours);
                    if (founddestination == false)
                    {
                        // if not set all the not appeared cities to next city queue
                        // set not appeared cities to appeared cities
                        // add all alternative route
                        _nextLevelQueue.AddRange(neighbours);
                        _visitedCities.AddRange(neighbours);
                        //  NotAppearedCities.Clear();
                        _currentLevelQueue.Remove(_currentCity);
                    }
                    else
                    {
                        ResultRoute = GetRouteFrom(_alternativeRoutes, destination);
                        return ResultRoute;
                    }
                }
                else
                {
                    _currentLevelQueue.Remove(_currentCity);
                }
            }
            return null;
        }

        // initialize all list
        private void InitalList(City origin)
        {
            _currentCity = null;
            ResultRoute.Stations.Clear();
            _alternativeRoutes.Clear();
            _currentLevelQueue.Clear();
            _nextLevelQueue.Clear();
            _visitedCities.Clear();
            _visitedCities.Add(origin);
            _route.Stations.Add(origin);
            _nextLevelQueue.Add(origin);
            _alternativeRoutes.Add(new Route
            {
                Stations = new List<City>() { origin }
            });
        }
        // only look into the not appeared cities to check if you can find the destination or not
        private bool FindDestination(City destination, List<City> neighbors)
        {
            if (neighbors.Any(city => city.X == destination.X && city.Y == destination.Y))
            {
                return true;
            }
            return false;
            //neighbors.Contains(destination);
        }

        //get all the neighbours of the current city
        private List<City> GetNeighbours(City c)
        {
            return c.Connections.Select(con => con.City).ToList();
        }

        //get all the neighbours which is not appeared yet
        private List<City> GetNotAppearedCities(IEnumerable<City> neighbors)
        {
            List<City> newNeighbor = new List<City>(neighbors.Where(c => !_visitedCities.Contains(c)));
            return newNeighbor;
        }
        // find all the alternative route
        // if the alternative route is null, then just make a concrete between all not appeared cities with 
        // current city.
        // if the alternative route is not null, then make a concrete between the city in 'not appeared cities '
        // and the route which the last city equal to the currentCity
        private void SetAlternativeRoute(City currentCity, IEnumerable<City> notAppearedCities)
        {
            var routes = new List<Route>(_alternativeRoutes);
            foreach (City r in notAppearedCities)
            {
                foreach (Route newRoute in from rs in _alternativeRoutes
                                           select new Route { Stations = new List<City>(rs.Stations) }
                                               into newRoute
                                               let lastCity = newRoute.Stations.Last()
                                               where lastCity == currentCity
                                               select newRoute)
                {
                    newRoute.Stations.Add(r);
                    routes.Add(newRoute);
                }
            }
            _alternativeRoutes = routes;
        }
        private Route GetRouteFrom(IEnumerable<Route> alternativeRoute, City destination)
        {
            Route r = alternativeRoute.First(a => a.Stations.Last().X == destination.X && a.Stations.Last().Y == destination.Y);
            return r;
        }
    }
}
