using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int YourGrade = int.Parse(grade);
        string value = "None";

        if (YourGrade >= 90)
        {
            value = "A";
        }
        else if (YourGrade >=80)
        {
            value = "B";
        }
        else if (YourGrade >= 70)
        {
            value = "C";
        }
        else if (YourGrade >= 60)
        {
            value = "D";
        }
        else
        {
            value = "F";
        }
        if (YourGrade >= 70)
        {
            Console.WriteLine("Great you passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you can do better next semester.");
        }
        Console.WriteLine(value);
    }
}