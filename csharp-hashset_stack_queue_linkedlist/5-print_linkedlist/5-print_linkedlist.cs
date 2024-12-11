using System;
using System.Collections.Generic;

class LList
{
    public static LinkedLists<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            LinkedLists<int> listEmpty = new LinkedLists<>();
            return listEmpty;
        }

        List<int> nList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            nList.Add(i);
            Consle.WriteLine(i);
        }

        LinkedList<int> nList1 = new LinkedLists<int>(nList);
        return nList1;
    }
}