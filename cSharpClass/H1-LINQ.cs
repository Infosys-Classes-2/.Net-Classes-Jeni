//Language Integrated Query (LINQ)
using System.Linq;
using System.Collections.Generic;
using System;

public class LINQ
{
    int[] numbers = {34,6,12,45,45,45,57,25,24,36};
    List<string> names = new List<string> {"Ram", "Shayam", "jeni","tina","rina"};
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
        //foreach (var i in numbers)
       // var perfectSqaures = numbers.Where(x => IsPerfectSquare(x)); // as the expression only passes true result expresssion 

        //4. Convert all numbers in "numbers" to their cubes
        //var cubes = numbers.Select(x=>x*x*x);

        //5.Get Squares of all even numbers in "numbers"
        //var evenNumbers = numbers.Where(n=>n%2==0); 
        // foreach(var x in evenNumbers)
        // {
        //     var squaresEvenNumbers =  x*x;
        // }
        
        var squaresEvenNumbers = numbers.Where(x=>(x&1)==0).Select(y=>y*y); //bitwise operator to check even number this is the fastest approach

        //binary value ko last ma 1 bhayo bhane alwayes odd number and 0 cha bhane always even
        //var t = 2&1;
        //010 & 001 == 000 =0  so used for even (010 is 1 in decimal)
        //011 & 1==001 != 0 so used for odd (011 is 3 in decimal)

        //6.Get first five items
        var firstFive = numbers.Take(5);

        //6.1 Get next five items skipping first two
                                                                                                                                                          

        //7. Check whether all items in numbers link is even or not (it's known as Quantifiers)
        var checkAllEvens = numbers.All(x=> (x&1)==0);
        var checkAnyEvens = numbers.Any(x=> (x&1)==0);
        
        //8. Get all names starting with letter 'a'
        //var namesStartingA = names.where(x=> x.startWith('A') ||x.startWith('a')) ;
        // or more efficient way
        var namesStartingA = names.Where(x=>x.ToUpper().StartsWith('A'));

        //9.Get all names on "names" with lenght greater than 5 characters
        var namesWithLength = names.Where(x=> x.Length>5);
        

    }
        private bool IsPerfectSquare(int n)
        {
            var sr =Math.Sqrt(n);
            var product= sr*sr;
            return product ==n; //as return type is bool

        }




    
}