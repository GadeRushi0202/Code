using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Condition
{
    internal class First
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 18)
            {
                Console.WriteLine("Vote");
            }
            else
            {
                Console.WriteLine("Not Vot");
            }
        }
    }
}
