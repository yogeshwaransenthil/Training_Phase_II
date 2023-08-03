/* Program 1
 
int num1, num2, rem;

num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

rem = num1 + num2;

Console.WriteLine(rem);

*/

/* Program 2
 
double num1;

int num2, rem;

num1 = Convert.ToDouble(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

rem = (int)num1 + num2;

Console.WriteLine(rem);

*/

/*
// Armstrong numbers
int num, sum = 0;

num=Convert.ToInt32(Console.ReadLine());
int temp = num;

while(num > 0)
{
    int rem = num % 10;
    sum += rem * rem * rem;
    num /= 10;
}

if (sum == temp)
    Console.WriteLine("Its an Armstrong number");
else Console.WriteLine("Not an Armstrong number");
*/


//To find perfect number
/*
int num1, sum = 0;
Console.WriteLine("Perfect Number");
Console.WriteLine("Enter the number to verify Perfect number: ");
num1 = Convert.ToInt32(Console.ReadLine());

int i = 1;
while(i<=num1/2)
{
    if (num1 % i == 0)
            {
        sum = sum + i;
    }
    i++;
}
if (sum == num1)
{
    Console.WriteLine( num1+"is Perfect number");
}
else
{
    Console.WriteLine(num1 + "is not a Perfect Number");
}
*/

using System.CodeDom.Compiler;

// Generate Prime number between values.

int num1, num2;
Console.WriteLine("Prime number Generators");
Console.WriteLine("Start from: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" End to: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The Prime numbers are: ");
for (int i = num1; i <= num2; i++)
{
    int val = 0;
    int j = 2;
    while(j<=i/2)
    {
        if (i % j == 0)
        {
            val = 1;
        }
        j++;
    }
    if (val == 0)
    {
        Console.WriteLine(i);
    }
}
