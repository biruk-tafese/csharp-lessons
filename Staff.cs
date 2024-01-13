
class Staff 
{
    private string nameOfStaff;
    private const int hourlyPaid = 30;
    private int hWorked;

    public Staff(string name)
    {
        nameOfStaff = name;
        Console.WriteLine("\n"+nameOfStaff);
        Console.WriteLine("----------------------");
    }

    public Staff(string firstname, string lastName)
    {
        nameOfStaff = firstname+" "+lastName;
        Console.WriteLine("\n"+nameOfStaff);
        Console.WriteLine("-------------------------");
    }
    public int HoursWorked
    {
        get
        {
            return hWorked;
        }
        set
        {
             if(value > 0)
                hWorked = value;
             else 
                hWorked = 0;
        }
    }

    public void PrintMessage()
      {
         Console.WriteLine("Caculating pay...");
      }
    public int CalculatePay()
    {
        PrintMessage();
        int staffPay;
        staffPay = hWorked * hourlyPaid;

        if (hWorked > 0)
          return staffPay;
        else
          return 0;
    }

    
    public int CalculatePay(int bonus, int allowance)
    {
        PrintMessage();

        if (hWorked > 0)
           return hWorked * hourlyPaid + bonus + allowance;
        else
          return 0;

    }

    public override string ToString()
    {
        return "Name of Staff = "+ nameOfStaff + ", hourlyRate = "+ hourlyPaid+" , HourlyPaid = " + hWorked;
    }
}