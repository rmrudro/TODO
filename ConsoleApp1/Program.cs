// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


var num1 = 10;
string s;
Console.WriteLine("Enter Your Value");
s = Console.ReadLine();

bool iSLong = IsLong(s);


bool IsLong(string s)
{
    return s.Length > 10;
}



Console.ReadKey();

void PrintDocument(string inputstring)
{
    Console.WriteLine("Selected Option  " + inputstring);
}

