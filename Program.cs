// See https://aka.ms/new-console-template for more information

class GreeterProgram {

    static void Main()
    {
        Console.WriteLine("Welcome to the Greeter Program!");


        //Promp the user to enter their name
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();


        //Greet the user
        Console.WriteLine($"Hello , {userName}!Welcome to the Greeter and Calculator program.");

        //ask the user if they want to use the calculator
        Console.WriteLine("\nCalculator:You can perform basic arthimatic operations. ");
        Console.Write("Do you want to use the calculator? (yes/no): ");
        string answer = Console.ReadLine().ToLower();

        if(answer == "yes") 
        {
            //calculator functionality
            Console.WriteLine("\nEnter the two numbers to perform calculations.");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); //Reads the first number
            Console.Write("Enter the second numer: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); //Reads the second number


            Console.WriteLine("\nAvailable Operations: ");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. division (/)");
            Console.WriteLine(" Please enter the number corresponding to the operation you want to perform: ");


            int choice = Convert.ToInt32(Console.ReadLine());


            //perform the selected operations and display the result

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Result: {num2}+{num1} = {num1+num2}");
                    break;
                case 2:
                   Console.WriteLine($"Result: {num2}-{num1} = {num2 - num1}");
                   break;
                case 3:
                   Console.WriteLine($"Result: {num2} * {num1} = {num2*num1}");
                   break;

                case 4:
                   Console.WriteLine($"Result: {num2}/{num1}= {num2/num1}");
                   break;
                default:
                  Console.WriteLine("Invalid input, try again.");
                  break;
            }


        }

        else {
            Console.WriteLine("No, May be other time.");
        }
    }
}