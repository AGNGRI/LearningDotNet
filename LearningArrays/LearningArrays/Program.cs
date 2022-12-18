using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[5] { "dog", "cat", "mouse", "cow", "horse" };
            foreach (string animal in animals)  {
            Console.WriteLine(animal);                
            }

            int[] numbers = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Array.Reverse(numbers);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numbers[i]);
        }

        }
    }
}

