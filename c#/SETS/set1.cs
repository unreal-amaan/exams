// *******************************TASK-1*****************

using System;
public class Employee
{
public float salary = 40000;
}
public class Programmer: Employee
{
public float bonus = 10000;
}
class TestInheritance{
public static void Main(string[] args)
{
Programmer p1 = new Programmer();
Console.WriteLine("Salary: " + p1.salary); Console.WriteLine("Bonus: " + p1.bonus);
}
}





// *******************************TASK-2*****************

using System;
public class employee
{
public int id; public string name; public float salary;
public void insert(int i, string n, float s)
{
id=i; name=n; salary=s;
}
public void display()
{
Console.WriteLine(id+ " " +name+ " " +salary);
}
}
class test
{
public static void Main(string[] args)
{
employee e1 = new employee();
int a; string b; float c;
Console.WriteLine("Enter the No."); a=Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter name"); b=Convert.ToString(Console.ReadLine()); Console.WriteLine("Enter the salary."); c=Convert.ToInt32(Console.ReadLine()); e1.insert(a,b,c);
e1.display();
}
}