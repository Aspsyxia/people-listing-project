using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PROJ1___lista_mieszkańców;

namespace PROJ1___testy
{
    [TestClass]
    public class SprawdzaniePeselu_TEST
    {
        [TestMethod]
        public void PoprawnePesele()
        {
            List<string> PeseleDoTestu = new List<string>();
            PeseleDoTestu.Add("64080503657");
            PeseleDoTestu.Add("79042689942");
            PeseleDoTestu.Add("64021675698");
            PeseleDoTestu.Add("00290497212");
            PeseleDoTestu.Add("04272688232");

            foreach (var x in PeseleDoTestu)
            {
                PoprawnośćPESELU.ZgodnyNumerPESEL(x);
                bool pesel = PoprawnośćPESELU.ZgodnyNumerPESEL(x);
                Assert.AreEqual(true, pesel);
            }
        }

        [TestMethod]
        public void NiepoprawnePesele()
        {
            List<string> PeseleDoTestu = new List<string>();
            PeseleDoTestu.Add("640107");
            PeseleDoTestu.Add("790411689342");
            PeseleDoTestu.Add("6402126435698");
            PeseleDoTestu.Add("70010533732");
            PeseleDoTestu.Add("04272`2388232");

            foreach (var x in PeseleDoTestu)
            {
                PoprawnośćPESELU.ZgodnyNumerPESEL(x);
                bool pesel = PoprawnośćPESELU.ZgodnyNumerPESEL(x);
                Assert.AreEqual(false, pesel);
            }
        }
    }
}
