using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first altitude in feets:");
            int alt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second altitude:");
            int alt2 = int.Parse(Console.ReadLine());
            int altDif = alt2 - alt1;
            Console.WriteLine(altDif + " Feet");
            Console.ReadLine();

        }
    }
}
