using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: "); //displays text asking for user input
            int num1 = Convert.ToInt32(Console.ReadLine()); //converts user input into an integer variable

            Console.Write("Please enter a number: "); //displays text asking for user input
            int num2 = Convert.ToInt32(Console.ReadLine()); //converts user input into an integer variable

            Console.Write("Please enter a number: "); //displays text asking for user input
            int num3 = Convert.ToInt32(Console.ReadLine()); //converts user input into an integer variable

            if (num1 > num2 && num1 > num3) //if statement to determine if num1 is greater than both num2 and num3
            {
                Console.WriteLine("The largest number is: " +  num1); // text displayed if if statement condition is true
            }
            else if (num2 > num1 && num2 > num3) //else if statement to determine if num2 is greater than both num1 and num3
            {
                Console.WriteLine("The largest number is: " + num2); // text displayed if else if statement condition is true
            }
            else //else statement that is executed if num3 is greater than both num1 and num2
            {
                Console.WriteLine("The largest number is: " + num3);  // text displayed if else statement condition is true
            }

            Console.Read(); //lets user read program
        }
    }
}
