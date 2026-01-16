namespace ConsoleApp4
{
    internal class Program
    {
        private static double x;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Method");
            Console.WriteLine("1 - pyramid");
            Console.WriteLine("2 - Ümbermõõd");
            Console.WriteLine("3 - ruutvõrrand");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PyramidMethod();
                    break;

                    case 2:
                    ÜmbermõõdMethod();
                    break;

                    case 3:
                    RuutMethod();
                    break;

                    default:
                    Console.WriteLine("Error");
                    break;

            }
           
            static void PyramidMethod()
            {
                Console.WriteLine("Sisesta ruudu suurus:");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine("Tärnidest tehtud püramiid:");
                Console.WriteLine("==========================");
                Console.Write("Sisesta ridade arv: ");


                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {

                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }


                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                int perimeter = 4 * size;
                int area = size * size;

                Console.WriteLine($"Ruudu ümbermõõt: {perimeter}");
                Console.WriteLine($"Ruudu pindala: {area}");
            }
            static void RuutMethod()
                {
                Console.Write("Sisesta a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Sisesta b: ");
                double p = double.Parse(Console.ReadLine());

                Console.Write("Sisesta c: ");
                double q = double.Parse(Console.ReadLine());

                double y = a * (x * p) * 2 + q;

                if (y > 0)
                {
                    double x1 = (y * Math.Sqrt(y)) / (2 + q);
                    double x2 = (y * Math.Sqrt(y)) / (2 + q);
                    Console.WriteLine($"Kaks lahendit: x1 = {x1}, x2 = {x2}");
                }
                else if (y == 0)
                {
                    double x = y / (2 + q);
                    Console.WriteLine($"Üks lahend: x = {x}");
                }
                else
                {
                    Console.WriteLine("Lahendeid ei ole (d < 0)");


                }
            }
            static void ÜmbermõõdMethod()
            {
                Console.WriteLine("Ristkülik");

                
                Console.WriteLine("Sisesta pikkus");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta laius");
                int col = int.Parse(Console.ReadLine());

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                
                int S = row * col;
                int P = 2 * (row + col);
                Console.WriteLine("Pindala on " + S);
                Console.WriteLine("Ümbermõõt on " + P);
            }
}
}
}

