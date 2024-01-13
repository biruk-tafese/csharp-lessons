// using System;
// using System.Collections.Generic;
// using System.IO.Compression;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Abstract;

// namespace Abstract
// {
//     class Abstract
//     {
//          static void Main(string[] args)
//          {
//             //MyAbstractClass abClass = new MyAbstractClass();
//              ClassA a = new ClassA();
//              a.PrintMessage();
//              a.PrintMessageAbstract();
//              Console.Read();
//          }
//     }

//     abstract class MyAbstractClass
//     {
//         private string message = "Hello c#";
//         public void PrintMessage()
//         {
//             Console.WriteLine(message);
//         }
//         public abstract void PrintMessageAbstract();

//     }
//     class ClassA : MyAbstractClass
//     {
//         public override void PrintMessageAbstract()
//         {
//            Console.WriteLine("C# is fun!");
//         }
//     }
// }



// namespace InterfaceDemo
// {
     
//       class Abstract
//       {
//           static  void Main(string[] args)
//           {
//             ClassA a = new ClassA();

//               a.MyNumber = 5;
//               a.InterfaceMethod();
//               Console.Read();
//           }
//       }

//       interface Ishape
//       {
//         int MyNumber
//         {
//             get;
//             set;
//         }
//         void InterfaceMethod();
//       }
//       class ClassA : Ishape
//       {
//         private int myNumber;
//         public int MyNumber{
//              get
//              {
//                return myNumber;
//              }
//              set 
//              {
//                 if(value < 0)
//                   myNumber = 0;
//                 else 
//                   myNumber = value;
//              }
//         }
//         public void InterfaceMethod()
//         {
//             Console.WriteLine("The number is {0}.", myNumber);
//         }
//       }
// }