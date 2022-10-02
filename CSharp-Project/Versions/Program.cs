using System;
using System.Reflection;

using UsefulLib;
using NVI;

namespace UsefulLib
{
    public class Base // Template Pattern, only base class will affected
    {
        public void DoWork() 
        {
            Console.WriteLine("Base.DoWork()");
      /*!*/ CoreDoWork();   //called the Virtal method!
            PreDoWork();
        }

        private void PreDoWork() { Console.WriteLine("Base.PreDoWork()"); }

        protected virtual void CoreDoWork() { Console.WriteLine("Base.CoreDoWork()"); }
    }

}


namespace NVI   //client implementation version:
{   //no changes on client side !
    public class Derive : Base
    {
        protected override void CoreDoWork() { Console.WriteLine("Derive.CoreDoWork()"); }

    }
}

namespace Versions
{
    public class Versions
    {
        public static void Main()
        {
            Console.WriteLine("Versions:");
            Base instance = new Derive();
            instance.DoWork();


        }

    }

}