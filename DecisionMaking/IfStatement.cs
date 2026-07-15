using System;

namespace DecisionMaking
{
    // If Statement
    // Executes a block of code if the condition is true.

    public class IfStatement
    {
        public static void Run()
        {
            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
        }
    }
}