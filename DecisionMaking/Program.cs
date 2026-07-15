using System;

namespace DecisionMaking
{
    // Decision Making in C#
    // This program demonstrates different decision-making statements.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== DECISION MAKING IN C# =====");

            Console.WriteLine("\n1. If Statement");
            IfStatement.Run();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\n2. If Else Statement");
            IfElseStatement.Run();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\n3. Else If Statement");
            ElseIfStatement.Run();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\n4. Nested If Statement");
            NestedIfStatement.Run();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\n5. Switch Statement");
            SwitchStatement.Run();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\n6. Conditional (Ternary) Operator");
            ConditionalOperator.Run();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\nProgram Completed Successfully.");

            Console.ReadKey();
        }
    }
}