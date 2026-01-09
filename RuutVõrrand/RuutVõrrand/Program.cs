namespace RuutVõrrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RuutVõrrand");
            //ax + bx + c

            //kasutaja peab saama sisestada väärtuseid a,b ja c




            Console.Write("Sisesta a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c: ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Kaks lahendit: x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Üks lahend: x = {x}");
            }
            else
            {
                Console.WriteLine("Lahendeid ei ole (d < 0)");
            }
        }
    }
}