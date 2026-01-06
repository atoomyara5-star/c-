using System;

class Program
{
    static void Main()
    {
        // Task 1 
        int even = 0, odd = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            { continue; }

            if (n % 2 == 0)
            { even++; }
            else
            { odd++; }
        }

        Console.WriteLine($"Even: {even}, Odd: {odd}");
        Console.WriteLine("---------------------");

        //  Task 2 
        int grade;
        Console.Write("Enter grade (0-100): ");
        grade = int.Parse(Console.ReadLine());

        while (grade < 0 || grade > 100)
        {
            Console.Write("Invalid! Enter again: ");
            grade = int.Parse(Console.ReadLine());
        }

        if (grade >= 90) Console.WriteLine("Grade: A");
        else if (grade >= 80) Console.WriteLine("Grade: B");
        else if (grade >= 70) Console.WriteLine("Grade: C");
        else if (grade >= 60) Console.WriteLine("Grade: D");
        else Console.WriteLine("Grade: F");

        Console.WriteLine("---------------------");

        //  Task 3 
        while (true)
        {
            Console.Write("Choose operation (+ - * /): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine("Result: " + (a + b)); break;
                case '-': Console.WriteLine("Result: " + (a - b)); break;
                case '*': Console.WriteLine("Result: " + (a * b)); break;
                case '/':
                    if (b != 0) Console.WriteLine("Result: " + (a / b));
                    else Console.WriteLine("Error: divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.Write("Continue? (y/n): ");
            if (Console.ReadLine().ToLower() == "n")
                break;
        }
    }
}
