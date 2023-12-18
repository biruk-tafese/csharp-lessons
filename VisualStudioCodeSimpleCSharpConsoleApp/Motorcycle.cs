 class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public void PopAWheely()
            {
               for (int i = 0; i <= driverIntensity; i++)
                {
                 Console.WriteLine("Yeeeeeee Haaaaaeewww!");
                 }
                 }

        //set all data members to default values
        public Motorcycle() {}

        //our custom constructor
        public Motorcycle(int intensity)
        {
            
            SetIntensity(intensity);
          // : this(intensity, ""){};
        }

        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
            driverName = name;
        }

        public void SetIntensity(int intensity)
        {
            if(intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;

        }

        public void SetDriverName(String name)
          => this.driverName = name; //this(0, name); 

        
    }


/*
  Class Motorcycle
  {
    public int driverIntensity;
    public string drivername;

    //Constructor chaining
    public Motorcycle()
    {
        Console.WriteLine("In default actor");
    }

    public Motorcycle(int intensity)
    : this (intensity, "")
    {
      Console.WriteLine("In actor taking an int");
    }
   
    public Motorcycle(string name): this(0, name)
    {
      Console.WriteLine("In actor taking a string");
    }

    //This is the 'master' constructive that does all the real work.

    
    public Motorcycle(int intensity, string name)
    {
     Console.WriteLine("In master ctor ");
     if(intensity > 10)
     {
        intensity = 10;
     }
     drivenIntensity = intensity;
     drivenName = name;
    }
  }
*/