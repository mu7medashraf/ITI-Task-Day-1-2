using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_day_6
{
    internal class list_of_integers
    {
        private int[] evenNumbers;
        public list_of_integers(int[] list)
        {
            int n = list.Length;
            List<int> temp = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (list[i] % 2== 0)
                {
                    temp.Add(list[i]);
                }
            }
            evenNumbers = temp.ToArray();
        }
        public void Print()
        {
            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
        public static void showarray()
        {
            int[] list = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            list_of_integers obj = new list_of_integers(list);
            obj.Print();
        }
    }
}
