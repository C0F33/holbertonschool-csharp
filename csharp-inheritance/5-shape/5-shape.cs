using System;

class Shape
{
    // Virtual method Area
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}