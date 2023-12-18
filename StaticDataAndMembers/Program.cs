// See https://aka.ms/new-console-template for more information

/*
  
   Here, the assumption is that all saving accounts should have the same interest rate. Because static data
is shared by all objects of the same category, if you were to change it in any way, all objects will “see” the
new value the next time they access the static data, as they are all essentially looking at the same memory
location. To understand how to change (or obtain) static data, you need to consider the role of static
methods.


*/
using System;
using StaticDataAndMembers;


Console.WriteLine("****** Fun with Static Data *******");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);

//Print the current interest rate
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

//Make new object, this oes NOT 'reset' the interest rate.
SavingsAccount s3 = new SavingsAccount(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

Console.ReadLine();
