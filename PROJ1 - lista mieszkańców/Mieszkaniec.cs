using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ1___lista_mieszkańców
{
    class Mieszkaniec
    {
        public string miasto;
        public string imie;
        public string nazwisko;
        public string PESEL;
        

        public Mieszkaniec(string miastoMieszkanca, string imieMieszkanca, string nazwiskoMieszkanca, string PESELMieszkanca)
        {
            miasto = miastoMieszkanca;
            imie = imieMieszkanca;
            nazwisko = nazwiskoMieszkanca;
            PESEL = PESELMieszkanca;
        }
    }
}
