using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class PersonDictionaryTests
    {
        [TestMethod]
        public void ContainsPesel()
        {
            Dictionary<string, string> TestInputLine = new Dictionary<string, string>();
            TestInputLine.Add("99092236192", "Kasia");
            TestInputLine.Add("81061048394", "Basia");
            TestInputLine.Add("93080463849", "Asia");
            TestInputLine.Add("46021855487", "Zosia");
            TestInputLine.Add("70042092714", "Kazimierz");

            List<string> TestPesel = new List<string>();
            TestPesel.Add("99092236192");
            TestPesel.Add("81061048394");
            TestPesel.Add("93080463849");
            TestPesel.Add("46021855487");
            TestPesel.Add("70042092714");

            foreach (string pesel in TestPesel)
            {
                bool result = TestInputLine.ContainsKey(pesel);
                Assert.AreEqual(true, result);
            }
        }
    }
}