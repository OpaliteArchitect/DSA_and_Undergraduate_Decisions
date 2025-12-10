using System.Text;
using static Midterm_Compilation.PolishUI;

namespace Midterm_Compilation.Activities
{

    public static class Stack
    {
        static int top = -1;
        static string[] stack = new string[5];

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
                        DisplayInBox(Push(entry));
                        break;
                    case '2':
                        DisplayInBox(Pop());
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
            Console.Write("Stack Menu Application".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 3);
            Console.Write("[1] Push an element".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 4);
            Console.Write("[2] Pop an element".PadRight(menuWidth - 4));

            SafeSetCursorPosition(leftPadding + 2, topPadding + 5);
            Console.Write("[3] Peek at top element".PadRight(menuWidth - 4));

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

        static string Push(string value)
        {
            if (IsFull())
            {
                return "Stack Overflow!!";
            }
            top++;
            stack[top] = value;
            return $"Pushed: {value}";
        }

        static string Pop()
        {
            if (IsEmpty())
            {
                return "Stack Underflow!!";
            }
            string poppedValue = stack[top];
            stack[top] = null;
            top--;
            return $"Popped: {poppedValue}";
        }

        static string Peek()
        {
            if (IsEmpty())
            {
                return "Stack is empty. Cannot peek.";
            }
            return $"Top element is:\n{stack[top]}";
        }

        static bool IsEmpty()
        {
            return top == -1;
        }

        static string GetIsEmptyStatus()
        {
            return $"The stack is{(IsEmpty() ? "" : " not")} empty";
        }

        static bool IsFull()
        {
            return top == stack.Length - 1;
        }

        static string GetIsFullStatus()
        {
            return $"The stack is{(IsFull() ? "" : " not")} full";
        }

        static string Clear()
        {
            Array.Clear(stack, 0, stack.Length);
            top = -1;
            return "Stack Cleared";
        }

        static string Count()
        {
            return $"The current number of elements in the stack is {(top + 1)}";
        }

        static string Display()
        {
            if (IsEmpty())
            {
                return "Stack is empty.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Current stack elements:");
            for (int i = top; i >= 0; i--)
            {
                if (stack[i] is not null) sb.AppendLine(stack[i]);
            }
            return sb.ToString();
        }
    }
}
