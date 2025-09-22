using System;

namespace Task_day_6
{
    public static class StringExtensions
    {

        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            char[] separators = new char[] { ' ', '\t', '\n', ',', '.', '!', '?', ';', ':' };

            var words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

    }
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

    }

    public static class StringExtensions2
    {
        public static string ReverseString(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] chars = str.ToCharArray(); 
            Array.Reverse(chars);              
            return new string(chars);         
        }
    }

}

