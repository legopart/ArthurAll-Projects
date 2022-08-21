using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Interfaces;

namespace ewmsCsharpTest.testClasses
{
    public class DataTest : IData
    {
        //public DataTest() {}

        public object Id => throw new NotImplementedException();

        public string Name { get; set; } = "John";
        //
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
        
    }
}
