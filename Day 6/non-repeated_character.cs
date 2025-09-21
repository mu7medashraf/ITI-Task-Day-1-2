using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_day_6
{
    internal class non_repeated_character
    {
        public static int FindFirstUniqueChar(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (freq[input[i]] == 1)
                    return i;
            }

            return -1;
        }
        public static void show_first_nonreapeated_char()
        {
            string text = "swiss";

            int index = non_repeated_character.FindFirstUniqueChar(text);

            if (index != -1)
                Console.WriteLine($"First unique char is '{text[index]}' at index {index}");
            else
                Console.WriteLine("No unique character found.");

        }

    }
}
