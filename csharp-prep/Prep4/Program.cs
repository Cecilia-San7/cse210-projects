using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 0;
        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            num = int.Parse(Console.ReadLine());
             if (num != 0)
            {
                numbers.Add(num);
            }
            
    }
        while (num != 0);
        
        // iterate to get the sum of the numbers using a foreach
        int sumOfNumbers = 0;
        foreach (int number in numbers)
        {   sumOfNumbers += number;
           
        }
         Console.WriteLine(sumOfNumbers);
        
}
}