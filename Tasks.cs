namespace Week1
{
    class Task1
    {
        public void RunTask1()
        {
            string name;
            int age;
            int diff;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            diff = 30 - age;

            Console.WriteLine("Hello " + name + ", you will be 30 in " + diff + " years!");
        }
    }

    class Task2
    {
        public void RunTask2()
        {

            int age;

            Console.WriteLine("Hello, please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a child!");
            }
            else if (age >= 13 && age < 19)
            {
                Console.WriteLine("You are a teenager!");
            }
            else if (age >= 19 && age < 110)
            {
                Console.WriteLine("You are an adult!");
            }
            else if (age > 110)
            {
                Console.WriteLine("Invalid age. Ages above 110 cannot be input for some reason...");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }
    }

    class Task3 ()
    {
        public void RunTask3()
        {
            int input;

            Console.WriteLine("Please enter an integer (whole number): ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else if (input < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else if (input == 0)
            {
                Console.WriteLine("Number is 0.");
            }
        }
    }

    class Task4 ()
    {
        public void RunTask4()
        {
            int year;

            Console.WriteLine("Please enter a valid year: ");

            year = Convert.ToInt32(Console.ReadLine());

            if (year < 0)
            {
                Console.WriteLine("Please enter a valid positive year!");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("This year is a leap year!");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("This year is not a leap year!");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("This year is a leap year!");
            }
            else
            {
                Console.WriteLine("This year is not a leap year!");
            }
        }
    }

    class Task5 ()
    {
        public void RunTask5()
        {
            int input;

            Console.WriteLine("Please enter an integer (whole number): ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0 && input != 0)
            {
                Console.WriteLine("Number is even.");
            }
            else if (input % 2 != 0 && input != 0)
            {
                Console.WriteLine("Number is odd.");
            }
            else if (input == 0)
            {
                Console.WriteLine("Number is 0.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();

            //Uncomment to run desired task please.

            //task1.RunTask1();
            //task2.RunTask2();
            //task3.RunTask3();
            //task4.RunTask4();
            //task5.RunTask5();
        }
    }
}



