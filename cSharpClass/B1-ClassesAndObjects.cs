//Animal
using System;

internal class Animal1 //if no access modifier is defined by default it is internal
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

