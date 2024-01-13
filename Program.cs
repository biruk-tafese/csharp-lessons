// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int pay;
        Staff staff1 = new Staff("Peter");
        staff1.HoursWorked = 160;
        pay = staff1.CalculatePay(1000, 400);
        Console.WriteLine("Pay = {0}", pay);

    int[] myArr = {1,4,5,6,3,2,5,2};
    AdvancedConcepts advan = new AdvancedConcepts();
      
       advan.PrintFirstElement(myArr);

       List<int> myArr2 = new List<int>{122,3,4,6,7,8};
       advan.PrintFirstElementUsingList(myArr2);

    //     int[] myArr3 = advan.ReturnUserInput();
   
    //   List<int> myList2 = advan.ReturnUserInput2();
    
     advan.PrintNames("Abebe");
     advan.PrintNames("Eyou","abe","kebe");

     ChildOOPdemo mychild = new ChildOOPdemo("Special Rate", "James",
1, 2010);
     
     // Polymorphism
     OOPdemo[] parents = new OOPdemo[3];
     
     parents[0] = new ChildOOPdemo("Special Rate", "James", 1, 2010);
     parents[1] = new ChildOOPdemo("Normal Rate", "Andy", 2, 2011);
     parents[2] = new ChildOOPdemo("Normal Rate", "Bill", 3, 2011);
  

       foreach(ChildOOPdemo parent in parents )
       {
            parent.CalculateAnnualFee();
            Console.WriteLine(parent.ToString());
       }
    }


   

}


























// decimal income = 234.234m;
// float hourlyPaid = 23.44f;
// int x =  2;

// Console.WriteLine(x++);
// Console.WriteLine(income + "  and " + hourlyPaid);


// int typeCast = (int)income;
// Console.WriteLine(typeCast);

// //Arrays ,strings, lists

// string[] questions;

// questions = new [] {"How","When","Where"};

// Console.WriteLine(questions[2]);

// //Array Properties #Length #Copy   #Sort #List

// Console.WriteLine(questions.Length);

// string[] answers =  {"yes","okey","no","got it"};

// Array.Copy(questions, answers,3);

// for(int i=0; i < answers.Length; i++){  Console.WriteLine(answers[i]); } 

// int[] scores = new[] {12,23,34,6,0,12};

// Array.Sort(scores);

// for (int i=0; i<scores.Length;i++)
//  { 
//     Console.WriteLine(scores[i]); 
//  }


// List<int> Ages = new List<int>{12,2,3,4,5,6};

// Ages.Add(23);
// Ages.Insert(3,23);
// Ages.Remove(23);
// Ages.RemoveAt(3);

// for (int i=0; i<scores.Length;i++)
//  { 
//     Console.Write(Ages[i]+" "); 
//  }


// Console.WriteLine("\n"+Ages.Count());

// Console.WriteLine("The number is {0:C}: ",123.4433);


// //Concluding the above notes together

// Console.WriteLine("C# IS Fricking Good Language");

// string name = "";
// int age = 0;
// int year = 0;
// string department = "";
// double Cgpa = 0;


// Console.WriteLine("Enter your name: ");
// name =Console.ReadLine();

// Console.WriteLine("Enter your Age: ");
// age =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter your Current Year: ");
// year =Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Enter your Current Department you are attending: ");
// department =Console.ReadLine();

// Console.WriteLine("Enter your Current CGPA: ");
// Cgpa =Convert.ToDouble(Console.ReadLine());


// Console.WriteLine("My name is {0}. I am {1} year computer Science student at AAU. and I am {2} years old. I am learning  {3}. and I have achieved {4} CGPA.", name, year,age,department,Cgpa);

