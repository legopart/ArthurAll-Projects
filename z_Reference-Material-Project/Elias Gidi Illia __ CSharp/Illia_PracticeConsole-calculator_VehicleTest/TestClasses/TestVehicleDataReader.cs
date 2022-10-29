using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCalculator.Interfaces;

namespace VehicleTest.TestClasses
{
    class TestVehicleDataReader : IVehicleDataReader
    {
        public int GetMileage()
        {
            return 51;
        }
    }
}
