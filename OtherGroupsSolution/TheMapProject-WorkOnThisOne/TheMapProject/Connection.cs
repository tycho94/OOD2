namespace TheMapProject
{
    public class Connection
    {
        public readonly City City;
        public readonly int Length;

        public Connection(City city, int lenght)
        {
            City = city;
            Length = lenght;
        }

        public override string ToString()
        {
            string s = "Connected to city: " + City.Name + " Length : " + Length;
            return s;
        }
    }
}
