using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("===== Task 1 =====");
        int[,] arr1 =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine(" Array 1:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(arr1[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }

       
        Console.WriteLine("\n===== Task 2 =====");
        int[,] arr2 =
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.WriteLine("Row sums:");
        for (int i = 0; i < 4; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < 4; j++)
                rowSum += arr2[i, j];
            Console.WriteLine($"Row {i + 1}: {rowSum}");
        }

        Console.WriteLine("Column sums:");
        for (int j = 0; j < 4; j++)
        {
            int colSum = 0;
            for (int i = 0; i < 4; i++)
                colSum += arr2[i, j];
            Console.WriteLine($"Column {j + 1}: {colSum}");
        }

        // ===== Task 3 =====
        Console.WriteLine("\n===== Task 3 =====");
        int[,] arr3 =
        {
            { 12, 25, 7, 18, 30 },
            { 5, 40, 22, 10, 15 },
            { 35, 17, 50, 8, 20 },
            { 10, 28, 32, 14, 18 },
            { 40, 12, 9, 33, 6 }
        };

        Console.WriteLine("Largest in each row:");
        for (int i = 0; i < 5; i++)
        {
            int max = arr3[i, 0];
            for (int j = 1; j < 5; j++)
                if (arr3[i, j] > max)
                    max = arr3[i, j];
            Console.WriteLine($"Row {i + 1}: {max}");
        }

        Console.WriteLine("Smallest in each column:");
        for (int j = 0; j < 5; j++)
        {
            int min = arr3[0, j];
            for (int i = 1; i < 5; i++)
                if (arr3[i, j] < min)
                    min = arr3[i, j];
            Console.WriteLine($"Column {j + 1}: {min}");
        }

       
        Console.WriteLine("\n===== Task 4 =====");
        int[][] jagged1 =
        {
            new int[] { 10, 20 },
            new int[] { 5, 15, 25 },
            new int[] { 7, 14, 21, 28 }
        };

        foreach (int[] row in jagged1)
        {
            foreach (int val in row)
                Console.Write(val + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\n===== Task 5 =====");
        int[][] jagged2 =
        {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6 }
        };

        foreach (int[] row in jagged2)
        {
            foreach (int val in row)
                Console.Write(val + " ");
            Console.WriteLine();
        }

       
        Console.WriteLine("\n===== Task 6 =====");
        int[][] jagged3 =
        {
            new int[] { 5 },
            new int[] { 3, 7 },
            new int[] { 2, 4, 6 },
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 20, 30, 40, 50 }
        };

        for (int i = 0; i < jagged3.Length; i++)
        {
            int sum = 0;
            foreach (int val in jagged3[i])
            {
                Console.Write(val + " ");
                sum += val;
            }
            Console.WriteLine($"=> Sum of row {i + 1}: {sum}");
        }

        Console.WriteLine("\n===== Task 7 =====");
        List<int> list1 = new List<int> { 10, 20, 30, 40, 50 };
        foreach (int n in list1)
            Console.Write(n + " ");
        Console.WriteLine();

       
        Console.WriteLine("\n===== Task 8 =====");
        List<string> students = new List<string>
        {
            "Yara", "Rama", "Hala", "Jood", "Rahaf"
        }; 

        students.Sort();
        foreach (string name in students)
            Console.WriteLine(name);

     
        Console.WriteLine("\n===== Task 9 =====");
        List<int> numbers = new List<int> { 10, 5, 20, 15, 30 };

        double avg = 0;
        int maxNum = numbers[0], minNum = numbers[0];

        foreach (int n in numbers)
        {
            avg += n;
            if (n > maxNum) maxNum = n;
            if (n < minNum) minNum = n;
        }

        avg /= numbers.Count;

        Console.WriteLine("List:");
        foreach (int n in numbers)
            Console.Write(n + " ");
        Console.WriteLine();

        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest: {maxNum}");
        Console.WriteLine($"Smallest: {minNum}");

        numbers.Sort();
        Console.WriteLine("Sorted:");
        foreach (int n in numbers)
            Console.Write(n + " ");
        Console.WriteLine();

     
    }
}
