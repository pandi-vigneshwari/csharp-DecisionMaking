using System;

namespace DecisionMaking
{
    // If Else Statement
    // Executes one block if the condition is true,
    // otherwise executes another block.

    public class IfElseStatement
    {
        public static void Run()
        {
            int age = 16;

            if (age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible to Vote");
            }
        }
    }
}