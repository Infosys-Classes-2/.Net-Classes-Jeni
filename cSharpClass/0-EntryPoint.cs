using System;
class TestClasses
{
    public static void Main()
    {
        // Animal cow = new Animal();// old version
        // Animal goat = new ();  //new versionls
        // var buffalo = new Animal(); // if declared as var
        // Animal deer = new Animal();
        // Animal fish = new Animal();
        // Animal bear = new Animal();

        // cow.weight =325.4f;
        // cow.type = "Herbivorous animal cow";
        // cow.PrintDetails();

        // BranchesAndLoops br = new();
        // br.learnBranching();
        // br.LearnLooping();

        // Assignment2 assignment2 = new();
        // assignment2.PrintPattern();
        //squiggle the term used while code shows error line
        //  MethodLearning ml = new();
        // ml.PrintNepal();
        // ml.PrintNepalNTimes(10);
        // var x = ml.GetInitials("Milan sfafsdf Dhakal");
        // Console.WriteLine(x);

        // short[] numbers = {45,25,26,28,65,48,82,-12,-20,-1,0}; //numbers varible name is not same as declared in class methods as it's in another class
        //var (min,max) = ml.GetMinMax(numbers);
        // var (min,max,avg) = ml.GetMinMaxAvg(numbers);
        // Console.WriteLine($"Minimum: {min}, Maximum :{max} and Average Value : {avg}");

        //=> lamda operator or arrow operator , termed as goes to

        //Shape2D shape = new();
        //shape.name = "Rectangle";
        // Shape2D shape = new("Rectangle");
        // shape.PrintDetail();

        Assignment assignment =new();
        // string areaOfCircle = assignment.GetAreaOfCircle(5);
        // string convertedValue = assignment.ConvertDaysToYearMonthWeekDays(921);

        // assignment.PrintData(Convert.ToString(areaOfCircle));
        // assignment.PrintData(convertedValue);
        // assignment.PrintPrimeNumber();
        // assignment.PrintPattern();

        //VehicleCategory vehicleType = new();
        //bool status = vehicleType.CheckFuel(20);
        
        // int result = assignment.GetProduct(254);
        // Console.WriteLine($"the product of digit is {result}");

        // var y= assignment.GetNthFibonacciIterative(45);
        // Console.WriteLine("iterative version " +y);

        // var x = assignment.GetNthFFbonacciNumber(45);
        // Console.WriteLine("Recorsive version " + x);  //takes more time than interative method

        // var x= assignment.DecimalToBinary(10);
        // Console.WriteLine($"binary converted no is {0}: {x}");

        // LINQ l =new();
        // l.LearnLINQ();

        //LearnParallel lp = new();
        // lp.Do();
         
        // FileIO fileIO =new();
        // fileIO.Do();

       // assignment.CreateFileFolder();
       assignment.displayFileFolder();
        
    }
}