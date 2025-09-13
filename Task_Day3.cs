

namespace Task_Day3
{
    internal class Program
    {
        #region answer Q(1):
        class calc
        {
            public int sum(int a, int b)
            {
                return a + b;
            }
            public double sum(double a, double b)
            {
                return a + b;
            }
            public int sub(int a, int b)
            {
                return a - b;
            }
            public double sub(double a, double b)
            {
                return a - b;
            }
            public int mul(int a, int b)
            {
                return a * b;
            }
            public double mul(double a, double b)
            {
                return a * b;
            }
            public int div(int a, int b)
            {
                return a / b;
            }
            public double div(double a, double b)
            {
                return a / b;
            }
        }
        #endregion
        #region create question class (header , body , mark , show())
        class question
        {
            public string Header;
            public string Body;
            public int Mark;
            // Default Constructor
            public question()
            {
                Header = "Q";
                Body = "what is c#";
                Mark = 5;
            }


            // Prameterized Constructor
            public question(string header, string body, int mark)
            {
                Header = header;
                Body = body;
                Mark = mark;
            }
            // Another Prameterized Constructor
            public question(int mark)
            {
                Header = "Q";
                Body = "what is c#";
                Mark = mark;
            }
            public void show()
            {
                Console.WriteLine(Header + "  " + Body + "  " + Mark + " ");
            }
        }
        #endregion
        #region create mcq question : question +(+string[] choosses )
        class MCQ : question
        {
            public string[] Choices { get; set; }

            public MCQ(string header, string body, int mark, string[] choices)
                : base(header, body, mark)
            {
                Choices = choices;
            }
            public void show()
            {
                base.show();
                Console.WriteLine("Choices:");
                for (int i = 0; i < Choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Choices[i]}");
                }
            }
        }
            #endregion
            static void Main(string[] args)
            {
                #region Q(1):
                calc math = new calc();
                int sum_int = math.sum(5, 4);
                Console.WriteLine("Sum = " + sum_int);
                double sum_double = math.sum(5.5, 4.3);
                Console.WriteLine("Sum = " + sum_double);

                int sub_int = math.sub(5, 4);
                Console.WriteLine("sub = " + sub_int);

                double sub_double = math.sub(5.5, 4.3);
                Console.WriteLine("sub = " + sub_double);

                int mul_int = math.mul(5, 4);
                Console.WriteLine("multi = " + mul_int);

                double mul_double = math.mul(5.5, 4.3);
                Console.WriteLine("multi = " + mul_double);

                int div_int = math.div(16, 4);
                Console.WriteLine("div = " + div_int);

                double div_double = math.div(10.5, 4.3);
                Console.WriteLine("div = " + div_double);
                #endregion
                Console.WriteLine("===============================");
                #region create question class (header , body , mark , show())
                question q = new question();
                question Q1 = new question("Q1", "create class calc has sum,sub,mul,div with overloading", 15);
                question Q2 = new question("Q2", "create question class (header , body , mark , show())", 20);
                q.show();
                Q1.show();
                Q2.show();
                #endregion


                string[] choices = { "C#", "Java", "Python", "C++" };

                MCQ q1 = new MCQ("Q1", "Which language is developed by Microsoft?",
                                                  5, choices);

                q1.show();

            #region  create array from mcq ,take data from user and print it 
            Console.Write("Enter number of MCQ questions: ");
                int n = Convert.ToInt32(Console.ReadLine());

                MCQ[] questions = new MCQ[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\nEnter data for question {i + 1}:");

                    Console.Write("Header: ");
                    string header = Console.ReadLine();

                    Console.Write("Body: ");
                    string body = Console.ReadLine();

                    Console.Write("Mark: ");
                    int mark = int.Parse(Console.ReadLine());

                    Console.Write("How many choices? ");
                    int choiceCount = int.Parse(Console.ReadLine());

                    string[] choices1 = new string[choiceCount];
                    for (int j = 0; j < choiceCount; j++)
                    {
                        Console.Write($"Enter choice {j + 1}: ");
                        choices1[j] = Console.ReadLine();
                    }

                    questions[i] = new MCQ(header, body, mark, choices1);
                }

                Console.WriteLine("\n===== Questions Entered =====");
                foreach (MCQ qq in questions)
                {
                    qq.show();
                }
            #endregion
        }
    }
        }
    
