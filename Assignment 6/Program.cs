using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting Question 1");
        Question1("Your Name Here");

        Console.WriteLine("Starting Question 2");
        int returnNumber = Question2(3, 5);
        Console.WriteLine(returnNumber);

        Console.WriteLine("Starting Question 3");
        string letter = Question3(88.9);
        Console.WriteLine($"Numeric: 88.9 letter: {letter}");

        Console.WriteLine("Starting Question 4");
        bool passed = Question4(63.7);
        Console.WriteLine($"Score: 63.7 Passed? {passed}");

        Console.WriteLine("Starting Question 5");
        decimal avg = Question5($"Values: 3, 6, 9 Average: {avg}");
    }

    static void Question1(string yourName)
    {
        Console.WriteLine($"Hello, {yourName}!");
    }
    static int Question2(int a, int b)
    {
        if (a > b) return a;
        else return b;
    }
    static string Question3(double score)
    {
        if (score >= 90) return "A";
        else if (score >= 80) return "B";
        else if (score >= 70) return "C";
        else if (score >= 60) return "D";
        else return "F";
    }

    static bool Question4(double score)
    {
        return score >= 75.0;
    }
    static decimal Question5(int x, int y, int z)
    {
        decimal sum = x + y + z;
        return sum / 3;
    }
}