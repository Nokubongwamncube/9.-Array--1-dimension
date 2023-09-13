using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Array__1_dimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 1, 2, 5, 9, 7, 8, 10, 11, 12 };

            Console.WriteLine(luckynumbers.Length);
            Console.WriteLine(luckynumbers[0]);

            string[] friends = new string[5];
            friends[0] = "Nozi";
            friends[1] = "Simo";
            friends[2] = "Fiso";

            Console.WriteLine(friends[2]);



            //frezzing console
            Console.ReadLine();

                
        }
    }
}
