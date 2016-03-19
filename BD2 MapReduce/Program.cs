using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_MapReduce
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Mapper mapper = new Mapper();
            Reducer reducer = new Reducer();

            List<KeyValuePair<int, int>> wynik = mapper.PomnozMacierz();

            //System.Console.WriteLine(wynik);

            List<KeyValuePair<int, int>> wynik_reducera = reducer.Zsumuj(wynik);

<<<<<<< HEAD
            Console.WriteLine("okeyzmieniono5959");
=======
            Console.WriteLine("okeybbbb");
>>>>>>> parent of 12e855d... Zmieniono
            //System.Console.WriteLine(wynik_reducera);
            System.Console.ReadLine();
        }
    }
    
}
