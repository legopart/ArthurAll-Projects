using System;
using System.Reflection;


public class Class1 { public void Method() { Console.WriteLine("Class1 SomeMethod()"); } }
public class Class2 { public void Method() { Console.WriteLine("Class2 SomeMethod()"); } }
public class Class3 { public void Method() { Console.WriteLine("Class3 SomeMethod()"); } }
public interface IInterface { void Method(); }

public class MyClass1: Class1, IInterface { }
public class MyClass2 : Class2, IInterface { }
public class MyClass3 : Class3, IInterface { }





public abstract class AbsBaseClassA
{ 
    public abstract void AbstractMethod();
    public virtual void VirtualMethod() { Console.WriteLine("AbsBaseClassA VirtualMethod()"); }
    public void SimpleMethod() { Console.WriteLine("AbsBaseClassA SimpleMethod()"); }
}
public abstract class AbsBaseClassB
{
    public abstract void AbstractMethod();
    public virtual void VirtualMethod() { Console.WriteLine("AbsBaseClassB VirtualMethod()"); }
    public void SimpleMethod() { Console.WriteLine("AbsBaseClassB SimpleMethod()"); }
}

public abstract class AbsBaseClassC
{
    public abstract void AbstractMethod();
    public virtual void VirtualMethod() { Console.WriteLine("AbsBaseClassC VirtualMethod()"); }
    public void SimpleMethod() { Console.WriteLine("AbsBaseClassC SimpleMethod()"); }
}


public class ClassA : AbsBaseClassA
{
    public override void AbstractMethod() { Console.WriteLine("ClassA AbstractMethod()"); }
    public override void VirtualMethod() { Console.WriteLine("ClassA VirtualMethod()"); }
    //public virtual void SimpleMethod() { Console.WriteLine("ClassA SimpleMethod()"); }
}
public class ClassB : AbsBaseClassB
{
    public override void AbstractMethod() { Console.WriteLine("ClassB AbstractMethod()"); }
    //public override void VirtualMethod() { Console.WriteLine("ClassB VirtualMethod()"); }
    public new void SimpleMethod() { Console.WriteLine("ClassB SimpleMethod()"); }
}
public class ClassC : AbsBaseClassC
{
    public override void AbstractMethod() { Console.WriteLine("ClassC AbstractMethod()"); }
    //public override void VirtualMethod() { Console.WriteLine("ClassB VirtualMethod()"); }
    //public virtual void SimpleMethod() { Console.WriteLine("ClassC SimpleMethod()"); }
}




public class Versions_AdHoc_Polymorphism
{
    public static void Main()
    {
        Console.WriteLine("AdHoc Polymorphism: 1 2 3");

        // IInterface[] array = { new MyClass1(), new MyClass2(), new MyClass3() };
        dynamic[] array1 = { new MyClass1(), new MyClass2(), new MyClass3() }; 

        for (int i = 0; i < 3; ++i)
            array1[i].Method(); //dlr asked, dont know about the dynami methods...
                               //may show run time dynamic exception
        Console.WriteLine("AdHoc Polymorphism: A B C");


        Object[] array2 = { new ClassA(), new ClassB(), new ClassC() };
        Console.WriteLine("--------------------------------");
        foreach (dynamic i in array2) 
        {
            i.AbstractMethod();
            i.VirtualMethod();
            i.SimpleMethod();
            Console.WriteLine("--------------------------------" );
        }
        /*
        ClassA AbstractMethod()
        ClassA VirtualMethod()
        AbsBaseClassA SimpleMethod()
        --------------------------------
        ClassB AbstractMethod()
        AbsBaseClassB VirtualMethod()
        ClassB SimpleMethod()
        --------------------------------
        ClassC AbstractMethod()
        AbsBaseClassC VirtualMethod()
        AbsBaseClassC SimpleMethod()
        --------------------------------*/


        Console.WriteLine();

    }
}
