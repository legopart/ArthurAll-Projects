using System.Windows;
using System;
using System.Reflection;
namespace Invoke
{
    class Program
    {

        //private  Program programInstance = new Program();
        static void Main(string[] args)
        {

            InvokerClass.StartInvokeExample<Program>("Hello", "World!");

        }

        public void thisMethod(String data1, String data2)
            => Console.WriteLine("DATA1=>" + data1 + ", DATA2=>" + data2);
        
    }

    class InvokerClass
    {

        //Do invoking here
        public static void StartInvokeExample<T>(String data1, String data2)  where T : new()
        {
            Type type = typeof(T);
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            object classConstractorObject = constructor.Invoke(new object[] { }); //args // Program()

            MethodInfo classMethod = type.GetMethod("thisMethod");
            classMethod.Invoke(classConstractorObject, new object[] { data1, data2 });
        }

        /*
        public static void StartInvokeExample (Type t, String data1, String data2)
        {
            ConstructorInfo cons = t.GetConstructor(Type.EmptyTypes);
            object classObject = cons.Invoke(new object[] { });

            MethodInfo m = t.GetMethod("thisMethod");
            m.Invoke(classObject, new object[] { data1, data2 });
        }
        */

    }

}