﻿using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine(string.Format("{0}{0}{0}", str));
        Console.WriteLine(string.Format("{0}", str.Substring(0, 9)));
        }
}