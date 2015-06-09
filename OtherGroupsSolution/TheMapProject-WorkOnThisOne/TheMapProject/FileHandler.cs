using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TheMapProject
{
    public class FileHandler
    {
        private string FileName { get; set; }
         private string FilePhath { get; set; }

        //public int FormX { get; private set; }
        //public int FormY { get; private set; }

         public FileHandler(string filename)
         {
             FileName = filename;
             //this._filePhath = filepath;
         }

         public List<List<string>> LoadMap()
         {
             List<string> lines = new List<string>();

             List<List<string>> all = new List<List<string>>();

             List<string> connections = new List<string>();
             List<string> cities = new List<string>();
             List<string> dimentions = new List<string>();
             FileStream fs = null;
             StreamReader sr = null;

             try
             {
                 fs = new FileStream("../../" + FileName + ".txt", FileMode.Open, FileAccess.Read);
                 sr = new StreamReader(fs);

                 String s = sr.ReadLine(); ;

                 while (s != null)
                 {
                     lines.Add(s);
                     s = sr.ReadLine();
                 }
                 //Get coordinates and remove them from the list hence we don't use them an more
                 dimentions.Add(lines[0]);
                 dimentions.Add(lines[1]);

                 lines.RemoveRange(0, 2);

                 foreach (string st in lines)
                 {
                     if (st != "EINDE")
                     {
                         //string[] ssizes = st.Split(' ', '\t');
                         //City c = new City(ssizes[0], Convert.ToInt32(ssizes[1]), Convert.ToInt32(ssizes[2]));
                         cities.Add(st);
                     }
                     else break;
                 }
                 bool readflag = false;
                 foreach (string st in lines)
                 {
                     if (st == "EINDE")
                     {
                         readflag = true;
                     }
                     if (readflag == true && st != "END")
                     {
                         connections.Add(st);
                     }
                 }
             }
             catch (IOException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 if (sr != null) sr.Close();
                 if (fs != null) fs.Close();
             }
             Console.WriteLine("*************loading is done*********************");
             all.Add(dimentions);
             all.Add(cities);
             all.Add(connections);
             return all;
         }
    }
}
