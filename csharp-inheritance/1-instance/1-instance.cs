using System;
using System.Collections.Generic;

class Obj
{
    /// <summary> Returns true if instance is Array <summary/> ///
>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}