// TASK-1   is task-10  use it from the task10 folder


// TASK-2 *-------------------------------------

using System;
public class Methodoverloading
{
public int add(int a, int b) //two int type Parameters method
{
int sum=a+b;
return sum;
}
public double add(double a, double b,double c)
{
double sum=a+b+c; 
return sum;
}
public float add(float a, float b,float c,float d)
{
float sum=a+b+c+d; 
return sum;
}
public static void Main(string[] args)
{
Methodoverloading ob=new Methodoverloading();
int sum2=ob.add(2,4);
Console.WriteLine("Sum of two integer value:"+sum2);
double sum3=ob.add(5.2d, 3.5d,3.2d); 
Console.WriteLine("Sum of three double value:"+sum3);
float sum4=ob.add(0.1f,0.3f,0.8f,0.1f); 
Console.WriteLine("Sum of four flat value:"+sum4);
}
}