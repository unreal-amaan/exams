// TASK-1 it is task-9 so use it from teh task9 folder (either visual studio or vscode )





// TASK-2 *-------------------------------------

using System; public class P
{
public static void Main (string [] args)
{
int n,r,sum=0,temp; Console.Write("Enter the Number: "); n = int.Parse(Console.ReadLine()); temp=n;
while(n>0)
{
r=n%10;
sum=(sum*10)+r; n=n/10;
}
if(temp==sum)
Console.Write("Number is Palindrome."); else
Console.Write("Number is not Palindrome");
}
}

