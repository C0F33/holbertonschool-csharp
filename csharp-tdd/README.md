0. Add integers
   mandatory
   Write a method that adds 2 numbers

Namespace: MyMath
Class: Operations
Prototype: public static int Add(int a, int b)
Returns: sum of a and b
Test Library Namespace: MyMath.Tests
It is not necessary to account for integer overflow in this task
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-tdd
File: 0-add/, 0-add/0-add.sln, 0-add/MyMath, 0-add/MyMath/MyMath.csproj, 0-add/MyMath/MyMath.cs, 0-add/MyMath.Tests, 0-add/MyMath.Tests/MyMath.Tests.csproj, 0-add/MyMath.Tests/MyMath.Tests.cs

0/18 pts
1. Divide a matrix
   mandatory
   Write a method that divides all elements of a matrix.

Namespace: MyMath
Class: Matrix
Prototype: public static int[,] Divide(int[,] matrix, int num)
Returns: a new matrix containing divided elements
If num is 0, print Num cannot be 0 and return null. (Hint: use try / catch)
If matrix is null, return null
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-tdd
File: 1-divide/, 1-divide/1-divide.sln, 1-divide/MyMath, 1-divide/MyMath/MyMath.csproj, 1-divide/MyMath/MyMath.cs, 1-divide/MyMath.Tests, 1-divide/MyMath.Tests/MyMath.Tests.csproj, 1-divide/MyMath.Tests/MyMath.Tests.cs

0/23 pts
2. Max integer
   mandatory
   Write a method that returns the max integer in a list of integers.

Namespace: MyMath
Class: Operations
Prototype: public static int Max(List<int> nums)
Returns: max integer in list
If nums is empty, return 0
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-tdd
File: 2-max_int/, 2-max_int/2-max_int.sln, 2-max_int/MyMath, 2-max_int/MyMath/MyMath.csproj, 2-max_int/MyMath/MyMath.cs, 2-max_int/MyMath.Tests, 2-max_int/MyMath.Tests/MyMath.Tests.csproj, 2-max_int/MyMath.Tests/MyMath.Tests.cs

0/34 pts
3. Desserts, I stressed!
   mandatory
   Write a method that returns True if a string is a palindrome or False if it’s not.

Namespace: Text
Class: Str
Prototype: public static bool IsPalindrome(string s)
Returns: True if string is a palindrome, False if it’s not

In this task, palindromes are not case sensitive

Racecar = True
level = True
Spaces and punctuation should be ignored

A man, a plan, a canal: Panama. = True
An empty string is considered a palindrome

Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-tdd
File: 3-palindrome/, 3-palindrome/3-palindrome.sln, 3-palindrome/Text, 3-palindrome/Text/Text.csproj, 3-palindrome/Text/Text.cs, 3-palindrome/Text.Tests/, 3-palindrome/Text.Tests/Text.Tests.csproj, 3-palindrome/Text.Tests/Text.Tests.cs

0/34 pts
4. Unique character
   mandatory
   Write a method that returns the index of the first non-repeating character of a string.

Namespace: Text
Class: Str
Prototype: public static int UniqueChar(string s)
Returns: index of first non-repeating character or -1 if there is no non-repeating character
You can assume the string contains only lowercase letters, no spaces or special characters
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-tdd
File: 4-unique/, 4-unique/4-unique.sln, 4-unique/Text, 4-unique/Text/Text.csproj, 4-unique/Text/Text.cs, 4-unique/Text.Tests/, 4-unique/Text.Tests/Text.Tests.csproj, 4-unique/Text.Tests/Text.Tests.cs

0/30 pts
5. camelCase
   mandatory
   Write a method that determines how many words are in a string. Each word begins with a capital letter except the first word.

Namespace: Text
Class: Str
Prototype: public static int CamelCase(string s)
Returns: number of words in s
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-tdd
File: 5-camelcase/, 5-camelcase/5-camelcase.sln, 5-camelcase/Text/, 5-camelcase/Text/Text.csproj, 5-camelcase/Text/Text.cs, 5-camelcase/Text.Tests/, 5-camelcase/Text.Tests/Text.Tests.csproj, 5-camelcase/Text.Tests/Text.Tests.cs