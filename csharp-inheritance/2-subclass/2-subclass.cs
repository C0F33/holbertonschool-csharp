using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>Checks if object inherits from derivedType</summary>
    
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }