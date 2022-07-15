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
            Console.WriteLine("For Basic Operators, enter b");
            Console.WriteLine("For Car Insurance using ternary operators, enter c");
            Console.WriteLine("For Daily Report, enter d");
            Console.WriteLine("For Income Comparison, enter i");
            Console.WriteLine("For Logical operators using if-else, enter l");
            Console.WriteLine("for Rock Paper Scissors using do-while, enter r");
            Console.WriteLine("For Shipping Express, enter s");
            char myChoice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("=============================================================");

            switch (myChoice)
            {
                case 'b':
                    basicMath();
                    break;
                case 'c':
                    carInsurance();
                    break;
                case 'd':
                    dailyReport();
                    break;
                case 'i':
                    incomeProgram();
                    break;
                case 'l':
                    logicalProgram();
                    break;
                case 'r':
                    rockPaperScissors();
                    break;
                case 's':
                    shippingExpress();
                    break;
                default:
                    Console.WriteLine("fatal error! Shutting down.");
                    Console.ReadLine();
                    break;

            }
        }

        private static void powerOn()
        {
            bool power = false;

            while (!power)
            {
                Console.WriteLine("it's off still. type \"start\" to start");
                string powerString = Console.ReadLine();
                if (powerString == "start")
                    power = true;
            }
        }

        private static void rockPaperScissors() //uses a do-while loop
        {

            powerOn(); // does a simple while loop

            byte totalGames = 3;
            byte gamesPlayed = 0;
            byte wins = 0;
            byte losses = 0;
            Random rnd = new Random();

            do
            {
                int opponentThrow = rnd.Next(4); //1 = r, 2 = p, 3 = s
                Console.WriteLine("You are playing Rock Paper Scissors. Enter r, p, or s to throw.");
                char yourThrow = Convert.ToChar(Console.ReadLine());
                gamesPlayed++;
                switch (yourThrow)
                {
                    case 'r':
                        if (opponentThrow == 1)
                        {
                            Console.WriteLine("Rock hits rock. You tie.");
                        }
                        else if (opponentThrow == 2)
                        {
                            Console.WriteLine("Paper beats your Rock. you Lose.");
                            losses++;
                        }
                        else
                        {
                            Console.WriteLine("Rock breaks scissors. You win!");
                            wins++;
                        }
                        break;
                    case 'p':
                        if (opponentThrow == 1)
                        {
                            Console.WriteLine("Paper surrounds rock. You Win!");
                            wins++;
                        }
                        else if (opponentThrow == 2)
                        {
                            Console.WriteLine("Paper hits paper. you tie.");
                        }
                        else
                        {
                            Console.WriteLine("Scissors cut paper. You Lose");
                            losses++;
                        }
                        break;
                    case 's':
                        if (opponentThrow == 1)
                        {
                            Console.WriteLine("Rock breaks scissors. You lose.");
                            losses++;
                        }
                        else if (opponentThrow == 2)
                        {
                            Console.WriteLine("Scissors cut paper. You Win.");
                            wins++;
                        }
                        else
                        {
                            Console.WriteLine("Scissors scrapes scissors. You tie.");
                        }
                        break;
                    default:
                        gamesPlayed--;
                        Console.WriteLine("Wrong symbol entered. try again.");
                        break;
                }

            } while (gamesPlayed < totalGames);

            Console.WriteLine("\n" + gamesPlayed + " Games played. Result: " + wins + " Wins " + losses + " Losses " + (gamesPlayed-wins-losses) + " Ties");
            endMessage();
        }


        private static void shippingExpress()
        {
            Console.WriteLine("Welcome to Shipping Express. Please Follow instructions to begin.");
            Console.WriteLine("Enter package weight in kg");
            byte weight = Convert.ToByte(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Too Heavy for us sorry.");
                endMessage();
                return;
            }
            Console.WriteLine("Enter Width in centimeters");
            byte width = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter length in centimeters");
            byte length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter height in centimeters");
            byte height = Convert.ToByte(Console.ReadLine());
            if (width+length+height > 50)
            {
                Console.WriteLine("Too Big for us sorry.");
                endMessage();
                return;
            }
            decimal quote = (width * length * height * weight) / 1000; //dividing  by 1000 is a little more reasonable than 100
            string quoteString = string.Format("{0:C}", quote);
            Console.WriteLine("Estimated Total is " + quoteString);
            Console.WriteLine("Thank you!");
            endMessage();
        }

        private static void logicalProgram()
        {
            //if else statements
            if (true){
                Console.WriteLine("soemthing was true");
            }
            else { }

            // !=
            Console.WriteLine("fred" != "fred");

            // >
            if(5<6 && 5 > 3)
            {
                Console.WriteLine("five is between 3 and 6 apparently");
            }
            else { }

            Console.WriteLine("What is the room temp in Fahrenheit?");
            byte currentTemp = Convert.ToByte(Console.ReadLine());

            if (currentTemp>72)
            {
                Console.WriteLine("a bit warm");
            }
            else if (currentTemp < 72)
            {
                Console.WriteLine("a bit cool");
            }
            else { Console.WriteLine("exactly room temp"); }

            endMessage();
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
            endMessage();
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


        private static void basicMath()
        {
            //basic operations O
            Console.WriteLine("Input a number to multiply by 50");
            //combined read and write onto one line:
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 50);
            Console.WriteLine("Input a number to add to 25");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 25);
            Console.WriteLine("Input a number to divide by 12.5");
            Console.WriteLine(Convert.ToDecimal(Console.ReadLine()) / 12.5m);
            Console.WriteLine("Input a number to check if greater than 50");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) > 50);
            Console.WriteLine("Input a number to divide by 7 and print remainder");
            Console.WriteLine(Convert.ToDecimal(Console.ReadLine()) % 7);
            endMessage();
        }

            ////Some math M
            //Console.WriteLine("6 + 2 = " + (6 + 2));
            //Console.WriteLine("6 - 2 = " + (6 - 2));
            //Console.WriteLine("6 x 2 = " + (6 * 2));
            //Console.WriteLine("6 / 2 = " + (6 / 2));
            //int product = 10 * 5;
            //Console.WriteLine(product);

            private static void dailyReport()
        {
            //DAILY REPORT PROMPTS D
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Enter Name:");
            string yourName = Console.ReadLine();
            Console.WriteLine("Enter Current Course");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Enter Page Number:");
            int yourPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Enter true or false");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Any positives you'd like to share?");
            string yourWins = Console.ReadLine();
            Console.WriteLine("Anything else?");
            string yourDetails = Console.ReadLine();
            Console.WriteLine("Hours studied today:");
            byte yourHours = Convert.ToByte(Console.ReadLine());
        }

            ////end of program message
            //Console.WriteLine("\r Thank You for your answers. An instructor will respond shortly.");
            //Console.ReadLine();



        private static void endMessage()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Hit enter to close this window.");
            Console.ReadLine();
        }

        } //end class Program
}
