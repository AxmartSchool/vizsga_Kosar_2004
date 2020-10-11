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

            Console.ReadKey();

        }

        private static void otodikFeladat()
        {
            throw new NotImplementedException();
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
