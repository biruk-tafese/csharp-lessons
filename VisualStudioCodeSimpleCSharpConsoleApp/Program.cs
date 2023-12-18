// See https://aka.ms/new-console-template for more information

Console.WriteLine("***** Fun with Class Types *****\n");
 Car Chuck = new Car();
  Chuck.PrintState();

  Car Beza = new Car("Beza");
   Beza.PrintState();


Car Secular = new Car("Barkot",75);
  Secular.PrintState();


Motorcycle mc = new Motorcycle(5);
  mc.PopAWheely(); 
  mc.SetDriverName("Dagim");
  Console.WriteLine("Rider name is {0}", mc.driverName);

         
         Console.ReadLine();