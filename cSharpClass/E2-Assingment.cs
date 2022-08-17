using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


public class Assignment
{
    List<string> folderNames = new List<string> {"Assignment1", "Assignment2", "Assignment3","Assignment4","Assignment5"};
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

    //Write a C# program to create 10 folders, in each folder a text should be created with its meta information as content.
    public void CreateFileFolder()
    {        
        for (int i=1; i<=10; i++)
        {
           Directory.CreateDirectory(@"D:\dotnet\Dir"+i) ;
           string filePath = @"D:\dotnet\Dir"+i+ "\\test"+i+".txt";        
            
           FileInfo fi = new(filePath);

           string info = $"Created Date: {fi.CreationTime} \n Last Modified Date :{fi.LastWriteTime}\n Size : {(float)fi.Length/1024}kb \n File Type: {fi.Extension}";
           //or use multiline
        //    string info = $"Created Date: {fi.CreationTime} \n "+
        //   $"Last Modified Date :{fi.LastWriteTime}\n "+
        //    $"Size : {(float)fi.Length/1024}kb \n "+
        //    $"File Type: {fi.Extension}";
           File.WriteAllText(filePath,info);
                 
        }
    }

    //Write a program to list all files/folders in a folder in following format
    //File/Folder Name    created Date size  IsFile
    //dir1      2022-12-05  0.23 kb  N

    public void displayFileFolder()
    {
        string folderPath = @"D:\store";

        var files = Directory.EnumerateFiles(folderPath);
        var folders = Directory.EnumerateDirectories(folderPath);

        string infoTable= "File/Folder Name \t\t Created Date\t\t Size\t\tIsFile\n";

        foreach(var file in files)
        {
            FileInfo fi=new(file);
            var fileInfo = $"{fi.Name}\t\t{fi.CreationTime}\t\t{GetFileSize(fi.Length)}\t\t True\n";
            infoTable += fileInfo;
            //or infoTable =inforTable+ fileInfo;
        }

        foreach(var folder in folders)
        {
            DirectoryInfo di = new DirectoryInfo(folder);
            var fileInfo = $"{di.Name}\t\t{di.CreationTime}\t\t Null \t\t False\n";
            infoTable += fileInfo;            
        }

        Console.WriteLine(infoTable);
       
    }

    string GetFileSize(long lenInBytes)
    {
        var lenInKB = (float)lenInBytes/1024;
        if (lenInKB>1024)
        {
            var lenInMB = lenInKB/1024;
            if(lenInMB>1024)
            {
                var lenInGB = lenInMB/1024;
                 return $"{lenInGB} GB";
            }
            else
                return  $"{lenInMB} MB";
        }
        else
         return $"{lenInKB} KB";
        
    }
}




 