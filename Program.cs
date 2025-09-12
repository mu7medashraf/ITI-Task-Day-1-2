
namespace TaskDay2
{
    struct time
    {
        public int hours;
        public int minutes;
        public int seconds;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            //Q(1):
             Console.WriteLine("Enter number of students: ");
             int n = Convert.ToInt32(Console.ReadLine());

             string[] students = new string[n];
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine("Enter name student " + (i + 1) + " : ");
                 students[i] = Console.ReadLine();
             }
             Console.WriteLine("================= \nStudents names: ");
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine(students[i]);
             }
            
            ////////////////////////////////////////////////
            //Q(2):

             Console.Write("===================\nEnter number of tracks: ");
            int tracks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of students: ");
            int student = Convert.ToInt32(Console.ReadLine());

            int[,] ages = new int[tracks, student];

            for (int i = 0; i < tracks; i++)
            {
                Console.WriteLine("\n ====== Enter ages for track " +(i+1) + "=========" );
                for (int j = 0; j < student; j++)
                {
                    Console.WriteLine("Enter age of student " + (j + 1) + " : ");
                    ages[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n======== Student Ages & Averages ================ ");
            for (int t = 0; t < tracks; t++)
            {
                int sum = 0;
                Console.Write("Track "+ (t + 1)+ " ages: \n");
                for (int s = 0; s < student; s++)
                {
                    Console.WriteLine(ages[t, s] + " ");
                    sum += ages[t, s];
                }
                double average = (double)sum / student;
                Console.WriteLine("Average Age = " + average+"\n");
            }
            

            /////////////////////////////////////////////////////////////
            /// Q(3):
            time t1;
            Console.WriteLine("Enter Time: ");
            t1.hours = Convert.ToInt32(Console.ReadLine());
            t1.minutes = Convert.ToInt32(Console.ReadLine());
            t1.seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time is: " + t1.hours + "H:" + t1.minutes + "M:" + t1.seconds + "S");

        }
    }
}