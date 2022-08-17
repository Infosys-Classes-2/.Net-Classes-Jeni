//Parallel Programming concept : TPL (Task Parallel Library)
//Asynchronous Programming concept : async, await 

//1000 images- Rotate 180 degrees
using System.Threading;
using System.Threading.Tasks;
using System;
public class LearnParallel
{
    int[] numbers = {12,23,30,46,10,37};
    public void Do()
    {
        //Thread th = new Thread();
        //Task task = new Task();
        //Squential version
        Console.WriteLine("Sequential Loop:");
        foreach(var num in numbers)
        {
            var f = GetFactorial(num);
            Console.WriteLine($"{num} !={f}");
        }

          
   // Parallel version
        Console.WriteLine("Parallel Loop:");
        Parallel.ForEach(numbers, num =>
        {
            GetFactorial(num);
            Console.WriteLine($"Working for {num}");
        });


    }

private long GetFactorial(int n)
{
    Thread.Sleep(50);
    if (n==0 ||n==1)
    return 1;
    return n*GetFactorial(n-1);
}
}