using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PROJ1___lista_mieszkańców;

namespace PROJ1___testy
{
    [TestClass]
    public class SprawdzenieSłownika
    {
        [TestMethod]
        public void ZawieraPesel()
        {
            Dictionary<string, string> TestowyWierszDanych = new Dictionary<string, string>();
            TestowyWierszDanych.Add("99092236192", "Kasia");
            TestowyWierszDanych.Add("81061048394", "Basia");
            TestowyWierszDanych.Add("93080463849", "Asia");
            TestowyWierszDanych.Add("46021855487", "Zosia");
            TestowyWierszDanych.Add("70042092714", "Kazimierz");

            List<string> TestowePesele = new List<string>();
            TestowePesele.Add("99092236192");
            TestowePesele.Add("81061048394");
            TestowePesele.Add("93080463849");
            TestowePesele.Add("46021855487");
            TestowePesele.Add("70042092714");

            foreach (string x in TestowePesele)
            {
                PoprawnośćPESELU.CzyZawiera(x, TestowyWierszDanych);
                bool wynik = PoprawnośćPESELU.CzyZawiera(x, TestowyWierszDanych);
                Assert.AreEqual(true, wynik);
            }

        }
        [TestMethod]
        public void NieZawieraPeselu()
        {
            Dictionary<string, string> TestowyWierszDanych = new Dictionary<string, string>();
            TestowyWierszDanych.Add("99092236192", "Kasia");
            TestowyWierszDanych.Add("81061048394", "Basia");
            TestowyWierszDanych.Add("93080463849", "Asia");
            TestowyWierszDanych.Add("46021855487", "Zosia");
            TestowyWierszDanych.Add("70042092714", "Kazimierz");

            List<string> TestowePesele = new List<string>();
            TestowePesele.Add("19092236192");
            TestowePesele.Add("31061048394");
            TestowePesele.Add("43080463849");
            TestowePesele.Add("56021855487");
            TestowePesele.Add("60042092714");

            foreach (string x in TestowePesele)
            {
                PoprawnośćPESELU.CzyZawiera(x, TestowyWierszDanych);
                bool wynik = PoprawnośćPESELU.CzyZawiera(x, TestowyWierszDanych);
                Assert.AreEqual(false, wynik);
            }

        }
    }
}