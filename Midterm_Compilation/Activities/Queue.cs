using System.Text;
using static Midterm_Compilation.PolishUI;

namespace Midterm_Compilation.Activities
{

    public static class Queue
    {
        static int head = -1;
        static int tail = -1;
        static string[] queue = new string[5];

        public static void Run()
        {
            while (true)
            {
                DisplayMainMenu();

                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                } while (key.KeyChar < '1' || key.KeyChar > '9');

                Console.Clear();

                switch (key.KeyChar)
                {
                    case '1':
                        string entry = GetInputInBox("Enter new entry:          ");
                        DisplayInBox(Append(entry));
                        break;
                    case '2':
                        DisplayInBox(Serve());
                        break;
                    case '3':
                        DisplayInBox(Peek());
                        break;
                    case '4':
                        DisplayInBox(Display());
                        break;
                    case '5':
                        DisplayInBox(Count());
                        break;
                    case '6':
                        DisplayInBox(GetIsEmptyStatus());
                        break;
                    case '7':
                        DisplayInBox(GetIsFullStatus());
                        break;
                    case '8':
                        DisplayInBox(Clear());
                        break;
                    case '9':
                        return;
                    default:
                        break;
                }

                Console.ReadKey();
            }
        }

        static void DisplayMainMenu()
        {
            Console.Clear();

            const int menuWidth = 40;
            const int menuHeight = 13;
            int leftPadding = (windowsWidth - menuWidth) / 2;
            int topPadding = (windowsHeight - menuHeight) / 2;

            DrawBox(leftPadding, topPadding, menuWidth, menuHeight);

            SafeSetCursorPosition(leftPadding + 2, topPadding + 1);
            Console.Write("Queue Menu Application".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 3);
            Console.Write("[1] Append an element".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 4);
            Console.Write("[2] Serve front element".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 5);
            Console.Write("[3] Identify first in line".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 6);
            Console.Write("[4] Print all elements".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 7);
            Console.Write("[5] Count number of elements".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 8);
            Console.Write("[6] \"Is it empty?\"".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 9);
            Console.Write("[7] \"Is it full?\"".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 10);
            Console.Write("[8] Clear All".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 11);
            Console.Write("[9] Exit".PadRight(menuWidth - 4));
        }

        static string GetInputInBox(string prompt)
        {
            Console.Clear();
            string[] lines = prompt.Split('\n');
            int longestLineLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > longestLineLength)
                {
                    longestLineLength = line.Length;
                }
            }

            const int horizontalPadding = 4;
            const int verticalPadding = 3;
            int menuWidth = longestLineLength + horizontalPadding;
            int menuHeight = lines.Length + verticalPadding;
            int leftPadding = (windowsWidth - menuWidth) / 2;
            int topPadding = (windowsHeight - menuHeight) / 2;

            DrawBox(leftPadding, topPadding, menuWidth, menuHeight);

            for (int i = 0; i < lines.Length; i++)
            {
                SafeSetCursorPosition(leftPadding + horizontalPadding / 2, topPadding + 1 + i);
                Console.Write(lines[i]);
            }
            SafeSetCursorPosition(leftPadding + horizontalPadding / 2, topPadding + 1 + lines.Length);
            return Console.ReadLine();
        }

        static string Append(string value)
        {
            if (IsFull())
            {
                return "Queue Overflow!!";
            }

            if (head == -1) head = 0;
            tail = (tail + 1) % queue.Length;
            queue[tail] = value;
            return $"Appended: {value}";
        }

        static string Serve()
        {
            if (IsEmpty())
            {
                return "Queue Underflow!!";
            }

            string servedValue = queue[head];
            queue[head] = null;

            if (head == tail)
            {
                head = -1;
                tail = -1;
            }
            else
            {
                head = (head + 1) % queue.Length;
            }
            return $"Serving:\n{servedValue}";
        }

        static string Peek()
        {
            if (IsEmpty())
            {
                return "Queue is empty. Cannot peek.";
            }
            return $"Front element is:\n{queue[head]}";
        }

        static bool IsEmpty()
        {
            return head == -1;
        }

        static string GetIsEmptyStatus()
        {
            return $"The queue is{(IsEmpty() ? "" : " not")} empty";
        }

        static bool IsFull()
        {
            return (tail + 1) % queue.Length == head;
        }

        static string GetIsFullStatus()
        {
            return $"The queue is{(IsFull() ? "" : " not")} full";
        }

        static string Clear()
        {
            head = -1;
            tail = -1;
            Array.Clear(queue, 0, queue.Length);
            return "Queue Cleared";
        }

        static string Count()
        {
            return $"The current number of elements in the queue is {(IsEmpty() ? 0 : tail - head + 1)}";
        }

        static string Display()
        {
            if (IsEmpty())
            {
                return "Queue is empty.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Current queue elements:");
            for (int i = head; i <= tail; i++)
            {
                if (queue[i] is not null) sb.AppendLine(queue[i]);
            }
            return sb.ToString();
        }
    }
}
