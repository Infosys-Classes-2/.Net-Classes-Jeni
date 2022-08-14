public class SpaceCraft
{
    protected string craftType;

public class Rocket
{    
    public bool CheckFuel(double indicatorValue)
    {
        if (indicatorValue = 100)
        return false;
        else
        return true;
    }

    public void StartEngin()
    {
        Console.WriteLine("Engine Stared.");
    }

    public void IncreaseSpeed()
    {
        Console.WriteLine("Speed has been increased.");
    }

    public interface IPrintReport
    {
     public void PrintReport()
     {
     Console.Write("This is Rocket.");     
     }
    }
}

public class Satelite : SpaceCraft
{
    string name ="Satelite Nepal";
    public void Print()
    {
        Console.WriteLine($"This is {name}");
    }    
}
}