using System;
using System.Collections.Generic;

class List
{
    public static List<int> UniqueValues(List<int> List1, List<int> List2)
    {
        var newList = new List<int>();

        foreach (int i in List1)
        {
            if (!List2.Contains(i) && !newList.Contains(i))
            {
                newList.Add(i);
            }
        }

        foreach (int j in List2)
        {
            if (!List1.Contains(j) && !newList.Contains(j))
            {
                newList.Add(j);
            }
        }

        newList.Sort();
        return newList;
    }
}