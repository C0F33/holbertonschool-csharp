using System;
using System.Collections.Generic;

public class Obj
{
    ///<summary>returns True if the object is an int, otherwise return False</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}