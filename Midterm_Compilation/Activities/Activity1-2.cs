using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Compilation.Activities
{
    public static class Activity1_2
    {
        public static void Run()
        {
            {
                string[] aStringsArray = new string[20];

                string directions = "(Sir Professor voice) Using arrays, accept 20 inputs of names of students. " +
                    "Afterwards, display said names.\n" +
                    "You can use loops now, I'm not a sadist. \n\n";
                Console.WriteLine(directions);

                for (int i = 0; i < aStringsArray.Length; i++)
                {

                    Console.Write($"Enter student {i+1} name: ");
                    aStringsArray[i] = Convert.ToString(Console.ReadLine());
                }


                for (int i = 0; i < aStringsArray.Length; i++)
                {
                    Console.WriteLine($"Student {i + 1} name: {aStringsArray[i]}");
                }
            }
        }
    }
}
