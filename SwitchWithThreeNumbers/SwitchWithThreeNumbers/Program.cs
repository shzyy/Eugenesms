namespace SwitchWithThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            int number = Convert.ToInt32(Console.ReadLine()); 

            switch (number)
            {
                case 1:
                    Console.Beep(1000, 500);
                    Console.WriteLine("1 console beep");
                    break;

                    case 2:
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.WriteLine("2 console beep");
                    break;

                case 3:
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.WriteLine("3 console beep");
                    break;

                    default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
