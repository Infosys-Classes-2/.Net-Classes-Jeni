using System;
public class Assignment
{
//Function to Calculate Area of Circle
public string GetAreaOfCircle(double radius)
{
   double area = (3.14) * radius * radius; 
   return ($"Area of Circle is {area}");
}


//Function to convert days to years, months, weeks and days.
public string ConvertDaysToYearMonthWeekDays(double days)
{
   var years = Math.Truncate(days / 365);
   var months = Math.Truncate((days % 365) / 30);
   var weeks = Math.Truncate(((days % 365) % 30)/7);
   var remainingDays = Math.Truncate(((days % 365) % 30)%7);

   return ($"Days  {days} = {years} year, {months} months, {weeks} weeks & {remainingDays} days");
}
//function to print prime number <500

public void PrintPrimeNumber()
{
    Console.Write("Prime Numbers <500 are:");
   for(int num = 1;num<=500;num++)
       {
         int ctr = 0;

         for(int i =2;i<=num/2;i++)
            {
             if(num%i==0)
             {
                 ctr++;
                 break;
             }
            }
        
         if(ctr==0 && num!= 1)
             Console.Write($"{num},");
         }    
         Console.Write("\n\n");
}

 // Print pattens
    public void PrintPattern()
    {
        int rows = 10;
        for (int i = 1; i <= rows; i++)
        {
            for(int j = rows -1; j >= i; j--)
            {                
                Console.Write(" ");
            }

            for(int j = 1; j <= 2 * i - 1; j++)
            {                
                Console.Write("*");
            }
            Console.WriteLine();            
        }
    }

public void PrintData (string inputValue)
{
    Console.WriteLine(inputValue);
}
}
