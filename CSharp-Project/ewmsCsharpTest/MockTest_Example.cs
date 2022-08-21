using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Classes;
using ewmsCsharp.Interfaces;
using ewmsCsharpTest.testClasses;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace ewmsCsharpTest
{
    [TestClass]
    public class MockTest_Example
    {
        [TestMethod]
        public void MoqExam()
        {

            Data data = new Data("1111", "item111");
            // IData _data  בראש המחלקה
            // השאר מוגדר בקונסטרקטור

            Mock<IData> x = new Mock<IData>();
            x.Setup(x => x.Name).Returns("Arthur");
            IData _data = x.Object;

            DataTest dataTest = new DataTest(); // dataTest.Name = "John"

            Assert.AreEqual(dataTest.Name, "John");
            Assert.AreEqual(_data.Name, "Arthur");
        }
    }
}
