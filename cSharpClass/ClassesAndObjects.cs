//Animal
using System;

internal class Animal //if no access modifier is defined by default it is internal
{
    //Members: fields, methods
    //Access modifiers :public, private,internal, protected
    internal float weight; // if no access modifier is defined by default it is private for properties or data
    internal string type;

    void Eat()
    {
        Console.WriteLine(type + "is eating.");
    }
    internal void PrintDetails()
    {
        Eat();
        Console.WriteLine($"Weight of {type} is {weight} kg.");
    }

}

class TestClasses
{
    public static void Main()
    {
        Animal cow = new Animal();// old version
        Animal goat = new ();  //new version
        var buffalo = new Animal(); // if declared as var
        Animal deer = new Animal();
        Animal fish = new Animal();
        Animal bear = new Animal();

        cow.weight =325.4f;
        cow.type = "Herbivorous animal cow";
        cow.PrintDetails();
    }
}