namespace Task_day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            optimised_bubble_sort.Run();
            Console.WriteLine("\n----------------------------Q2----------------------------\n");
            Range.Run_Range();
            Console.WriteLine("\n----------------------------Q3----------------------------\n");
            Q3_ArrayList_.Run_Arraylist();
            Console.WriteLine("\n----------------------------Q4----------------------------\n");
            list_of_integers.showarray();
            Console.WriteLine("\n----------------------------Q5----------------------------\n");
            FixedSizeList<int>.Try();
            Console.WriteLine("\n----------------------------Q6----------------------------\n");
            non_repeated_character.show_first_nonreapeated_char();
        }
    }
}