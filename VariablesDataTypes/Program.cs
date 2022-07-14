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

            //end of program message
            Console.WriteLine("\r Thank You for your answers. An instructor will respond shortly.");
            Console.ReadLine();


        }
    }
}
