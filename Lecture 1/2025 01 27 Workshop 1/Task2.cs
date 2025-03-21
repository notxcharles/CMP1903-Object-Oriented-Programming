﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_27_Workshop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] random_integers = GenerateRandomIntegers();
            
            foreach (int integer in random_integers)
            {
                Console.WriteLine(integer);
            }

            int[] array = {1, 2, 3, 1};
            int total_sum = ComputeSum(array);
            Console.WriteLine(total_sum);

            Dictionary<int, int> digit_frequency = ComputeHistogram(array);
            foreach (var entry in digit_frequency)
            {
                Console.WriteLine($"{entry.Key} has frequency {entry.Value}");
            }

            int[] sorted_array = SimpleSort(array);
            foreach (int integer in sorted_array)
            {
                Console.WriteLine(integer);
            }
            return;
        }
        static int[] GenerateRandomIntegers()
        {
            Random random = new Random();
            int[] random_integers = new int[100];
            for (int i = 0; i < 100; i++)
            {
                random_integers[i] = random.Next();
            }
            return random_integers;
        }

        static int ComputeSum(int[] array)
        {
            int total = 0;
            foreach (int integer in array)
            {
                total += integer;
            }
            return total;
        }

        static Dictionary<int, int> ComputeHistogram(int[] array)
        {
            Dictionary<int, int> digit_frequency = new Dictionary<int, int>();
            foreach (int integer in array)
            {
                if (!digit_frequency.ContainsKey(integer))
                {
                    digit_frequency.Add(integer, 0);
                }
                digit_frequency[integer]++;
                
            }
            return digit_frequency;
        }

        static int[] SimpleSort(int[] array)
        {
            //Insertion Sort
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    // Swap if the element at j - 1 position is greater than the element at j position
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array; // Return the sorted array
        }
    }
}

