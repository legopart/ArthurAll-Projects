using NUnit.Framework;

namespace Exercise_03.Calculator
{
    [TestFixture]
    public class Tests
    {
        Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Test1_Empty()
        {
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test2_When_enter_a_number_3_then_result_is_3()
        {
            calc.Press("3");
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test3_When_enter_a_number_1_then_result_is_2()
        {
            calc.Press("1");
            string result = calc.GetDisplay();
            Assert.AreEqual("1", result);
        }
        [Test]
        public void Test4_When_enter_a_number_23_then_result_is_23()
        {
            calc.Press("2");
            calc.Press("3");
            string result = calc.GetDisplay();
            Assert.AreEqual("23", result);
        }
        [Test]
        public void Test5_When_enter_a_number_03_then_result_is_3()
        {
            calc.Press("0");
            calc.Press("3");
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test6_When_enter_a_number_00005_then_result_is_5()
        {
            calc.Press("0");
            calc.Press("0");
            calc.Press("0");
            calc.Press("0");
            calc.Press("5");
            string result = calc.GetDisplay();
            Assert.AreEqual("5", result);
        }
        [Test]
        public void Test7_When_enter_a_number_with_operation_sign_then_result_is_number()
        {
            calc.Press("3");
            calc.Press("+");            
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test8_When_enter_a_number_with_operation_sign_then_result_is_number()
        {
            calc.Press("3");
            calc.Press("/");
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test9_When_enter_add_operation_without_equals_then_result_is_last_number()
        {
            calc.Press("3");
            calc.Press("+");
            calc.Press("2");
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test10_When_enter_Reset_after_number_then_result_is_zero()
        {
            calc.Press("1");
            calc.Press("2");
            calc.Press("3");
            calc.Press("C");
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test11_When_enter_Reset_then_result_is_zero()
        {
            calc.Press("C");            
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test12_When_enter_add_operation_with_equals_then_result_is_last_number()
        {
            calc.Press("4");
            calc.Press("-");
            calc.Press("2");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test13_When_enter_a_math_example_then_result_is_solution()
        {
            calc.Press("5");
            calc.Press("+");
            calc.Press("1");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("6", result);
        }
        [Test]
        public void When_subtracting_a_bigger_number_then_result_is_negative()
        {
            calc.Press("3");
            calc.Press("-");
            calc.Press("5");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("-2", result);
        }
        [Test]
        public void Test15_When_enter_a_negative_then_result_is_absolute_value()
        {           
            calc.Press("-");
            calc.Press("2");            
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test16_Dividing_by_zero_then_result_is_an_error()
        {
            calc.Press("4");
            calc.Press("/");
            calc.Press("0");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("E", result);
        }
        [Test]
        public void Test17_When_multiplied_by_0_then_result_is_0()
        {
            calc.Press("3");
            calc.Press("*");
            calc.Press("0");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test18_When_dividing_then_result_is_an_integer()
        {
            calc.Press("13");
            calc.Press("/");
            calc.Press("5");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test19_When_enter_a_long_number_it_is_cleared_from_front()
        {
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            string result = calc.GetDisplay();
            Assert.AreEqual("11111", result);
        }
        [Test]
        public void Test20__When_enter_a_long_number_it_is_cleared_from_front()
        {
            calc.Press("1");
            calc.Press("2");
            calc.Press("3");
            calc.Press("4");
            calc.Press("5");
            calc.Press("6");
            string result = calc.GetDisplay();
            Assert.AreEqual("23456", result);
        }
        [Test]
        public void Test21_When_result_is_greater_than_9999_then_result_is_an_error()
        {
            calc.Press("9");
            calc.Press("9");
            calc.Press("9");
            calc.Press("9");
            calc.Press("+");
            calc.Press("1");
            calc.Press("0");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("E", result);
        }
        [Test]
        public void Test22__When_enter_a_math_example_then_result_is_solution()
        {
            calc.Press("3");
            calc.Press("+");
            calc.Press("4");
            calc.Press("*");
            calc.Press("8");            
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("56", result);
        }
        [Test]
        public void Test23_Result_of_entering_a_math_example_is_number_after_equals_sign()
        {
            calc.Press("1");
            calc.Press("+");
            calc.Press("3");
            calc.Press("=");
            calc.Press("5");            
            string result = calc.GetDisplay();
            Assert.AreEqual("5", result);
        }
        [Test]
        public void Test24_When_changing_operation_sign_then_last_is_used()
        {
            calc.Press("1");
            calc.Press("+");
            calc.Press("-");
            calc.Press("3");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("-2", result);
        }
        [Test]
        public void Test25_Result_of_entering_a_math_example_string_is_number_after_equals_sign()
        {
            calc.Press("1+3=5");            
            string result = calc.GetDisplay();
            Assert.AreEqual("5", result);
        }
        [Test]
        public void Test26_When_enter_a_string_then_result_is_a_string_of_5_last_char ()
        {
            calc.Press("DELETE TABLE FROM");
            string result = calc.GetDisplay();
            Assert.AreEqual(" FROM", result);
        }
        [Test]
        public void Test27_When_enter_a_char_the_result_is_a_char ()
        {
            calc.Press("D");
            string result = calc.GetDisplay();
            Assert.AreEqual("D", result);
        }
    }
}