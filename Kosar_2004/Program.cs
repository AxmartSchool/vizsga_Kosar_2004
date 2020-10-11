using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kosar_2004
{
    class Program
    {

        public static List<Merkozes> Merkozesek; 

        static void Main(string[] args)
        {
            Merkozesek = Merkozes.beolvasas();

            harmadikFeladat();
            negyedikFeladat();
            otodikFeladat();
            hatodikFeladat();

            Console.ReadKey();

        }

        private static void hatodikFeladat()
        {
            Console.WriteLine("6. feladat: ");
            foreach (var meccs in Merkozesek)
            {

                if (meccs.Idopont.Equals("2004-11-21"))
                {
                    Console.WriteLine($"\t{meccs.HazaiCsapat}-{meccs.IdegenCsapat} ({meccs.HazaiPont}:{meccs.IdegenPont})");


                }

            }

            //LINQ megoldas
            //Merkozesek.FindAll(x => x.Idopont.Equals("2004-11-21")).ForEach(x => Console.WriteLine($"\t{x.HazaiCsapat}-{x.IdegenCsapat} ({x.HazaiPont}:{x.IdegenPont})"));
            


        }

        private static void otodikFeladat()
        {
            int szamlalo = 0;

            while(!Merkozesek[szamlalo].HazaiCsapat.Contains("Barcelona") && szamlalo < Merkozesek.Count)
            {
                szamlalo++;
            }

            //LINQ megoldas
            //var csapatnev = Merkozesek.First(x => x.HazaiCsapat.Contains("Barcelona")).HazaiCsapat;
            //Console.WriteLine($"5. feladat: barcelonai csapat neve: {csapatnev}");

            Console.WriteLine($"5. feladat: barcelonai csapat neve: {Merkozesek[szamlalo].HazaiCsapat}");

        }

        private static void negyedikFeladat()
        {

            bool dontetlen = false;
            int szamlalo = 0;

            while(!dontetlen && szamlalo < Merkozesek.Count)
            {

                if (Merkozesek[szamlalo].HazaiPont == Merkozesek[szamlalo].IdegenPont)
                {
                    dontetlen = true;

                }
                else
                {
                    szamlalo++;
                }

            }

            // LINQ megoldas
            //dontetlen =  Merkozesek.Count(x => x.HazaiPont == x.IdegenPont)==0?false:true;

            Console.WriteLine($"4. feladat : Volt dontetlen? {(dontetlen?"igen":"nem")}");

            
        }

        private static void harmadikFeladat()
        {

            int hazaiMeccsekSzama = 0;
            int idegenMeccsekSzama = 0;

            foreach (var meccs in Merkozesek)
            {
               

                if (meccs.HazaiCsapat.Equals("Real Madrid"))
                {
                    hazaiMeccsekSzama++;
                }
                else if (meccs.IdegenCsapat.Equals("Real Madrid"))
                {
                    idegenMeccsekSzama++;
                }   

        

            }
            
            //LINQ megoldas
            //hazaiMeccsekSzama = Merkozesek.Count(x => x.HazaiCsapat == "Real Madrid");
            //idegenMeccsekSzama = Merkozesek.Count(x => x.IdegenCsapat == "Real Madrid");

            Console.WriteLine($"3. feladat : Real Madrid: Hazai {hazaiMeccsekSzama}, Idegen {idegenMeccsekSzama}");


        }
    }
}
