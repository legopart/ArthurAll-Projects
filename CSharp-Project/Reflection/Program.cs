using System;/*  w w w  .  ja  v a 2s . co m*/      //Basics, dont use!
using System.Reflection;



public class Dog
{
    private int age = 3;
    public int getAge() { return age; }
}

public class TestMethodInfo
{
    public static void Main()
    {
        var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        Dog dog = new Dog();
        
        Type? DogType = Type.GetType("Dog");
        var ageField = DogType?.GetField("age", bindingFlags);
        ageField?.SetValue(dog, 10);

        

        Console.WriteLine("dog Age " + dog.getAge()  ); //10
        Console.WriteLine("dog Age " + ageField?.GetValue(dog) + " " + ageField?.GetValue(dog)?.GetType()); //10 int32

        Dog dog2 = new Dog();
        Console.WriteLine("dog2 Age " + dog2.getAge()); //3



        Type magicType = Type.GetType("MagicClass");
        ConstructorInfo magicConstructor = magicType.GetConstructor(Type.EmptyTypes);
        object magicClassObject = magicConstructor.Invoke(new object[] { });


        
        MethodInfo magicMethod = magicType.GetMethod("ItsMagic");
        object magicValue = magicMethod.Invoke(magicClassObject, new object[] { 100 });



        Console.WriteLine("MagicClass.ItsMagic() returned: {0}", magicValue);

       // Console.ReadLine();
    }

}




public class MagicClass
{
    private int magicBaseValue;

    public MagicClass() //constructure
    {
        magicBaseValue = 2;
    }

    public int ItsMagic(int preMagic)
    {
        return preMagic * magicBaseValue;
    }
}