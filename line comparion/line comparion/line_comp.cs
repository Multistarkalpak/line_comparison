using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class cartesion
    {
        public void calc_distance()
        {
            Console.WriteLine("Enter the Co-ordinates of 1st Line");
            Console.WriteLine("Enter the 1st Co-ordinate of the 1st Line");
            Console.Write("Enter Value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Co-ordinate of the 1st Line");
            Console.Write("Enter Value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        }
    }

}





