using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_day_6
{
    internal class Q3_ArrayList_
    {
        public class ArrayLIst
        {
            public static void ReverseInPlace<T>(T[] arraylist)
            {
                if (arraylist == null) throw new ArgumentNullException(nameof(arraylist));

                int n = arraylist.Length;
                for (int i = 0; i < n / 2; i++)
                {
                    T temp = arraylist[i];
                    arraylist[i] = arraylist[n - i - 1];
                    arraylist[n - i - 1] = temp;
                }

            }
        }
           public static void print<T>(T[] arraylist)
            {
                foreach (var item in arraylist)
                {
                    Console.Write(item + " ");
                    Console.WriteLine();

                }
            }
        public static void Run_Arraylist()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before (int):");
            print(numbers);

            ArrayLIst.ReverseInPlace(numbers);

            Console.WriteLine("After (int):");
            print(numbers);

            string[] names = { "maryam", "muhamed", "hager", "Omar" };
            Console.WriteLine("Before (string):");
            print(names);

            ArrayLIst.ReverseInPlace(names);

            Console.WriteLine("After (string):");
            print(names);
        }

        }
    }
        
