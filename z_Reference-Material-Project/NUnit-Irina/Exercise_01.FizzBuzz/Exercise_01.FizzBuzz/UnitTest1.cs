using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]

    public class Tests
    {
        Fizzbuzz fizzbuzz;
        [SetUp]
        public void Setup()
        {
            fizzbuzz = new Fizzbuzz();
        }
        [Test]
        public void Test1_Number()
        {
            Assert.AreEqual("2", fizzbuzz.Output(2));
            Assert.AreEqual("11", fizzbuzz.Output(11));
            Assert.AreEqual("52", fizzbuzz.Output(52));
        }

        [Test]
        public void Test2_Fizz()
        {
            Assert.AreEqual("fizz", fizzbuzz.Output(9));
            Assert.AreEqual("fizz", fizzbuzz.Output(33));
            Assert.AreEqual("fizz", fizzbuzz.Output(54));
        }

        [Test]
        public void Test3_Buzz()
        {
            Assert.AreEqual("buzz", fizzbuzz.Output(5));
            Assert.AreEqual("buzz", fizzbuzz.Output(25));
            Assert.AreEqual("buzz", fizzbuzz.Output(55));

        }

        [Test]
        public void Test4_Fizzbuzz()
        {
            Assert.AreEqual("fizzbuzz", fizzbuzz.Output(15));
            Assert.AreEqual("fizzbuzz", fizzbuzz.Output(30));
            Assert.AreEqual("fizzbuzz", fizzbuzz.Output(45));
        }

        [Test]
        public void Test5_Fails()
        {
            Assert.AreNotEqual("3", fizzbuzz.Output(3));
            Assert.AreNotEqual("5", fizzbuzz.Output(5));
            Assert.AreNotEqual("15", fizzbuzz.Output(15));
            Assert.AreNotEqual("fizz", fizzbuzz.Output(25));
            Assert.AreNotEqual("fizz", fizzbuzz.Output(45));
            Assert.AreNotEqual("buzz", fizzbuzz.Output(33));
            Assert.AreNotEqual("buzz", fizzbuzz.Output(60));
            Assert.AreNotEqual("fizzbuzz", fizzbuzz.Output(12));
            Assert.AreNotEqual("fizzbuzz", fizzbuzz.Output(65));
        }
    }
}