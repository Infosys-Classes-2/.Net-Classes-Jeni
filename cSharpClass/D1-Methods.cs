// using System;

// public class MethodLearning
// {
//     // returns nothing, take no arguments
//     public void PrintNepal()
//     {
//         Console.WriteLine("Nepal");
//     }
//     // returns nothing, take some arguments
//     public void PrintNepalNTimes(int n)
//     {
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine("Nepal");
//         }
//     }

//     // returns some value, take no/some arguments
//     public int Add(int x, int y)
//     {
//         var sum = x + y;
//         return sum;
//     }

//     // input- Bishnu Singh sdfasfd Rawal, output - BR
//     public string GetInitials(string fullName)
//     {
//         var nameParts = fullName.Split(" "); //delimeter
//         var len = nameParts.Length;
//         var first = nameParts[0][0]; //as string is also a kind of string array we can use indexing on string values
//         var last = nameParts[len - 1][0];

//         var initial = $"{first}{last}";
//         return initial;
//     }

//     // returns multiple values, take no/some arguments
//     public (short,short) GetMinMax(short[] numbers)
//     {
//         short min =short.MaxValue, max=short.MinValue;
//         foreach(short num in numbers)
//         {
//             if (num < min)
//                 min = num;
//             if(num>max)
//                 max=num;
//         }
//         return (min,max);  //tuple of 2 variales we can use any no of variables in tuples of variables
//     }

    
//     // 1. Write a function to return min, max and average of given array of numbers. Hint GetMinMax() 
//     public (short,short,float) GetMinMaxAvg(short[] numbers)
//     {
//         short min =short.MaxValue, max=short.MinValue;
//         float sum =0;
//         int len = numbers.Length;
//         foreach(short num in numbers)
//         {
//             if (num < min)
//                 min = num;
//             if(num>max)
//                 max=num;
//             sum = sum + num ;
//         }
//         return (min,max, sum/len);  //tuple of 2 variales we can use any no of variables in tuples of variables
//     }


//     // variable number of arguments, named parameters, optional parameters 

// }


using System;
using System.Linq;

namespace AboutClasses;
public class MethodLearning
{
    // returns nothing, take no arguments
    public void PrintNepal()
    {
        Console.WriteLine("Nepal");
    }
    // returns nothing, take some arguments
    public void PrintNepal(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nepal");
        }
    }

    // returns some value, take no/some arguments
    public int Add(int x, int y)
    {
        var sum = x + y;
        return sum;
    }

    // input- Bishnu Singh Rawal, output - BR
    public string GetInitials(string fullName)
    {
        var nameParts = fullName.Split(" ");//Delimiter
        var len = nameParts.Length;
        var first = nameParts[0][0];
        var last = nameParts[len - 1][0];

        var initial = $"{first}{last}";
        return initial;
    }

    // returns multiple values, take no/some arguments
    public (short, short) GetMinMax(short[] numbers)
    {
        // Imperative
        short min = short.MaxValue;
        short max = short.MinValue;

        foreach (short num in numbers)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }

        return (min, max); //tuple
    }

    public (short, short) GetMinimumMaximum(short[] numbers)
    {
        // Declarative
        short min = numbers.Min();
        short max = numbers.Max();

        return (min, max); //tuple
    }

    // variable number of arguments, named parameters, optional parameters 
    public void Test()
    {
        // Named parameters
        Add(y: 45, x: 23);

        Multiply(23.4, 56.7);
        Multiply(23.4, 56.7, 67.8);

        PrintText("Bishnu");
        PrintText("Bishnu", "Ram", "John", "Kamal");
    }

    public double Multiply(double x, double y, double z = 1)
    {
        return x * y * z;
    }

    public void PrintText(params string[] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    // Expression bodied members, inline methods
    public float Divide(float x, float y) => x / y;
    
}