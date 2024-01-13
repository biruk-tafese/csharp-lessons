class ChildOOPdemo:OOPdemo
{
     public ChildOOPdemo()
     {
        Console.WriteLine("Child constructor with no parameter");
     }
     public ChildOOPdemo(string remarks) : base("Jamie", 1,2014)
     {
        Console.WriteLine("Remarks = {0}",remarks);
     }
      public ChildOOPdemo(string remarks, string name, int memberID, int
         memberSince) : base (name, memberID, memberSince)
      {
      Console.WriteLine("Child Constructor with 4 parameters");
      Console.WriteLine("Remarks = {0}", remarks);  
     }

     public void CalculateAnnualFee()
     {
        annualFee = 100+ 12*30;
     }
   }