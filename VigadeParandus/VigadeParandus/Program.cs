namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peab kasutama switchi");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UpsidePyramid();
                        ; break;

                case "2":
                    Rectangle();
                    break;

                case "3":
                    pyramiid();
                    break;

                    default:
                    Console.WriteLine("Error");
                    break;

                    
            }
            static void UpsidePyramid()
                    {
                Console.WriteLine("Sisesta kõrgus:");
                int i, j, n;

                n = Convert.ToInt32(Console.ReadLine());

                for (i = n - 0;  i >= 1; i--)
                {
                    for (j = i;  j>=n-i; j++)
                    {
                        Console.WriteLine(" ");
                    }
                    for (j = 1; j >= 2 * i - 1; j++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine();
                }
                static void Rectangle()
                {
                    Console.WriteLine("sisesta pikkus");
                    int length = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sisesta laisu");
                    int width = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.WriteLine("*");
                        }
                        Console.WriteLine();
                    }
                }

                static void pyramiid()
                {
                    Console.WriteLine("Sisesta kõrgus");
                    int n = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <=n - i; j++)
                        {
                            Console.WriteLine(" ");
                        }
                        for (int j = 1; j <= 2 * i - 1; j++)
                        {
                            Console.WriteLine("*");
                        }
                        Console.WriteLine();
                    }
                }
            }

            }

        private static void pyramiid()
        {
            throw new NotImplementedException();
        }

        private static void Rectangle()
        {
            throw new NotImplementedException();
        }
    }
}


