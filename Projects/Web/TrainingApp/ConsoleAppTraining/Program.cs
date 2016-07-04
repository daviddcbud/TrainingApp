using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTraining
{
    class Program
    {

       static  string GetFullName(string first, string last)
        {
            return first + " " + last;
        }

        static void Main(string[] args)
        {

            var fullName = GetFullName("david", "freeman");
            Console.WriteLine("your full name is {0}", fullName.ToUpper());

            var names = new List<string>();
            names.Add("david");
            names.Add("jason");
            //Comments are a good way to explain the code to others
            Console.WriteLine("Name count is {0}", names.Count);
            foreach(var n in names)
            {
                Console.WriteLine(n);
                if (n == "jason")
                {
                    Console.WriteLine("that is my brother");
                }
                 
            }

            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine(string.Format("Hello {0}", name));

            Console.WriteLine("Press Enter to Quit..");
            Console.ReadLine();
        }
    }
}
