using System;

namespace DecisionMaking
{
    // Conditional (Ternary) Operator
    // Short form of if...else.

    public class ConditionalOperator
    {
        public static void Run()
        {
            int age = 20;

            string result = age >= 18 ? "Eligible" : "Not Eligible";

            Console.WriteLine(result);
        }
    }
}