using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_in_Learning_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var UserName = Console.ReadLine();

            Console.WriteLine("Please enter your Age " + UserName);
            var  Userage = Console.ReadLine();

            Console.WriteLine("Please enter the month you where born " + UserName);
            var UserMOB = Console.ReadLine();

           Console.WriteLine("Your name is {0}, You where born the month of {2}, and you are {1} years old.", UserName, Userage, UserMOB  );
            Console.ReadLine();
        }
    }
}
