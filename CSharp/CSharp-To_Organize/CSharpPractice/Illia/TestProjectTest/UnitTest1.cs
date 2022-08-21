using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestPreppering;
namespace TestProjectTest
{
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void NextNumber1()
        {
            string str = "123";
            // Actoal
            string actual = NextNumber.GetNextNumber(str);

            //Expected
            string expected = "124";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void NextNumber_PromotionBy1_LastNumberIs9()
        {
            string str = "129";
            // Actoal
            string actual = NextNumber.GetNextNumber(str);

            //Expected
            string expected = "130";

            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void NextNumber_PromotionBy1_LastNumberIs19999999999999()
        {
            string str = "19999999999";
            // Actoal
            string actual = NextNumber.GetNextNumber(str);

            //Expected
            string expected = "20000000000";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void NextNumber_PromotionBy1_LastNumberIs9999999999999()
        {
            string str = "9999999999";
            // Actoal
            string actual = NextNumber.GetNextNumber(str);

            //Expected
            string expected = "0000000000";

            Assert.AreEqual(actual, expected);
        }




        [TestMethod]
        public void testPrimeUp100()
        {

            // Actoal
            string actual = Prime.PrimeNumbers(100);

            //Expected
            string expected = "2\n2\n5\n5\n";

            Assert.AreEqual(actual, expected);
        }
    }
}