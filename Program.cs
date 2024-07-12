using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pie = 3.14;
            int radius;
            Console.WriteLine("Enter the value of radius");
            radius=Convert.ToInt32(Console.ReadLine());
            double result = 2 * pie * radius;
            Console.WriteLine("The circumference of given radius of a circle is "+result);

        }
    }
}
