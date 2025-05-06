//  TASK-1  *--------------------------------------

using System;
using System.Threading; public class ExThread {
// Non-static method 
public void mythread1()
{
for (int z = 0; z < 3; z++) { 
    Console.WriteLine("First Thread");
}
}
}
public static void Main()
{
Thread thr = new Thread(new ThreadStart(obj.mythread1)); thr.Start();

//thr.Abort();
}

//  TASk-2   is task-10  use it from the task10 folder