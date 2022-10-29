using ConsoleCalculator.Classes;
using ConsoleCalculator.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VehicleTest.TestClasses;

namespace VehicleTest
{
    [TestClass]
    public class VehicleTest
    {
        IVehicleDataReader _reader;

        public VehicleTest()
        {
            var x = new Mock<IVehicleDataReader>();
            x.Setup(mockReader => mockReader.GetMileage()).Returns(50);
            _reader = x.Object;
        }

        [TestMethod]
        public void CanMoveForward()
        {
            //Vehicle vehicle = new Vehicle(_reader);
            Vehicle vehicle = new Vehicle(new TestVehicleDataReader());
            vehicle.MoveForward();
            Assert.AreEqual(52, vehicle.Mileage);
        }

        [TestMethod]
        public void CanOutputCorrectToString()
        {
            string color = "red";
            string year = "2000";
            Vehicle vehicle = new Vehicle(_reader, color, year);
            Assert.AreEqual($"Year: {year}, Color: {color.ToUpper()}", vehicle.ToString());
        }
    }
}
