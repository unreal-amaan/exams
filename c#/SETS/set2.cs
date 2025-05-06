//  TASK-1  is task-5  use it from teh folder task5

//  TASK-2 

using System; using System.Text;
using System.Collections;
class stringbuilder {
public static void concat1(String s1)
{ 
s1 = String.Concat(s1, st);
}
public static void concat2(StringBuilder s2)
{
s2.Append("To C#.NET Lab");
}
public static void Main(String[] args)
{
String s1 = "Welcome"; concat1(s1); 
Console.WriteLine("Using String Class: " + s1);
StringBuilder s2 = new StringBuilder("Welcome"); concat2(s2);
Console.WriteLine("Using StringBuilder Class: " + s2);
}
}