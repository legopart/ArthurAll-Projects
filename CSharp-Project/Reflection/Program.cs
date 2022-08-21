using System;/*  w w w  .  ja  v a 2s . co m*/      //Basics, dont use!
using System.Reflection;

public class MagicClass
{
    private int magicBaseValue;

    public MagicClass()
    {
        magicBaseValue = 2;
    }

    public int ItsMagic(int preMagic)
    {
        return preMagic * magicBaseValue;
    }
}

public class TestMethodInfo
{
    public static void Main()
    {
        Type magicType = Type.GetType("MagicClass");
        ConstructorInfo magicConstructor = magicType.GetConstructor(Type.EmptyTypes);
        object magicClassObject = magicConstructor.Invoke(new object[] { });


        
        MethodInfo magicMethod = magicType.GetMethod("ItsMagic");
        object magicValue = magicMethod.Invoke(magicClassObject, new object[] { 100 });



        Console.WriteLine("MagicClass.ItsMagic() returned: {0}", magicValue);

        Console.ReadLine();
    }

}