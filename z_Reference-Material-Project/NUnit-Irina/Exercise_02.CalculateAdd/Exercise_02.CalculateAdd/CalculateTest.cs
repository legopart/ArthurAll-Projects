using NUnit.Framework;

namespace Exercise_02.CalculateAdd
{
    public class Tests
    {        
        [Test]
        public void Test1()
        {
            Calculate calc = new Calculate();
            Assert.AreEqual(5, calc.CalculateAddFour(1));
        }
        [Test]
        public void Test2()
        {
            Calculate calc = new Calculate();
            Assert.AreEqual(12, calc.CalculateAddFour(8));
        }
        [Test]
        public void Test3()
        {
            Calculate calc = new Calculate();
            Assert.AreEqual(0, calc.CalculateAddFour(-4));
        }
        [Test]
        public void Test4()
        {
            Calculate calc = new Calculate();
            Assert.AreEqual(5, calc.CalculateAddFive(0));
        }
        [Test]
        public void Test5()
        {
            Calculate calc = new Calculate();
            Assert.AreEqual(8, calc.CalculateAddFive(3));
        }
        [Test]
        public void Test6()
        {
            Calculate calc = new Calculate();
            Assert.AreEqual(0, calc.CalculateAddFive(-5));
        }
    }
}