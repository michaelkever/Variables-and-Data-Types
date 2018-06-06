using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
           // simple program..

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page Number?");
            string pageNumber = Console.ReadLine();
           
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string helpWith = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences? Please give specifics.");
            string specifics1 = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string specifics2 = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string studyHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();










        }
    }
}
