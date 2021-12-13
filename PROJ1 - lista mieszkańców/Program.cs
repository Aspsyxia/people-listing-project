using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ1___lista_mieszkańców
{
    class Program
    {

        public static Dictionary<string, string> wierszDanych = new Dictionary<string, string>();
  
        static void Main(string[] args)
        {
            OperacjeNaPliku.zapis(wierszDanych);
            while (true)
            { 
                Mieszkaniec nowy = new Mieszkaniec(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                string dane = ("| " + nowy.miasto + " | " + nowy.imie + " | " + nowy.nazwisko);

                if (PoprawnośćPESELU.ZgodnyNumerPESEL(nowy.PESEL) && !PoprawnośćPESELU.CzyZawiera(nowy.PESEL, wierszDanych))
                {
                    if (!PoprawnośćPESELU.ZgodnaPłeć(nowy.PESEL, nowy.imie))
                    {
                        Console.WriteLine("Podany PESEL nie zgadza się z danymi osoby (inna płeć), proszę spróbować jeszcze raz");
                        continue;
                    }
                    else
                    {
                        wierszDanych.Add(nowy.PESEL, dane);
                        OperacjeNaPliku.zapis(wierszDanych);
                    }
                }
                else if (PoprawnośćPESELU.CzyZawiera(nowy.PESEL, wierszDanych))
                {
                    if (!PoprawnośćPESELU.ZgodnaPłeć(nowy.PESEL, nowy.imie))
                    {
                        Console.WriteLine("Podany PESEL nie zgadza się z danymi osoby (inna płeć), proszę spróbować jeszcze raz");
                        continue;
                    }
                    else
                    {
                        OperacjeNaPliku.zamiana(wierszDanych, nowy.PESEL, dane);
                        OperacjeNaPliku.zapis(wierszDanych);
                    }
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłowy numer PESEL (niezgodność sumy kontrolnej lub za krótki), proszę spróbować jeszcze raz");
                    continue;
                }
                //testowe wypisywanie zawartosci slownika
                //foreach(var x in wierszDanych)
                //{
                    //Console.WriteLine("{0} {1}", x.Key, x.Value);
                //}
            }
        }
}
}
