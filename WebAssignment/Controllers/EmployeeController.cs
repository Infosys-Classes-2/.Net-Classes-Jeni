using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebAssignment.Controllers
{
    public class EmployeeController : Controller
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
            List<int> listMultipleOfThree = new();
            List<int> listMultipleOfFour = new();
            List<int> listMultipleOfFive = new();

            for (int i = 0; i < numbers.Length;i++)
            {
                int value = random.Next(0, 100);
                numbers[i] = value;
                
                if(numbers[i]%3 == 0)
                {
                    listMultipleOfThree.Add(value);
                }
                if (numbers[i] % 4 == 0)
                {
                    listMultipleOfFour.Add(value);
                }
                if (numbers[i] % 5 == 0)
                {
                    listMultipleOfFive.Add(value);
                }

            }

          
          //  var retValue = ($"all numbers:[ {numbers}]\n Multiples of 3: [{listMultipleOfThree}] \n Multiples of 4: [{listMultipleOfFour}] \n Multiples of 5: [ {listMultipleOfFive}]");

            return View(numbers );
           // return ViewBag(retValue);
            

        }
            
        

    }
}
