using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Compilation.Activities
{
    internal class Activity1_3
    {
        public static void Run()
        {
            {
                string[] aStringsArray = new string[20];

                string directions = "(Sir Professor voice) Do what you did in Activity 1.2, except this time, " +
                    "display odd-numbered students' names first, then even.\n\n";
                Console.WriteLine(directions);

                for (int i = 0; i < aStringsArray.Length; i++)
                {

                    Console.Write($"Enter student {i+1} name: ");
                    aStringsArray[i] = Convert.ToString(Console.ReadLine());
                }


                for (int i = 1; i < aStringsArray.Length; i+=2)
                {
                    Console.WriteLine($"Student {i + 1} name: {aStringsArray[i]}");
                }

                for (int i = 0; i < aStringsArray.Length; i += 2)
                {
                    Console.WriteLine($"Student {i + 1} name: {aStringsArray[i]}");
                }
            }
        }
    }
}
