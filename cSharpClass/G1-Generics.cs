//passing Type as a Parameter is Generics
using System;
public class Generic
{
    public void Print<T>(T x)  // here <T> is type used to denote generic type parameter
    {
        Console.WriteLine(x);
    }
}

class Test4
{
    void Test()
    {
        Generic g = new();
        g.Print<String>("hello");
        g.Print<float>(2344.23f);
        g.Print<int>(3333);
        g.Print<bool>(true);
    }
}