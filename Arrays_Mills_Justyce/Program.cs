using System;

namespace Arrays_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a whole number for array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("input another whole number to add to the array");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"the sum of the array is {sum}\n");
            Array.Sort(numbers);
            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
