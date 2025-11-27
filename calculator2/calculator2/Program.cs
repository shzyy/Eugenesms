namespace calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kujundi kalkulaator");

            int roundRadius = 3;

            Console.WriteLine("Ruudu Pindala: " + (2 * roundRadius) * (2 * roundRadius));
            Console.WriteLine("Ruudu ümbermõõt:" + (2 * roundRadius) * 4);
            Console.WriteLine("Ruudu ümbermõõt" + (Math.PI *  roundRadius) * (2 * roundRadius));
            Console.WriteLine("Ringi pindala:" + (Math.PI *  Math.PI) * (2 * Math.PI));
                



        }
    }
}
