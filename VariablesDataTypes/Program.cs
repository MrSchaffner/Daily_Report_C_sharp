using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //income program
            Console.WriteLine("income comparison program");
            Console.WriteLine("person 1 details:");
            Console.WriteLine("enter hourly income:");
            string person1Rate = Console.ReadLine();
            Console.WriteLine("enter hours worked per week:");
            string person1Hours = Console.ReadLine(); 
            decimal person1Salary = Convert.ToDecimal(person1Hours) * Convert.ToDecimal(person1Rate);
            //person 2
            Console.WriteLine("person 2 details:");
            Console.WriteLine("enter hourly income:");
            string person2Rate = Console.ReadLine();
            Console.WriteLine("enter hours worked per week:");
            string person2Hours = Console.ReadLine();
            decimal person2Salary = Convert.ToDecimal(person2Hours) * Convert.ToDecimal(person2Rate);
            //
            Console.WriteLine("Press Enter to view results");
            Console.ReadLine(); // waits for enter key
            Console.WriteLine("Person 1 Salary: " + person1Salary);
            Console.WriteLine("Person 2 Salary: " + person2Salary);
            //end of program
            Console.WriteLine((person1Salary>person2Salary ? "First Person" : "Second Person") + " Makes More.");
            Console.ReadLine();



            ////basic operations
            //Console.WriteLine("Input a number to multiply by 50");
            ////combined read and write onto one line:
            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 50);
            //Console.WriteLine("Input a number to add to 25");
            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 25);
            //Console.WriteLine("Input a number to divide by 12.5");
            //Console.WriteLine(Convert.ToDecimal(Console.ReadLine()) / 12.5m);
            //Console.WriteLine("Input a number to check if greater than 50");
            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()) > 50);
            //Console.WriteLine("Input a number to divide by 7 and print remainder");
            //Console.WriteLine(Convert.ToDecimal(Console.ReadLine()) % 7);
            ////end of program
            //Console.WriteLine("thats all");
            //Console.ReadLine();

            ////Some math
            //Console.WriteLine("6 + 2 = " + (6 + 2));
            //Console.WriteLine("6 - 2 = " + (6 - 2));
            //Console.WriteLine("6 x 2 = " + (6 * 2));
            //Console.WriteLine("6 / 2 = " + (6 / 2));
            //int product = 10 * 5;
            //Console.WriteLine(product);


            ////DAILY REPORT PROMPTS
            //Console.WriteLine("The Tech Academy");
            //Console.WriteLine("Student Daily Report");
            //Console.WriteLine("Enter Name:");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Enter Current Course");
            //string yourCourse = Console.ReadLine();
            //Console.WriteLine("Enter Page Number:");
            //int yourPage = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Do you need help with anything? Enter true or false");
            //bool needHelp = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Any positives you'd like to share?");
            //string yourWins = Console.ReadLine();
            //Console.WriteLine("Anything else?");
            //string yourDetails = Console.ReadLine();
            //Console.WriteLine("Hours studied today:");
            //byte yourHours = Convert.ToByte(Console.ReadLine());

            ////end of program message
            //Console.WriteLine("\r Thank You for your answers. An instructor will respond shortly.");
            //Console.ReadLine();


        }
    }
}
