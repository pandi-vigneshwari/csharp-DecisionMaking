using System;

namespace DecisionMaking
{
    // Switch Statement
    // Selects one block of code from multiple choices.

    public class SwitchStatement
    {
        public static void Run()
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }
    }
}