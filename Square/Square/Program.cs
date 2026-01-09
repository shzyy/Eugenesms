namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ruudu suurus:");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)   
            {
                for (int j = 0; j < size; j++)    
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // arvutame ümbermõõdu ja pindala
            int perimeter = 4 * size;
            int area = size * size;

            Console.WriteLine($"Ruudu ümbermõõt: {perimeter}");
            Console.WriteLine($"Ruudu pindala: {area}");
        }
    }    }