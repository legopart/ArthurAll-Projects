using System;
using System.Drawing;
using System.Reflection;
using System.Transactions;









[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
    public static int aaa = 119;
    public readonly string _Url;
    public string Topic { get { return topic; } set { topic = value; } }
    public HelpAttribute(string url) { _Url = url; }
    private string topic;
}





namespace CSharp_Project
{//https://www.tutorialspoint.com/csharp/csharp_reflection.htm

    [HelpAttribute("Information on the class MyClass +999")]
    class MyClass
    {


        [HelpAttribute("bbbbb")]
        public void foo2() { }

        public void foo() 
        {
            
           // System.Reflection.MemberInfo info = this.GetType();
            object[] attributes = this.GetType().GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                if(attribute != null && attribute is HelpAttribute)
                {
                    HelpAttribute ha = (HelpAttribute)attribute;
                    if (ha != null) Console.WriteLine(ha._Url);
                }
                
            }


            object[] methodAttributes = this.GetType().GetMethods();
            foreach (MethodInfo m in methodAttributes)
            {
                foreach (Attribute attribute in m.GetCustomAttributes(true))
                {
                    if (attribute != null && attribute is HelpAttribute)
                    {
                        HelpAttribute ha = (HelpAttribute)attribute;
                        if (ha != null) Console.WriteLine(ha._Url);
                    }
                }

            }



        }


    }

    class A
    {

        
        int aInt;
        B? adjast; 

        ~A() { Console.WriteLine("ByeA");  }
    }

    class B 
    {
        int aInt;
        A? adjast;
        ~B() { Console.WriteLine("ByeA"); }
    }




    class Program
    {

        static void foo(int[] arr) { arr[2] = 5; }




        static void Main()
        {
            {
                Console.WriteLine();
               //Console.WriteLine("-");
               //A a = new A();
               //int in = 42;
               //Type type = in.GetType();

               Program programReflaction =  new Program();


                System.Reflection.MemberInfo info = typeof(MyClass);
                object[] attributes = info.GetCustomAttributes(false);

                for (int i = 0; i < attributes.Length; i++)
                {
                    System.Console.WriteLine(attributes[i].ToString());
                }

                foreach (var attribute in attributes)
                {
                    HelpAttribute ha = (HelpAttribute)attribute;
                    if (ha != null) Console.WriteLine(ha._Url);
                }



                Console.WriteLine("foo");
                MyClass mc = new();
                mc.foo();





                //int[] arr = { 1, 2, 3 };
                //foo(arr);
                //Console.WriteLine(String.Join(", ", arr)); //{ 1, 2, 5 }

            }

        }


    }
}
           







