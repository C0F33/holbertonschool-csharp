using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int node = 0;
        if(myLList.Cointains(value))
        {
            foreach (int i in myLList)
            {
                if (i == value)
                    return node;
                node += i;
            }
        }
        else
        {
            return (-1)
        }

        return -1;
    }
}