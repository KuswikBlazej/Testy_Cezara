using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string wynik = Cezar.Program.Szyfr("abc", 3);

            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string wynik = Cezar.Program.Szyfr("xyz", 3);

            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string wynik = Cezar.Program.Szyfr("def", -3);

            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string wynik = Cezar.Program.Szyfr("abc", 29);

            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string wynik = Cezar.Program.Szyfr("ab cd", 2);

            Assert.AreEqual("cd ef", wynik);
        }
    }
}
