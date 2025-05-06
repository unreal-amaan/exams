//  TASK-1 *-----------------------


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


//  TASK-2  is task-11  use from the task 11 pdf

