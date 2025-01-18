using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null.");
            return;
        }

        Type type = myObj.GetType();

        // Print the properties
        Console.WriteLine("Properties:");
        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        // Print the methods
        Console.WriteLine("Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}