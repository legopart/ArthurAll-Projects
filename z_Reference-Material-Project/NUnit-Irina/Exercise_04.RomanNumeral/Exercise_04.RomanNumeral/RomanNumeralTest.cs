using NUnit.Framework;

namespace Exercise_04.RomanNumeral
{
    [TestFixture]
    public class Tests
    {
        RomanNumeral rn;
        RomanNumeral an;

        [SetUp]
        public void Setup()
        {
            rn = new RomanNumeral();
            an = new RomanNumeral();
        }

        [Test]
        public void Test1_ArabicToRoman_Zero()
        {
            Assert.AreEqual("", rn.ArabicToRoman(0));
        }
        [Test]
        public void Test2_ArabicToRoman_regular_numbers()
        {
            Assert.AreEqual("I", rn.ArabicToRoman(1));
            Assert.AreEqual("III", rn.ArabicToRoman(3));
            Assert.AreEqual("V", rn.ArabicToRoman(5));
            Assert.AreEqual("X", rn.ArabicToRoman(10));
            Assert.AreEqual("XXXVIII", rn.ArabicToRoman(38));
            Assert.AreEqual("LI", rn.ArabicToRoman(51));
            Assert.AreEqual("DLV", rn.ArabicToRoman(555));
        }
        [Test]
        public void Test3_ArabicToRoman_numbers_with_4_6_9_40_90_400_900()
        {
            Assert.AreEqual("IV", rn.ArabicToRoman(4));
            Assert.AreEqual("VI", rn.ArabicToRoman(6));
            Assert.AreEqual("IX", rn.ArabicToRoman(9));
            Assert.AreEqual("XXIV", rn.ArabicToRoman(24));
            Assert.AreEqual("XLII", rn.ArabicToRoman(42));
            Assert.AreEqual("XCV", rn.ArabicToRoman(95));
            Assert.AreEqual("CIV", rn.ArabicToRoman(104));
            Assert.AreEqual("CDXIX", rn.ArabicToRoman(419));
            Assert.AreEqual("CMLXXXVI", rn.ArabicToRoman(986));
            Assert.AreEqual("MCDXCIX", rn.ArabicToRoman(1499));
            Assert.AreEqual("MMCCXIX", rn.ArabicToRoman(2219));   
        }
        [Test]
        public void Test4_ArabicToRoman_then_fail_result()
        {
            Assert.AreNotEqual("MMXVIII", rn.ArabicToRoman(2017));
        }

        [Test]
        public void Test1_RomanToArabic_Empty()
        {
            Assert.AreEqual(0, an.RomanToArabic(""));
        }
        [Test]
        public void Test2_RomanToArabic_regular_numbers()
        {
            Assert.AreEqual(1, an.RomanToArabic("I"));
            Assert.AreEqual(3806, an.RomanToArabic("MMMDCCCVI"));
        }
        [Test]
        public void Test3_RomanToArabic_numbers_with_4_9_40_90_400()
        {
            Assert.AreEqual(9, an.RomanToArabic("IX"));
            Assert.AreEqual(94, an.RomanToArabic("XCIV"));
            Assert.AreEqual(943, an.RomanToArabic("CMXLIII"));
            Assert.AreEqual(1499, an.RomanToArabic("MCDXCIX"));
        }
        [Test]
        public void Test4_RomanToArabic__then_fail_result()
        {
            Assert.AreNotEqual(3806, an.RomanToArabic("MMMDCCCIV"));
        }
    }
}