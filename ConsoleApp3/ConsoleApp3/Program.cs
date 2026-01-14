using System.Transactions;

namespace ConsoleApp3
{
    internal class Program
    {
        static void ForMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello");
            }
        }
        static void WhileMethod()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Hello");
                i++;
            }
        }
        static void SumMethod()
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Sum" + sum);
        }
        static void AgeMethod()
        {
            Console.WriteLine("Enter ur Age");
            int age = int.Parse(Console.ReadLine());    

            Console.WriteLine("Your age" + age);

        }
        static void Main()
        {
            Console.WriteLine("Choose Mehod 1,2,3,4");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ForMethod();
            }
            else if (choice == 2)
            {
                WhileMethod();
            }
            else if (choice == 3)
            {
                SumMethod();
            }
            else if (choice == 4)
            {
                AgeMethod();
            }
            else
            {
                Console.WriteLine("ERROR");
            }


        }
    }
}
