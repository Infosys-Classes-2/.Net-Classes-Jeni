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

//Write a C# program to calculate product of digits of a number
public int GetProduct (int number)
{
    int  Reminder, Product=1;
   while (number !=0)
   {
      Reminder=number%10;
      number = number /10;
      Product = Product * Reminder;
   }
   return Product;
}

//Write a C# function to display the nth Fibonacci number.

internal int GetNthFFbonacciNumber(int n)
{
 //base case
 if(n==1)
     return 0;
 if (n==2)
    return 1;   //instead of this 4 line code we can use following

//KISS
if (n<=2)
    return n-1;

    return GetNthFFbonacciNumber(n-1)+GetNthFFbonacciNumber(n-2);

   }

   internal int GetNthFibonacciIterative(int n)
   {
       int [] series = new int[n];
       series[0] =0;
       series[1] =1;
 
    for (int i =2; i<n; i++)
    {
        series[i] = series[i-1] + series[i-2];
    }

    return series[n-1];
            
   }

   //Write a C# program to print binary equivalent of an integer.

  static string GetIntBinaryString(int n)
    {
        char[] b = new char[32];
        int pos = 31;
        int i = 0;
        
        while (i < 32)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }

//Write a C# program to print binary equivalent of an integer
public string DecimalToBinary(int decimalNumber)
    {
            int remainder;
            string result =" ";
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            return result;
       
    }
}




 