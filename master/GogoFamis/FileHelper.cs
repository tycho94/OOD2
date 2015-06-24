using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace GogoFamis
{
    class FileHelper
    {
        private string location;
        

        public FileHelper(string location)
        { 
            this.location = location; 
        }

        /// <summary>
        /// loads location from a file
        /// </summary>
        /// <param name="size">size of map x</param>
        /// <returns>returns a list of locations</returns>
        public List<Location> LoadLocation(out Point size)
        {
            List<Location> temp = new List<Location>();
            string line;
            string[] parameters;
            size = new Point();

            using (StreamReader sr = new StreamReader(location))
            {
                size.X = Convert.ToInt32(sr.ReadLine()) + 50;
                size.Y = Convert.ToInt32(sr.ReadLine()) + 50;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "EINDE")
                    {
                        break;
                    }
                    parameters = line.Split(' ');
                    temp.Add(new Location(parameters[0], new Point(Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]))));
                }
            }

            /*}
            catch (Exception e)
            {
                Console.WriteLine("Error reading file");
                Console.WriteLine(e.Message);
                size.X = 0;
                size.Y = 0;
                temp = null;
            }*/
            return temp;
        }

        /// <summary>
        /// reads from a file to create a list of connections
        /// </summary>
        /// <param name="loclist">here you must use the locationlist as parameter</param>
        /// <returns>a list of connections</returns>
        public List<Connection> LoadConnection(List<Location> loclist)
        {
            List<Connection> temp = new List<Connection>();
            string line;
            string[] parameters;
            Location a = null, b = null;
            try
            {
                using (StreamReader sr = new StreamReader(location))
                {
                    while ((line = sr.ReadLine()) != "EINDE")
                    {
                    }
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "EINDE")
                        {
                            break;
                        }
                        parameters = line.Split(' ');
                        for (int i = 1; i < parameters.Length; i += 2)
                        {
                            foreach (Location l in loclist)
                            {
                                if (l.Name == parameters[0])
                                {
                                    a = l;
                                }

                                if (l.Name == parameters[i])
                                {
                                    b = l;
                                }
                            }
                            temp.Add(new Connection(a, b, Convert.ToInt32(parameters[i + 1])));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file");
                Console.WriteLine(e.Message);
                temp = null;
            }
            return temp;
        }

        ////private void CheckLocationOverlap();

    }
}
