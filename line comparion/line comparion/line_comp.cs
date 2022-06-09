using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Check_Equality
    {
        public static void get_equality()
        {
            Console.WriteLine("Enter the Co-ordinates of 2nd Line");
            Console.WriteLine("Enter the 1st Co-ordinate of the 2nd Line");
            Console.Write("Enter Value of x3 : ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value of y3 : ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Co-ordinate of The 2nd Line");
            Console.Write("Enter value of x4 : ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y4 : ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
        }

    }
}
