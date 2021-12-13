using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ1___lista_mieszkańców
{
    public class OperacjeNaPliku
    {
        public static void zamiana(Dictionary<string, string> slownik, string klucz, string nowe_dane)
        {
            slownik.Remove(klucz);
            slownik.Add(klucz, nowe_dane);
        }

        public static void zapis(Dictionary<string, string> slownik)
        {
            using (FileStream fs = new FileStream(@"listaMieszkańców.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                foreach (var x in slownik)
                {
                    sw.WriteLine("{0} {1}", x.Key, x.Value);
                    sw.Flush();
                }
            }
        }
    }
}
