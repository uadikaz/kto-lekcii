// zada4a2

using System;  
namespace New_Project  
{ public static class Program   
{ public static void Main()   
{ long a, b, c, i, max; 
  Console.Write("a b c: ");  
  var line = Console.ReadLine().Split(" ");  
  a = long.Parse(line[0]); 
  b = long.Parse(line[1]); 
  c = long.Parse(line[2]); 
  Console.WriteLine("Max = " + 
  Math.Max(a, Math.Max(b, c))); } } }