
// Task Day 1:

using System;

namespace TaskDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q(1): 

            Console.WriteLine("Enter a Character: ");
            char input= Console.ReadLine()[0];
            Console.WriteLine("The ASCII code of " + input + " is: " + (int)input);

            ////////////////////////////////////////////////////////////
            // Q(2): 

            Console.WriteLine("Enter a number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The character for ASCII code "+input2 + " is: "+(char)input2);
            //////////////////////////////////////////////////////////////////////////////////////////
            // Q(3): 
            Console.WriteLine("Enter number which you want to know it is odd or even: ");
            int input3 =Convert.ToInt32(Console.ReadLine());
            if(input3 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////
            // Q(4): 
            Console.WriteLine("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + "+" + num2 + " = " + sum);

            int sub = num1 - num2;
            Console.WriteLine("The subtraction of " + num1 + "-" + num2 + " = " + sub);

            int multi = num1 * num2;
            Console.WriteLine("The multiplication of " + num1 + "*" + num2 + " = " + multi);

            //////////////////////////////////////////////////////////////////////////////////////////
            //Q(5):
            Console.WriteLine("Enter youe degree of 0 to 100: ");
            int deg = Convert.ToInt32(Console.ReadLine());

            string grade;

            if (deg >= 90)
                grade = "A";
            else if (deg >= 80)
                grade = "B";
            else if (deg >= 70)
                grade = "C";
            else if (deg >= 60)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine("The grade is: " + grade);

            /////////////////////////////////////////////////////////////////////////////////////////
            //Q(6):
            Console.Write("Enter a number to display its multiplication table: ");
            int multi_table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMultiplication Table for " + multi_table + ":");

            for(int i=0; i <= 12; i++)
            {
                Console.WriteLine(multi_table + " x " + i + " = " + (multi_table * i));

            }



        }
    }
}