using Task_day_6;

namespace Task_day_7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Q1------------------------");
            Productexample.Run();
            Console.WriteLine("-------------------Q2------------------------");
            string text = "Hello, world!";

            int count = text.WordCount(); 

            Console.WriteLine($"Word count = {count}");

            Console.WriteLine("-------------------Q3------------------------");
            int x = 10;
            int y = 7;

            Console.WriteLine($"{x} is even? {x.IsEven()}"); 
            Console.WriteLine($"{y} is even? {y.IsEven()}");

            Console.WriteLine("-------------------Q4------------------------");
            DateTime birthDate = new DateTime(2005, 03, 10);

            int age = birthDate.CalculateAge();

            Console.WriteLine($"Age = {age}");

            Console.WriteLine("-------------------Q4------------------------");

            string reversed = text.ReverseString();

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {reversed}");


        }
    }
}