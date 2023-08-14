using Basic_Programs;

LINQDemo lINQ = new LINQDemo();
lINQ.ShowResults();


//JA jA = new JA();
//jA.disp1d();
//jA.dispmd();

//GenericCollectionExamples genericCollectionExamples = new GenericCollectionExamples();
//genericCollectionExamples.AddNewElements();
//genericCollectionExamples.FindAnElement(); 


/*

Book book1 = new(1001, "Revolution 2020", " chetan bhagat", true);
Book book2 = new(1002, "Calpa mia", "john", true);
Book book3 = new(1003, "WorldWarI", "genie", false);
Book book4 = new(1004, "harry potter", "suriya", true);

Library.book.Add(book1);
Library.book.Add(book2);
Library.book.Add(book3);
Library.book.Add(book4);

Library library = new Library();
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the title of the book to borrow");
        string? title = Console.ReadLine();
        Console.WriteLine(title);
        library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the title of the book to return");
        string? title = Console.ReadLine();
        library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        library.DisplayBookDetails();
    }
    else if (choice == 4)
    {
        break;
    }


}


/*BankDetails bankDetails = new (12334, "Yogesh","Inactive",6565665565, 1000);

Boolean cont = true;


while (cont == true)
{
    Console.WriteLine("Enter 1.Custid 2.Accno 3.name 4.exit");

    int ch = Convert.ToInt32(Console.ReadLine());

    switch (ch)
    {
        case 1:
            int custid = Convert.ToInt32(Console.ReadLine());
            bankDetails.FetchAccountDetails(custid);
            break;
        case 2:
            long accno = Convert.ToInt64(Console.ReadLine());
            bankDetails.FetchAccountDetails(accno);
            break;

        case 3:
            string? name = Console.ReadLine();
            bankDetails.FetchAccountDetails(name);
            break;

        case 4:
            cont = false;
            break;
    }


}


/*
MyPetswithInterface myPet1 =new(2, 2, 4, "dog");
MyPetswithInterface myPet2 = new(2, 2, 4, "cat");

Animal.Eat();
Animal.Sleep();

myPet1.AboutMe();
myPet1.Sound();

myPet2.AboutMe();
myPet2.Sound();
/*
MyPets myPet1 = new(2, 2, 4, "Dog");
MyPets myPet2 = new(2, 2, 4, "Cat");

Animal.Eat();
Animal.Sleep();

myPet1.AboutMe();
myPet1.Sound();

myPet2.AboutMe();
myPet2.Sound();


StudentGrade studentGrade = new ("Kongu", "Erode",100, "Yogesh","Erode",100,90,85);

studentGrade.CollegeDisplay();
Console.WriteLine(studentGrade.Rno);
Console.WriteLine(studentGrade.Name);
Console.WriteLine(studentGrade.Address);
Console.WriteLine("Total : " + studentGrade.CalculateTotal());
Console.WriteLine("Average: " + studentGrade.CalculateAverage());
Console.WriteLine("Grade : " + studentGrade.CalcualteGrade());


TeachingStaff teachingStaff = new("Kongu","Erode",101,"Kalpana", "Karur", "ECE", 25000, 40, 25, 10, 5);
NonTeachingStaff nonTeachingStaff = new("Kongu","Erode",102, "Dharsana", "Coimbatore", 10000, 10, 25, 5, 5);

teachingStaff.CollegeDisplay();
Console.WriteLine(teachingStaff.Name);
Console.WriteLine(teachingStaff.Dept);
Console.WriteLine(teachingStaff.Basic_salary);
Console.WriteLine(teachingStaff.CalculateSalary());

Console.WriteLine(nonTeachingStaff.Name);
Console.WriteLine(nonTeachingStaff.Basic_salary);
Console.WriteLine(nonTeachingStaff.CalculateSalary());


/*
namespace SampleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] arr = { new Book(101, "Harry Potter", "Yogesh", true), new Book(102, "Soccers Stone", "Vignesh", true), new Book(103, "Notebook", "Jaya", true), new Book(104, "Visual Basic", "Gowtham", false) };
            Library library = new Library(arr);
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the title of the book to borrow");
                    string title = Console.ReadLine();
                    library.BorrowBook(title);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the title of the book to return");
                    string title = Console.ReadLine();
                    library.ReturnBook(title);
                }
                else if (choice == 3)
                {
                    library.DisplayBookDetails();
                }
                else if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}





/*using System;
using SampleBank;

namespace SampleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankaccount = new BankAccount(770808,"Yogesh");
            Console.WriteLine("Enter the amount to deposit :");
            int deposit = Convert.ToInt32(Console.ReadLine());
            bankaccount.amountDeposit(deposit);

            Console.WriteLine("Enter the amount to withdraw :");
            deposit = Convert.ToInt32(Console.ReadLine());
            bankaccount.amountWithdraw(deposit);

            Console.WriteLine($"Account number {bankaccount.Account_number} of account Holder {bankaccount.Account_holdername} have the balance of {bankaccount.Account_balance}");
  




            Console.ReadLine();
        }
    }
}




































/* using Basic_Programs;

   int  consumernumber = Convert.ToInt32(Console.ReadLine());
   string? consumername = Console.ReadLine();
   int cur_reading = Convert.ToInt32(Console.ReadLine());
   int pre_reading = Convert.ToInt32(Console.ReadLine());
   string? consumertype = Console.ReadLine();

ElectricReading electricReading = new ElectricReading(1352, "AAA", 1000.8000, "Commercial");

int Bill_amount = electricReading.CalculateBill();

    int Bill_amount= electricReading.CalculateBill();

Console.WriteLine($"Bill : " + $"{electricReading.consumernumber}"+ $"{electricReading.consumername}"+$"{electricReading.Bill_amount}");

*/



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

/*

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
*/