using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_day_6.Range;

namespace Task_day_6
{
    internal class Range
    {
        public class Rangee<T> where T : IComparable<T>

        {
            public T Minimum { get; set; }
            public T Maximum { get; set; }

            public Rangee(T minimum, T maximum)
            {
                Minimum = minimum;
                Maximum = maximum;
            }
            public bool IsInRange(T value)
            {
                return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;

            }
            public T Length()
            {
                dynamic min = Minimum;
                dynamic max = Maximum;
                return max - min;
            }
        }
        public static void Run_Range()
        {
            Rangee<int> intRange = new Rangee<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(15)); 
            Console.WriteLine(intRange.IsInRange(25)); 
            Console.WriteLine(intRange.Length());      

        }
    }
    }
