using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorMateLogo
{
    class Program
    {
        //Input function and validation
        static int EnterN()
        {

            Console.WriteLine("N must be between 2 and 10 000; Must be an odd number;");
            Console.WriteLine("Enter N:");

            int n;
            bool validation;

            do
            {
                n = Int32.Parse(Console.ReadLine());

                validation = (n > 2) && (n < 10000) && (n % 2 != 0);

                if (validation == false)
                {
                    Console.WriteLine("Invalid input; Please enter again:");
                    continue;
                }


            }
            while (validation == false);

            return n;
        }

        static void Main(string[] args)
        {
            int n = EnterN();
            Logo logo = new Logo(n);
            logo.Draw();
            logo.Print();


            //Exit program
            Console.ReadKey();
        }
    }
}
