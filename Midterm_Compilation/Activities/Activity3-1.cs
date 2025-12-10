using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Compilation.Activities
{
    public static class Activity3_1
    {
        public static void Run()
        {
            List<int> number = new List<int>();

            string directions = "(Sir Professor voice) Make a list variable. use the add method, " +
                "display elements of said list. Use count method too.\n\n";
            Console.WriteLine(directions);

            number.Add(11);
            number.Add(22);
            number.Add(33);

            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.ReadKey();
        }
    }
}
