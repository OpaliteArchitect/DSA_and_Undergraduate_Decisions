using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Compilation.Activities
{
    public static class Activity3_2
    {
        public static void Run()
        {
            //user inputs capacity of list
            //user inputs content of list
            //program displays list

            string directions = @"(Sir Professor voice) 
//user inputs capacity of list
//user inputs content of list
//program displays list" + "\n\n";
            Console.WriteLine(directions);

            List<string> inputList = new List<string>();
            int capacity = 0;
            Console.Write("Enter amount of inputs: ");
            capacity = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < capacity; i++)
            {
                Console.Write("Add input#" + (i + 1) + ": ");
                inputList.Add(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("List contents: ");
            Console.WriteLine("===============");

            for (int i = 0; i < capacity; i++)
            {
                Console.WriteLine("Input #" + (i + 1) + ": " + inputList[i]);
            }

            Console.ReadKey();
        }
    }
}
