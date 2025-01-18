using System;
using System.Reflection;
using System.Collections.Generic;

class Obj
{
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null.");
            return;
        }

        // Get the Type and TypeInfo
        Type _Type = myObj.GetType();
        TypeInfo _TInfo = _Type.GetTypeInfo();

        // Get the properties and methods
        IEnumerable<PropertyInfo> propList = _Type.GetProperties();
        IEnumerable<MethodInfo> methList = _Type.GetMethods();

        // Print properties
        Console.WriteLine("{0} Properties:", _Type.Name);
        foreach (PropertyInfo i in propList)
        {
            Console.WriteLine(i.Name);
        }

        // Print methods
        Console.WriteLine("{0} Methods:", _Type.Name);
        foreach (MethodInfo j in methList)
        {
            Console.WriteLine(j.Name);
        }
    }
}