using System;

public class MethodLearning
{
    // returns nothing, take no arguments
    public void PrintNepal()
    {
        Console.WriteLine("Nepal");
    }
    // returns nothing, take some arguments
    public void PrintNepalNTimes(int n)
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

    // input- Bishnu Singh sdfasfd Rawal, output - BR
    public string GetInitials(string fullName)
    {
        var nameParts = fullName.Split(" "); //delimeter
        var len = nameParts.Length;
        var first = nameParts[0][0]; //as string is also a kind of string array we can use indexing on string values
        var last = nameParts[len - 1][0];

        var initial = $"{first}{last}";
        return initial;
    }

    // returns multiple values, take no/some arguments
    public (short,short) GetMinMax(short[] numbers)
    {
        short min =short.MaxValue, max=short.MinValue;
        foreach(short num in numbers)
        {
            if (num < min)
                min = num;
            if(num>max)
                max=num;
        }
        return (min,max);  //tuple of 2 variales we can use any no of variables in tuples of variables
    }

    
    // 1. Write a function to return min, max and average of given array of numbers. Hint GetMinMax() 
    public (short,short,float) GetMinMaxAvg(short[] numbers)
    {
        short min =short.MaxValue, max=short.MinValue;
        float sum =0;
        int len = numbers.Length;
        foreach(short num in numbers)
        {
            if (num < min)
                min = num;
            if(num>max)
                max=num;
            sum = sum + num ;
        }
        return (min,max, sum/len);  //tuple of 2 variales we can use any no of variables in tuples of variables
    }


    // variable number of arguments, named parameters, optional parameters 

}