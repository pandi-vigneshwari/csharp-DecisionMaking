using System;

namespace DecisionMaking
{
    // Else If Statement
    // Checks multiple conditions.

    public class ElseIfStatement
    {
        public static void Run()
        {
            int mark = 85;

            if (mark >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (mark >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (mark >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}