using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_MapReduce
{
    public class Reducer
    {
        public Reducer()
        {
        }

        public List<KeyValuePair<int, int>> Zsumuj(List<KeyValuePair<int, int>> wejscie)
        {
            List<KeyValuePair<int, int>> wyjscie = new List<KeyValuePair<int, int>>();

            foreach (var item in wejscie)
            {
                int suma = 0;
                int czyzaw = 0;

                foreach (var item2 in wejscie)
                {

                    if (item.Key == item2.Key)
                    {
                        suma += item2.Value;

                    }

                }

                foreach (var czyzawiera in wyjscie)
                {
                    if (czyzawiera.Key == item.Key)
                    {
                        czyzaw = 1;
                    }
                }

                if (czyzaw == 0)
                {
                    KeyValuePair<int, int> itemik = new KeyValuePair<int, int>(item.Key, suma);
                    wyjscie.Add(itemik);
                }
            }

            foreach (var item in wyjscie)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }
            return wyjscie;
        }
    }
}
