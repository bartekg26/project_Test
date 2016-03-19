using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_MapReduce
{
    public class Mapper
    {
        public Mapper()
        {
        }

        public List<KeyValuePair<int, int>> PomnozMacierz()
        {

            string[] linie = System.IO.File.ReadAllLines("macierz.txt");
            string[] linie_wektor = System.IO.File.ReadAllLines("Wektor.txt");

            List<KeyValuePair<int, int>> lista_wyjsciowa = new List<KeyValuePair<int, int>>();

            if (linie.Length != linie_wektor.Length)
            {
                foreach (string linia in linie)
                {
                    //Console.WriteLine(linia);
                    string[] elementy_macierzy = linia.Split(',');

                    int i = Int32.Parse(elementy_macierzy[0]);
                    int j = Int32.Parse(elementy_macierzy[1]);
                    int m = Int32.Parse(elementy_macierzy[2]);

                    int wynik = m * Int32.Parse(linie_wektor[j]);
                    KeyValuePair<int, int> kv = new KeyValuePair<int, int>(i, wynik);
                    lista_wyjsciowa.Add(kv);
                    //	System.Console.WriteLine("i:"+i+" j:"+j+" m:"+m+" wynik:"+wynik);
                }
            }

            return lista_wyjsciowa;
        }
    }
}
