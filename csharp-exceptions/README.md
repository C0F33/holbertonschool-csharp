Tasks
0. Safe list printing
   mandatory
   Write a method that prints n elements of a list.

Class Name: List
Prototype: public static int SafePrint(List<int> myList, int n)
n represents the number of elements to print
n can be bigger than the length of myList
Returns number of elements actually printed
You have to use try / catch
carrie@ubuntu:~//0-safe_list_print$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
{
List<int> myList = new List<int>() {1, 2, 3, 4, 5};
int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}
carrie@ubuntu:~//0-safe_list_print$
carrie@ubuntu:~//0-safe_list_print$ ls
0-main.cs  0-safe_list_print.cs  0-safe_list_print.csproj  bin  obj
carrie@ubuntu:~//0-safe_list_print$ dotnet run
1
2
3
4
5
Number of integers printed: 5

1
2
3
Number of integers printed: 3

1
2
3
4
5
Number of integers printed: 5
carrie@ubuntu:~//0-safe_list_print$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-exceptions
File: 0-safe_list_print/, 0-safe_list_print/0-safe_list_print.csproj, 0-safe_list_print/0-safe_list_print.cs

0/10 pts
1. Integer division
   mandatory
   Write a function that divides 2 integers and prints the result.

Class Name: Int
Prototype: public static void divide(int a, int b)
You can assume that a and b are integers
You have to use try / catch / finally
The result of the division should print in the finally section in the format shown in the example
carrie@ubuntu:~//1-divide_print$ cat 1-main.cs
using System;

class Program
{
static void Main(string[] args)
{
int a, b;

        a = 4;
        b = 3;
        Int.divide(a, b);
        Console.WriteLine();

        a = 9;
        b = 0;
        Int.divide(a, b);
    }
}
carrie@ubuntu:~//1-divide_print$
carrie@ubuntu:~//1-divide_print$ ls
1-main.cs  1-divide_print.cs  1-divide_print.csproj  bin  obj
carrie@ubuntu:~//1-divide_print$ dotnet run
4 / 3 = 1

Cannot divide by zero
9 / 0 = 0
carrie@ubuntu:~//1-divide_print$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-exceptions
File: 1-divide_print/, 1-divide_print/1-divide_print.csproj, 1-divide_print/1-divide_print.cs

0/8 pts
2. Divide lists
   mandatory
   Write a function that divides element by element 2 lists.

Class Name: List
Prototype: public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
length can be bigger than the length of either list
Returns a new list of all division results
If 2 elements can’t be divided, the division result should be equal to 0
If the division can’t be done (dividing by 0):
print Cannot divide by zero
If either list is too short:
print Out of range
You have to use try / catch
carrie@ubuntu:~//2-divide_lists$ cat 2-main.cs
using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
{
List<int> list1 = new List<int>() {1, 20, 16, 15, 54};
List<int> list2 = new List<int>() {1, 0, 2, 3};
List<int> result;

        result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}
carrie@ubuntu:~//2-divide_lists$
carrie@ubuntu:~//2-divide_lists$ ls
2-main.cs  2-divide_lists.cs  2-divide_lists.csproj  bin  obj
carrie@ubuntu:~//2-divide_lists$ dotnet run
Cannot divide by zero
Out of range
1
0
8
5
carrie@ubuntu:~//2-divide_lists$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-exceptions
File: 2-divide_lists/, 2-divide_lists/2-divide_lists.csproj, 2-divide_lists/2-divide_lists.cs

0/13 pts
3. Throw exception
   mandatory
   Write a function that throws an Exception.

Class Name: Except
Prototype: public static void Throw()
carrie@ubuntu:~//3-throw_exception$ cat 3-main.cs
using System;

class Program
{
static void Main(string[] args)
{
try
{
Except.Throw();
}
catch (Exception)
{
Console.WriteLine("Exception raised");
}
}
}
carrie@ubuntu:~//3-throw_exception$
carrie@ubuntu:~//3-throw_exception$ ls
3-main.cs  3-throw_exception.cs  3-throw_exception.csproj  bin  obj
carrie@ubuntu:~//3-throw_exception$ dotnet run
Exception raised
carrie@ubuntu:~//3-throw_exception$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-exceptions
File: 3-throw_exception/, 3-throw_exception/3-throw_exception.csproj, 3-throw_exception/3-throw_exception.cs

0/4 pts
4. Throw exception with message
   mandatory
   Write a method that throws an Exception with a message.

Class Name: Except
Prototype: public static void ThrowMsg(string msg)
carrie@ubuntu:~//4-throw_exception_msg$ cat 4-main.cs
using System;

class Program
{
static void Main(string[] args)
{
try
{
Except.ThrowMsg("C is fun");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
}
}
carrie@ubuntu:~//4-throw_exception_msg$
carrie@ubuntu:~//4-throw_exception_msg$ ls
4-main.cs  4-throw_exception_msg.cs  4-throw_exception_msg.csproj  bin  obj
carrie@ubuntu:~//4-throw_exception_msg$ dotnet run
C is fun
carrie@ubuntu:~//4-throw_exception_msg$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-exceptions
File: 4-throw_exception_msg/, 4-throw_exception_msg/4-throw_exception_msg.csproj, 4-throw_exception_msg/4-throw_exception_msg.cs