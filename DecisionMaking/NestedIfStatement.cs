using System;

namespace DecisionMaking
{
    // Nested If Statement
    // An if statement inside another if statement.

    public class NestedIfStatement
    {
        public static void Run()
        {
            int age = 22;
            bool hasLicense = true;

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Eligible to Drive");
                }
                else
                {
                    Console.WriteLine("License Required");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}