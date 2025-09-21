using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_day_6
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; }
        public int Count => count;
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");

            Capacity = capacity;
            items = new T[capacity];
            count = 0;

        }
        public void Add(T item)
        {
            if (count >= Capacity)
                throw new InvalidOperationException($"Cannot add item: capacity reached (Capacity = {Capacity}).");

            items[count] = item;
            count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            return items[index];
        }
        public static void Try() {
            var numbers = new FixedSizeList<int>(3); 

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine(numbers.Get(0)); 
            Console.WriteLine(numbers.Get(2)); 

        }

    }
}
