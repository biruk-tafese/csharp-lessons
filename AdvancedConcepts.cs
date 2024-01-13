class AdvancedConcepts
{
    
    public void PrintFirstElement(int[] a)
    {
        Console.WriteLine("The firt element is :{0} ", a[0]);
    }
    public void PrintFirstElementUsingList(List<int> a)
    {
        Console.WriteLine("The first list element is : {0}", a[0]);
    }

    public int[] ReturnUserInput()
    {
        int[] a = new int[3];

        for(int i=0; i < a.Length; i++)
        {
            Console.WriteLine("Enter an integer: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer added to array. \n");

        }
        return a;
    }

      public List<int> ReturnUserInput2()
    {
        List<int> a = new List<int>();
        int input;

        for(int i=0; i < 3; i++)
        {
            Console.WriteLine("Enter an integer: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer added to list. \n");
            a.Add(input);
        }
        return a;
    }

    //PARAM
    public void PrintNames(params string[] names)
    {
        for(int i=0; i < names.Length; i++)
        {
            Console.Write(names[i]+" ");
        }
        Console.WriteLine();
    }

}