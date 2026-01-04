using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class program
{
    static void Main()
    {
        Console.WriteLine("write any Things");
        string s = Console.ReadLine();
        Console.WriteLine("OutPut:" +s);
        double number = 2.5;
        string name = "Yara";
        char letter = 'A';
        bool IsStudent = true;
        int age = 20;
        const int year = 2025;

        Console.WriteLine("Double: " + number);
        Console.WriteLine("String: " + name);
        Console.WriteLine("Char: " + letter);
        Console.WriteLine("Bool: " + IsStudent);
        Console.WriteLine("Int: " + age);
        Console.WriteLine("Const: " + year);

        string[] cars = { "BMW", "Toyota", "Honda", "Ford" };

        Console.WriteLine("Cars list:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Console.WriteLine("Array length: " + cars.Length);

        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Input your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Input your year of birth: ");
        int year1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Output: " + firstName  + lastName  + year1);
        int[] arr = new int[10];

        Console.WriteLine("Input 10 elements in the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("element : " + i + " : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Elements in array are: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

}