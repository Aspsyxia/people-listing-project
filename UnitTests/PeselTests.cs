using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PeopleListing;

namespace UnitTests
{
    [TestClass]
    public class PeselTests
    {
        [TestMethod]
        public void PeselIsCorrect()
        {
            Dictionary<string, string> TestInputLine = new Dictionary<string, string>();
            TestInputLine.Add("55022768982", "Kasia");
            TestInputLine.Add("98080399835", "Jacek");
            TestInputLine.Add("55072683523", "Asia");
            TestInputLine.Add("74013027422", "Zosia");
            TestInputLine.Add("52092773832", "Kazimierz");

            foreach (var inputEntry in TestInputLine)
            {
                bool result = CheckPESEL.ValidCheck(inputEntry.Key) && CheckPESEL.CorrectSex(inputEntry.Key, inputEntry.Value);
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void PeselIsIncorrect()
        {
            Dictionary<string, string> TestInputLine = new Dictionary<string, string>();
            TestInputLine.Add("55022768982", "Jacek");
            TestInputLine.Add("98080399835", "Kasia");
            TestInputLine.Add("5507268 ", "Asia");
            TestInputLine.Add("74013027422d", "Zosia");
            TestInputLine.Add("520927738312", "Kazimierz");

            foreach (var inputEntry in TestInputLine)
            {
                bool result = CheckPESEL.ValidCheck(inputEntry.Key) && CheckPESEL.CorrectSex(inputEntry.Key, inputEntry.Value);
                Assert.AreEqual(false, result);
            }
        }
    }
}
