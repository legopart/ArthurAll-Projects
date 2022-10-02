using System;
using System.Reflection;

using UsefulLib;
using NVI;

namespace UsefulLib
{                  
    public class Base
    {
        public virtual void SomeMethod1()
        {
            Console.WriteLine("Base.1 SomeMethod1()");
        }
        public virtual void SomeMethod2()
        {
            Console.WriteLine("Base.2 SomeMethod2()");
        }
    }
}

namespace NVI   //client implementation version:
{   //no changes on client side !
    public class Derive : Base
    {
        public new void SomeMethod1() { Console.WriteLine("3 New Derive.SomeMethod1()"); }
        public sealed override void SomeMethod2() { Console.WriteLine("4 Sealed Override Derive.SomeMethod2()"); }

    }
}

namespace Versions
{
    public class Versions
    {
        public static void Main()
        {
            Console.WriteLine("Sealed:");
            Base instance = new Derive();
            instance.SomeMethod1();
            instance.SomeMethod2();
        }
    }
}