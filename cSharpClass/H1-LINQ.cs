//Language Integrated Query (LINQ)
using System.Linq;
using System;

public class LINQ
{
    int[] numbers = {34,6,12,45,45,45,57,25,24,36};
    public void LearnLINQ()
    {
        // 1. Fetch all even numbers on numbers array --imperative way
        // List<int> evenNumbers = new();
    
        // foreach (var i in numbers)
        // {
        //      if (i%2 == 0) 
        //     evenNumbers.Add(i);
        // }

        //Method Syntax
        // var evenNumbers = numbers.Where(n=>n%2==0); 
        // //ie equivalent to following called Expression Syntax
        // evenNumbers = from n in numbers
        // where n%2 ==0 
        // select n;
        // Console.Write($"Even Numbers :{evenNumbers}");

        //2. Fetch all odd numbers from numbers'
        var oddNumber = numbers.Where(n=>n%2!=0);

        //3. Fetch all perfect square from numbers
        foreach (var i in numbers)
        var perfectSqaures = numbers.Where(x => IsPerfectSquare(x)); // as the expression only passes true result expresssion 

        //4. Convert all numbers in "numbers" to their cubes
        var cubes = numbers.Select(x=>x*x*x);

        //5.Get Squares of all even numbers in "numbers"
        var evenNumbers = numbers.Where(n=>n%2==0); 
        foreach(var x in evenNumbers)
        {
            var squares =  x*x;
        }
    }
        private bool IsPerfectSquare(int n)
        {
            var sr =Math.Sqrt(n);
            var product= sr*sr;
            return product ==n; //as return type is bool

        }




    
}