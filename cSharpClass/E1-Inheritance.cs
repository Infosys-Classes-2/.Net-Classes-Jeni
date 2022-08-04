using System;
public class LivingThing
{
    public string food;
    public string scientificName;
    public void Eat()
    {
        Console.WriteLine($"I am eating {food}");
    }
}

public class Plant : LivingThing //: means inherits
{
    public bool flowering;
    public int leafCount;

    public void  PringPlantDetail()
    {
        var x = flowering ? "flowering" : "non-flowering"; //if else inline version
        Console.WriteLine("I am {x} plant.");
    }
}

public class Animal : LivingThing
{
    public byte noOfLegs;
    public AnimalCategory type;

    public void PrintAnimalDetail()
    {
        var x = type == AnimalCategory.vertibrates ? "bones" : "no bones";
        Console.WriteLine("I have{x}");
    }

}
// public class Human: Animal
// {
//     Console.WriteLine("fdsss");
// }

// public class YarsaGumba : Plant //,class YarsaGumba : Animal Plant  //c# doesn't allow but c ++ allows as c# and java's physophy is that one category can not have other category
// {
// Console.WriteLine("I have");
// }

// public interface IAnimal //interface is implemented where as class is inheritated (term)
// {
//     public void PrintAnimalDetail(); // as it's interface  
//     {
//     Console.Write("abc");
//     }
// }
public enum AnimalCategory //enum should be made parallel to class not inside other classes , normally we create a single file named enums while doing project
{
    vertibrates, 
    invertibrates
    //or yu cna use single line like {Vertibrates, Invertibrates} but above is standard
}

// L,P <- L, A <- L  IS CALLED SINGLE INHERITANCE
//L, A <- L, H <- A  IS CALLED MULTI-LEVEL INHERITANCE
//A, IA, Y <- A ,  IA