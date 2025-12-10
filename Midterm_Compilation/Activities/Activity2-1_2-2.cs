using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Compilation.Activities
{
    public static class Activity2_1_2_2
    {
        struct Student
        {
            public string name, section, address, birthday;
            public int age;
            public double grade;

            public Student(string _name, int _age, double _grade, string _section, string _address, string _birthday)
            {
                name = _name;
                age = _age;
                grade = _grade;
                section = _section;
                address = _address;
                birthday = _birthday;
            }

            public void print()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Grade: " + grade);
                Console.WriteLine("Section: " + section);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("Birthday: " + birthday);
            }
        }

        private static void mainMenu()
        {
            Console.Clear();
            Console.WriteLine("===Student Management System===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
        }

        public static void Run()
        {
            int currentCount = 0, capacity, choice;
            bool runProgram = true;

            string directions = "(Sir Professor voice) Use struct, whatever.\n " +
                "Okay, fine. Activity 2.1 - showcase fundamental understanding of data structure " +
                "known as structure (aka records) and manually assign values to members (aka fields). " +
                "I'm only requiring three members at this time.\n" +
                "Activity 2.2 - add more members for a total of 6, prompt the user for student capacity, " +
                "then display a menu" +
                "where user can choose to add students or display students. If the user tries " +
                "to add students when maximum capacity is reached, display an error message.\n\n";
            Console.WriteLine(directions);

            Student S1 = new Student();
            S1.name = "Lila";
            S1.age = 20;
            S1.grade = 1.002;

            S1.print();
            Console.Write("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=======Enter maximum number of students: =======");
            capacity = int.Parse(Console.ReadLine());
            Student[] studentList = new Student[capacity];

            while (runProgram == true)
            {
                mainMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (currentCount >= capacity)
                        {
                            Console.Clear();
                            Console.WriteLine("Cannot add more students. Limit reached.");
                            Console.ReadKey();
                            break;
                        }

                        Console.Clear();

                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Enter grade: ");
                        double grade = double.Parse(Console.ReadLine());

                        Console.Write("Enter section: ");
                        string section = Console.ReadLine();

                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter birthday: ");
                        string birthday = Console.ReadLine();

                        studentList[currentCount] = new Student(name, age, grade, section, address, birthday);
                        currentCount++;

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("====Student List====");
                        for (int i = 0; i < currentCount; i++)
                        {
                            Console.WriteLine("Student #" + (i + 1) + ": ");
                            studentList[i].print();
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        runProgram = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error. Invalid choice.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
