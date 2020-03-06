using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BogLib;

namespace BogTest
{
    [TestClass]
    public class UnitTest1
    {
        private Bog _bog;

        [TestInitialize]
        public void Init()
        {
            _bog = new Bog();
        }

        [TestMethod]
        public void TestTitel()
        {
            _bog.Titel = "MoonMoon";

            Assert.AreEqual("MoonMoon", _bog.Titel);
        }

        [TestMethod]
        public void TestSidetal()
        {
            _bog.Sidetal = 420;

            Assert.AreEqual(420, _bog.Sidetal);
        }

        [TestMethod]
        public void TestForfatter()
        {
            _bog.Forfatter = "WolfWatcher";

            Assert.AreEqual("WolfWatcher", _bog.Forfatter);
        }

        [TestMethod]
        public void TestIsbn13()
        {
            _bog.Isbn13 = "123456789abcd";

            Assert.AreEqual("123456789abcd", _bog.Isbn13);
        }

        [TestMethod]
        public void TestTostring()
        {
            _bog.Titel = "MoonMoon";
            _bog.Sidetal = 420;
            _bog.Forfatter = "WolfWatcher";
            _bog.Isbn13 = "123456789abcd";

            Assert.AreEqual("Titel:MoonMoon Forfatter:WolfWatcher Sidetal:420 Isbn13:123456789abcd", _bog.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestForfatterIllegal()
        {
            _bog.Forfatter = "0";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestForfatterIllegal2()
        {
            _bog.Forfatter = "0 ";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSidetalIllegal()
        {
            _bog.Sidetal = 2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSidetalIllegal2()
        {
            _bog.Sidetal = 1001;
        }

        [TestMethod]
        public void TestSidetal2()
        {
            _bog.Sidetal = 4;
        }

        [TestMethod]
        public void TestSidetal3()
        {
            _bog.Sidetal = 1000;
        }
    }
}
