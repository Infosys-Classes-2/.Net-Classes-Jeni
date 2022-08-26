using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebAssignment.Controllers;

public class WebTestController : Controller
{
    public IActionResult ShowList()
    {
        return View();
    }

    public IActionResult ShowImage()
    {
        return View();
    }

    public IActionResult TableOfFive()
    {
        return View();
    }

    public IActionResult TableOfGivenNumber(int intVal)
    {
        return View(intVal);
        
    }

    public IActionResult ArrayList()
    {
        Random random = new ();
        int[] numbers = new int[40];
       

        for (int i = 0; i < numbers.Length;i++)
        {
            int value = random.Next(0, 100);
            numbers[i] = value;                
          
        }

      
      //  var retValue = ($"all numbers:[ {numbers}]\n Multiples of 3: [{listMultipleOfThree}] \n Multiples of 4: [{listMultipleOfFour}] \n Multiples of 5: [ {listMultipleOfFive}]");

        return View(numbers );
       // return ViewBag(retValue);
        

    }
        
    

}
