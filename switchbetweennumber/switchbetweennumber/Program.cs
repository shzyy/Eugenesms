namespace switchbetweennumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta number");

            int number = int.Parse (Console.ReadLine());

            switch (number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("sisestasid number (0-100)");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("sisestasid number (101-200)");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("sisestasid number (201-300)");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;


            }
        }
    }
}
