using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ1___lista_mieszkańców
{
    public class PoprawnośćPESELU
    {
        public static bool CzyZawiera(string nowy_pesel, Dictionary<string, string> slownik)
        {
            foreach(var i in slownik)
            {
                if(i.Key == nowy_pesel)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ZgodnyNumerPESEL(string pesel)
        {
            if(pesel.Length!=11)
            {
                return false;
            }
            int[] sprawdzenie = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int iloczyn;
            int i = 9;
            int suma = 0;
            int l_kontrolna = int.Parse(pesel[10].ToString());
            while (i >= 0)
            {
                //Console.WriteLine("przerabiana cyfra peselu: " + int.Parse(l[i]));
                iloczyn = int.Parse(pesel[i].ToString()) * sprawdzenie[i];
                if (iloczyn >= 10)
                {
                    while (iloczyn >= 10)
                        iloczyn = iloczyn % 10;
                }
                //Console.WriteLine("wynik iloczynu wagi i cyfry peselu: " + iloczyn);
                suma = suma + iloczyn;
                //Console.WriteLine("obecna suma: " + suma);
                i--;
            }

            if (suma >= 10)
            {
                while (suma >= 10)
                    suma = suma % 10;
            }

            if ((10 - suma) == l_kontrolna)
                return true;
            else
                return false;
        }

        public static bool ZgodnaPłeć(string pesel, string imie)
        {
            int oznaczenie_płci = int.Parse(pesel[9].ToString());
            char litera = imie[imie.Length - 1];
            //Console.WriteLine("kod płci: " + oznaczenie_płci + " ostatnia litera imienia: " + litera);
            //zakładamy, że każde imię żeńskie kończy się na "a" i nie istnieje żadne imię męskie, które kończy się na "a"
            if ((oznaczenie_płci % 2 == 0 && litera != 'a') || (oznaczenie_płci % 2 != 0 && litera == 'a'))
                return false;
            else
                return true;
        }
    }
}
