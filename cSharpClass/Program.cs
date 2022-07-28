// See https://aka.ms/new-console-template for more information
using System;
//Program to capitalize entered text.
/*Console.Write("Write any text to change in upper:");
string Name = Console.ReadLine();
string outCapName =Name.ToUpper();
Console.WriteLine($"Converted output is: , {outCapName}");

//Program to convert meter to feet. Output: n metre = m feet
Console.Write("Enter data in Meter: ");
string valMeter = Console.ReadLine();
double valFeet = double.Parse(valMeter) * 3.2808399;
Console.WriteLine($"Converted output is:  {valFeet}");
*/

//Program to calculate area of circle.

Console.WriteLine("Enter the value of radius:");
int radius = Convert.ToInt32(Console.ReadLine());
double area = (3.14) * radius * radius;
Console.WriteLine($"The Area of circle =  {area}");

//Program to convert days to years, months, weeks and days.

Console.WriteLine("Enter Days:");
double days = short.Parse(Console.ReadLine());
var years = Math.Truncate(days / 365);
var months = Math.Truncate((days % 365) / 30);
var weeks = Math.Truncate(((days % 365) % 30)/7);
var remainingDays = Math.Truncate(((days % 365) % 30)%7);
Console.WriteLine($"Days  {days} = {years} year, {months} months, {weeks} weeks & {remainingDays} days");

