namespace FLT
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Tärnidest tehtud kolmnurk e poolik püramiid:");
            Console.WriteLine("============================================");
            Console.Write("Sisesta ridade arv: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
}
}
