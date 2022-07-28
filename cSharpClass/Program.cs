// See https://aka.ms/new-console-template for more information
using System;
//convert given 
Console.Write("Write any text to change in upper:");
string Name = Console.ReadLine();
string outCapName =Name.ToUpper();
Console.WriteLine($"Converted output is: , {outCapName}");

Console.Write("Enter data in Meter: ");
string valMeter = Console.ReadLine();
double valFeet = Int32.Parse(valMeter) * 3.2808399;
Console.WriteLine($"Converted output is:  {valFeet}");



