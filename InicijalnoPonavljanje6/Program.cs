using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Unesi broj članova reda: ");
            int brojClanova = Convert.ToInt32(Console.ReadLine());

            while (i <= brojClanova)
            {
                Console.Write(" + 1/" + Math.Pow(3, i));
                i++;
            }

            Console.ReadKey();
        }
    }
}
