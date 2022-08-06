using System;
public abstract class Vehicles
{
    string motorType;
    int noOfWheels;
    public void Moves()
    {
        console.WriteLine($"All Vehicles are movable.");
    }    
    public double CalculateSpeed(double distance, double time)
    {
        double speed = distance/time;
        return speed;
    }
}

public class VehicleCategory : Vehicles
{
    public void Moves(string type)
    {
        switch(type)
        {
            case type == "AIR": 
            Console.WriteLine("These vehicles fly on the sky.");
            break;
            case type == "LAND":
            Console.WriteLine("These vehicles moves on the road.");
            break;
            case type == "WATER":
            Console.WriteLine ("These vehicles runs on the water");
            break;
        }
    }
    public bool CheckFuel(double indicatorValue)
    {
        if (indicatorValue == 0.5)
        return false;
        else
        return true;
    }
}

public interface vehicles
{
    public void CalculateSpeed(double distance, double time); // as it's interface  
}

static class VehicleName
{
    static string name ="Car";
    public static void PrintName(string name)
    {
        Console.WriteLine($"The name of this vehicle is {name}.");
    }
}   