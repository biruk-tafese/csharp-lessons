class Car
{
 // The 'state' of the Car.
 public string petName;
 public int currSpeed;
// The functionality of the Car.

public Car()
{
   petName = "Chuck";
   currSpeed = 10;
}

public Car(string pn) 
{
    petName = pn;
}

public Car(string pn, int cs)
{
    petName = pn;
    currSpeed = cs;

}

public void PrintState()
 => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
public void SpeedUp(int delta)  
 => currSpeed += delta;
 

}