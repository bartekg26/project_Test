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
            dffdfdfd

<<<<<<< HEAD
            Console.WriteLine("okeyzmieniono1218888");
<<<<<<< HEAD
            Console.WriteLine("okeyzmieniono1212");
            Console.WriteLine("okeybbbb");
            Console.WriteLine("okeyzmieniono");


            Console.WriteLine("okeyzmieniono1218888");
            Console.WriteLine("master nie dzialal");
=======
=======

            Console.WriteLine("okeyzmieniono1212");
>>>>>>> parent of b839601... komit2

>>>>>>> parent of 1fde67c... prawidłowy do master
            Console.WriteLine("okeybbbb");

<<<<<<< HEAD

            

=======
<<<<<<< HEAD
=======
            Console.WriteLine("okeyzmieniono");
>>>>>>> parent of 591f99e... cdscdc
>>>>>>> parent of 1fde67c... prawidłowy do master
            //System.Console.WriteLine(wynik_reducera);
            System.Console.ReadLine();
        }
    }
    
}
