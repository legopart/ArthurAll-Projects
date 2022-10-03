using System;
using System.Reflection;

using UsefulLib;
using NVI;

namespace UsefulLib
{                  
    public class Base
    {
        public virtual void SomeMethods()
        {
            SomeMethod1();
            SomeMethod2();
        }
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
        //new method
        public new void SomeMethod1() { Console.WriteLine("3 New Derive.SomeMethod1()"); }
        public sealed override void SomeMethod2() { Console.WriteLine("4 Sealed Override Derive.SomeMethod2()"); }

    }


    public class Derive2 : Base
    {
        //new method
        public override void SomeMethods()
        {

            SomeMethod1(); //this.SomeMethod1() !
            SomeMethod2(); //this.SomeMethod2() !
        }
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
            Console.WriteLine("Sealed 1:");
            Base instance = new Derive();
            instance.SomeMethod1();
            instance.SomeMethod2(); //override
            Console.WriteLine();
            //  instance.SomeMethods();

            // Console.WriteLine("Sealed Derive:");
            // Derive instance2 = new Derive();
            // ((Derive)instance2).SomeMethod1();
            // ((Derive)instance2).SomeMethod2();


            Console.WriteLine("Sealed 2:");
            Base instance2 = new Derive2();

            Console.WriteLine("Sealed 2: Some Methods");
            instance2.SomeMethods(); //3 4  because of this. calls
            Console.WriteLine();

            Console.WriteLine("Sealed 2: Method1 Method2");
            instance2.SomeMethod1(); // 1
            instance2.SomeMethod2(); //4
            Console.WriteLine();


        }
    }
}