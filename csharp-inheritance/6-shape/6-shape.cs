﻿using System;

///<summary>class Shape</summary>
class Shape
{
    ///<summary>Throws an NotImplementedException</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    ///<summary> public property Width / get: retrieve width / set: set width or exception</summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary> public property Height / get: retrieve height / set: set height or exception</summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }


}