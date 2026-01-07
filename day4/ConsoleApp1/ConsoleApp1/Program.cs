
using System;
using System.IO;
internal class program
{
    static void Main(string[] args)
    {
        string inputfile = "Employee.txt";


        string[] lines = File.ReadAllLines(inputfile);


        foreach (string s in lines)
        {
            string[] data = s.Split('\\');


            string name = data[0];   
            string salary = data[1];     
            string department = data[2]; 

            int Salary = int.Parse(salary);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine("-----------------"); 
        }

        string outputPath = "results.txt";

        File.WriteAllText(outputPath, "\n"); 

        foreach (string s in lines)
        {
            string[] data = s.Split('\\');

            string name = data[0];
            string salary = data[1];
            string department = data[2];

            int Salary = int.Parse(salary);

            string resultLine = $"{name} from {salary} and {department} years old";


            File.AppendAllText(outputPath, resultLine + "\n");
        }
    }
}

 