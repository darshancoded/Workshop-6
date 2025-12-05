using System;

public class NumberProcessor
{
    // Method using built-in delegate Func<int, bool>
    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int num in numbers)
        {
            if (condition(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}