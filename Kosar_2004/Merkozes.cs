using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosar_2004
{
    public class Merkozes
    {
        public string HazaiCsapat { get; set; }
        public string IdegenCsapat { get; set; }
        public int HazaiPont { get; set; }
        public int IdegenPont { get; set; }
        public string Helyszin { get; set; }
        public string Idopont { get; set; }

        public static List<Merkozes> beolvasas()
        {
            var sr = new StreamReader("../../eredmenyek.csv",Encoding.UTF8);
            sr.ReadLine();
            string[] temp;
            var outputlist = new List<Merkozes>();
            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine().Split(';');
                outputlist.Add(new Merkozes() { HazaiCsapat = temp[0], IdegenCsapat = temp[1], HazaiPont = int.Parse(temp[2]), IdegenPont = int.Parse(temp[3]), Helyszin = temp[4], Idopont = temp[5] });
            }

            sr.Close();

            return outputlist;

        }


    }
}
