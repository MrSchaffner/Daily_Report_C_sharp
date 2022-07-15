using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Which program would you like to Run:");
            Console.WriteLine("For Car Insurance, enter c");
            Console.WriteLine("For Income Comparison, enter i");
            char myChoice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("=============================================================");

            switch (myChoice)
            {
                case 'c':
                    carInsurance();
                    break;
                case 'i':
                    incomeProgram();
                    break;
                default:
                    Console.WriteLine("fatal error! Shutting down.");
                    Console.ReadLine();
                    break;

            }
        }


        private static void carInsurance() {

            //car insurance approval
            Console.WriteLine("We will ask a few questions to determine your eligibility for our Premier Program. hit enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Enter age");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("You have DUIs on you record? Enter true or false");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many moving violations in the last 5 years?");
            byte tickets = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Hit enter to see if you qualify");
            Console.ReadLine();
            Console.WriteLine(age > 15 && !dui && tickets <= 3 ? "You Qualify! An Agent has been assigned and will call you in shortly." : "I'm sorry. This isn't a good fit. Try Progressive or something. They'll take anyone.");
            Console.WriteLine("Hit enter to close this window.");
            Console.ReadLine();
        }

        ////boolean
        //bool t = true;
        //bool f = false;
        //Console.WriteLine(t&&t);
        //Console.WriteLine(t||f);
        //Console.WriteLine(t==t);
        //Console.WriteLine(t!=f);
        //Console.ReadLine();

        private static void incomeProgram()
        {
            //income program  S
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
            Console.WriteLine((person1Salary > person2Salary ? "First Person" : "Second Person") + " Makes More. Press Enter to close this window.");
            Console.ReadLine();
        }


            ////basic operations O
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

            ////Some math M
            //Console.WriteLine("6 + 2 = " + (6 + 2));
            //Console.WriteLine("6 - 2 = " + (6 - 2));
            //Console.WriteLine("6 x 2 = " + (6 * 2));
            //Console.WriteLine("6 / 2 = " + (6 / 2));
            //int product = 10 * 5;
            //Console.WriteLine(product);


            ////DAILY REPORT PROMPTS D
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



        } //end class Program
}
