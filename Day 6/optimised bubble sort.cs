using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_day_6
{
    internal class optimised_bubble_sort
    {
        public class Helper
        {
            public static void SWAP<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
            public static void OptimizedBubbleSort<T>(T[] Array) where T : IComparable<T>
            {
                if (Array is not null)
                {
                    bool swapped;
                    for (int i = 0; i < Array.Length - 1; i++)
                    {
                        swapped = false;

                        for (int j = 0; j < Array.Length - i - 1; j++)
                        {
                            if (Array[j].CompareTo(Array[j + 1]) > 0)
                            {
                                SWAP(ref Array[j], ref Array[j + 1]);
                                swapped = true;
                            }
                        }
                        if (!swapped)
                            break;
                    }
                }
            }
        }
    

        public static void Run()
        {
            int[] numbers = { 63, 50, 80, 30, 1 };

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Before (numbers):");
            foreach (var item in numbers) 
                Console.WriteLine(item);   

            Helper.OptimizedBubbleSort(numbers);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("After (numbers):");
            foreach (var item in numbers)
                Console.WriteLine(item);

            string[] names = { "Muhamed", "Ahmed", "maryam", "nahla" };

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Before (names):");
            foreach (var item in names)
                Console.WriteLine(item);

            
            Helper.OptimizedBubbleSort(names);   

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("After (names):");
            foreach (var item in names)
                Console.WriteLine(item);
        }
    }


}