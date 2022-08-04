using System;
internal class BranchesAndLoops
{
    //branches and loops should be used inside function
    internal void learnBranching() //folding and unfolding
    {
        //if-else
        // var isHuman = true;
        // if (2+4 ==8 && 9*7 ==89 || isHuman)    //&& logical and , & : bitwise and 
        // {
        //     Console.WriteLine("I am human and can calculate 2+2.");
        // }
        // else
        // {
        //     Console.WriteLine("I am robot and don't know what 2+2 is.");
        // }

    // if-elseif-else
        // Console.Write("Enter Number:");
        // var text = Console.ReadLine();
        // var number = short.Parse(text);

        // if (number==0)
        // {
        //     Console.WriteLine("You entered Zero.");
        // }
        // else if (number < 0 )
        // {
        //     Console.WriteLine("You entered negative Number.");
        // }
        // else
        // {
        //     Console.WriteLine("You entered +ve Number.");
        // }

    //switch    
    // var today = (int) DateTime.Now.DayOfWeek;  //(int) is called casting which converts the value into integer
    // switch(today)
    // {
    //     case 0: Console.WriteLine("today is Sunday");
    //     break;
    //     case 1: Console.WriteLine("today is Monday");
    //     break;
    //     case 2: Console.WriteLine("today is Tuesday");
    //     break;
    //     case 3: Console.WriteLine("today is Wednesday");
    //     break;
    //     case 4: Console.WriteLine("today is Thursday");
    //     break;
    //     case 5: Console.WriteLine("today is Friday");
    //     break;
    //     case 6: Console.WriteLine("today is Saturday");
    //     break;

    // }

//another way (better one)
    var today = DateTime.Now.DayOfWeek;  
    switch(today)
    {
        case DayOfWeek.Sunday: 
        Console.WriteLine("today is Sunday");
        break;
        case DayOfWeek.Monday: 
        Console.WriteLine("today is Monday");
        break;
        case DayOfWeek.Tuesday: 
        Console.WriteLine("today is Tuesday");
        break;
        case DayOfWeek.Wednesday: 
        Console.WriteLine("today is Wednesday");
        break;
        case DayOfWeek.Thursday: 
        Console.WriteLine("today is Thursday");
        break;
        case DayOfWeek.Friday: 
        Console.WriteLine("today is Friday");
        break;
        case DayOfWeek.Saturday: 
        Console.WriteLine("today is Saturday");
        break;

    }

//switch (use for Descrete values ie distinct values)
//if else (use for continuous values)
    }
internal void LearnLooping()
{
    //for -is used if no of iteration is unkown
    for (short  i =1 ; i <= 500; i++)
    {      
        Console.WriteLine(i);
    }
    //while  - is used if no of iteration is unkown 
    // ConsoleKey keyInfo;
    // while(keyInfo.key !=ConsoleKey.Escape)
    // {
        
    // }
    // //do-while


    // //foreach
    // byte{} AttributeTargets =
}
}
