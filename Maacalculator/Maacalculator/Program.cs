namespace Maacalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            int coinDiameter = 26;
            int earthRadius = 6371; 

            Console.WriteLine("Maa ümbermõõt: " + (2 * Math.PI * earthRadius));
            Console.WriteLine("Müntide arv ümber Maa: " + (2 * Math.PI * earthRadius) / coinDiameter);

            Console.ReadKey();


        }
    }
}
