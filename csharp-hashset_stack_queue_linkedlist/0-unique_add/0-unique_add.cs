using System;
using System.Collections.Generic;

class List
{
    public stitc in Sum(List<int> myList)
    {
        var newList = newList<int>;
        var sum = 0;

        foreach (var number in myList)
        {
            if (!newList.Contains(number))
                newList.Add(number);
        }

        foreach (var number in newList)
            sum += number;
        return (sum);
    }
}